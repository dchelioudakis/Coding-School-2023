﻿using DevExpress.XtraEditors;
using FuelStation.Blazor.Shared.DTO.Customer;
using FuelStation.Blazor.Shared.DTO.Item;
using FuelStation.Blazor.Shared.DTO.Transaction;
using FuelStation.Blazor.Shared.DTO.TransactionLine;
using FuelStation.Model;
using FuelStation.Model.Enums;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsClient {
    public partial class NewTransactionForm : Form {

        public HttpClient sharedClient;
        private TransactionEditDto _transaction = new();
        private List<TransactionLineEditDto> _transactionLines = new();
        private List<ItemListDto> _itemsList = new();
        private decimal totalQuantity;
        private decimal totalDiscount;
        private decimal preDiscountTotalPrice;
        private bool fuelProductInTransaction = false;
        private int? fuelRowIndex = null;


        public NewTransactionForm(HttpClient httpClient) {
            InitializeComponent();
            this.sharedClient = httpClient;
            
        }

        private async void NewTransactionForm_Load(object sender, EventArgs e) {
            await LoadDataFromDb();
            await setFormBindings();
        }

        private async Task setFormBindings() {

            this.transactionEditDtoBindingSource.DataSource = new BindingSource() { DataSource = _transaction };

            inputTransactionEmployeeId.Properties.DataSource = new BindingSource() { DataSource = (Application.OpenForms["managerForm"] as ManagerForm).employeeList };
            inputTransactionEmployeeId.Properties.ValueMember = "Id";
            inputTransactionEmployeeId.Properties.DisplayMember = "Surname";


            repTransactionLineItems.DataSource = new BindingSource() { DataSource = _itemsList };
            repTransactionLineItems.DisplayMember = "Code";
            repTransactionLineItems.ValueMember = "Id";

            


            //_transaction.TransactionLines = new List<TransactionLineEditDto>();
            grdTransactionLines.DataSource = new BindingSource() { DataSource = _transactionLines };
        }

        private async Task LoadDataFromDb() {
            _itemsList = await GetItemsAsync(sharedClient);
        }

        private void inputTransactionCustomerId_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyValue == 13) {
                var askedCustomer = (Application.OpenForms["managerForm"] as ManagerForm).customerList.Find(customer => customer.CardNumber == inputTransactionCustomerId.Text);

                if (askedCustomer != null) {
                    inputTransactionCustomerName.Text = askedCustomer.Name;
                    inputTransactionCustomerSurname.Text = askedCustomer.Surname;
                    _transaction.CustomerId = askedCustomer.Id;
                }
                else {
                    DialogResult dialogResult = MessageBox.Show("Customer not found. Would you like to create them?", "Customer Not Found", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes) {
                        NewCustomerForm newCustomerForm = new NewCustomerForm(sharedClient);
                        newCustomerForm.ShowDialog();
                    }
                }
            }
        }


        private async Task<List<ItemListDto>> GetItemsAsync(HttpClient httpClient) {
            using HttpResponseMessage response = await httpClient.GetAsync("Item");
            response.EnsureSuccessStatusCode();
            var jsonResponse = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<List<ItemListDto>>(jsonResponse);
        }



        private async void grvTransactionLines_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e) {
            int rowHandle;
            if (grvTransactionLines.IsNewItemRow(e.RowHandle)) {
                return;
            }
            else {
                rowHandle = e.RowHandle;
            }

            if (e.Column.FieldName == "ItemId")   {
                UpdateTransactionLineItemPrice(rowHandle);
            }
            else if(e.Column.FieldName == "Quantity") {
                if(decimal.Parse(grvTransactionLines.GetRowCellValue(rowHandle, "ItemPrice").ToString()) > 0){
                    UpdateTransactionLine(rowHandle);
                }
            }
        }


        private void UpdateTransactionLineItemPrice(int rowHandle) {
            int itemId = Int32.Parse(grvTransactionLines.GetRowCellValue(rowHandle, "ItemId").ToString());
            var item = _itemsList.Find(item => item.Id == itemId);

            if (item != null) {
                if (item.Type == ItemType.Fuel) {
                    if (!checkFuelItemsConstraint()) {
                        MessageBox.Show("You already have a Fuel Type Item in the transaction");
                        return;
                    }
                }
                
                grvTransactionLines.SetRowCellValue(rowHandle, "ItemPrice", Math.Round(item.Price, 2));
               
            }
            else {
                MessageBox.Show("Item Not Found");
                return;
            }
        }


        private bool checkFuelItemsConstraint() {
            if (fuelProductInTransaction) {
                return false;
            }
            else {
                fuelProductInTransaction = true;
                fuelRowIndex = grvTransactionLines.FocusedRowHandle;
                return true;
            }
        }

        private void UpdateTransactionLine(int rowHandle) {
            var asdas = grvTransactionLines.GetRowCellValue(rowHandle, "ItemPrice").ToString();
            decimal itemPrice = decimal.Parse(grvTransactionLines.GetRowCellValue(rowHandle, "ItemPrice").ToString());
            decimal lineQuantity = decimal.Parse(grvTransactionLines.GetRowCellValue(rowHandle, "Quantity").ToString());
            decimal netValue = itemPrice * lineQuantity;
            if (fuelRowIndex != null && fuelRowIndex == rowHandle && netValue > 20) {
                grvTransactionLines.SetRowCellValue(rowHandle, "DiscountPercent", 10);
            }
            else {
                grvTransactionLines.SetRowCellValue(rowHandle, "DiscountPercent", 0);
            }
            decimal lineDiscountPercentage = decimal.Parse(grvTransactionLines.GetRowCellValue(rowHandle, "DiscountPercent").ToString());
            decimal discountValue = 0;
            if (lineDiscountPercentage > 0) {
                discountValue = netValue * (lineDiscountPercentage / 100);
            }
            decimal totalValue = netValue - discountValue;

                
            grvTransactionLines.SetRowCellValue(rowHandle, "NetValue", Math.Round(netValue, 2));

            grvTransactionLines.SetRowCellValue(rowHandle, "DiscountValue", Math.Round(discountValue, 2));
            grvTransactionLines.SetRowCellValue(rowHandle, "TotalValue", Math.Round(totalValue, 2));

            grvTransactionLines.CloseEditor();

           
            UpdateTransactionTotalPrice();

        }

        private void btnAddTransactionLine_Click(object sender, EventArgs e) {
            AddLine();
        }

        private void AddLine() {
            grvTransactionLines.AddNewRow();
            grvTransactionLines.UpdateCurrentRow();
        }

        private void RemoveLine() {
            grvTransactionLines.DeleteRow(grvTransactionLines.FocusedRowHandle);
            UpdateTotalQuantity();
            UpdatePreDiscountTotalPrice();
            UpdateTransactionTotalPrice();
        }


        private void UpdateTotalQuantity() {
            totalQuantity = 0;
            foreach (var transactionLine in _transactionLines) {
                totalQuantity += transactionLine.Quantity;
            }
        }

        private void UpdateTransactionTotalPrice() {
            _transaction.TotalValue = 0;
            foreach (var transactionLine in _transactionLines) {
                _transaction.TotalValue += transactionLine.TotalValue;
            }
            _transaction.TotalValue = Math.Round(_transaction.TotalValue, 2);
            inputTransactionTotalValue.Text = _transaction.TotalValue.ToString();
        }

        private void UpdatePreDiscountTotalPrice() {
            preDiscountTotalPrice = 0;
            foreach (var transactionLine in _transactionLines) {
                preDiscountTotalPrice += transactionLine.NetValue;
            }
            preDiscountTotalPrice = Math.Round(preDiscountTotalPrice, 2);

        }

    }
}