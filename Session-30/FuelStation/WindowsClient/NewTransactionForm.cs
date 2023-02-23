using DevExpress.XtraEditors;
using FuelStation.Blazor.Shared.DTO.Customer;
using FuelStation.Blazor.Shared.DTO.Item;
using FuelStation.Blazor.Shared.DTO.Transaction;
using FuelStation.Blazor.Shared.DTO.TransactionLine;
using FuelStation.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsClient {
    public partial class NewTransactionForm : Form {

        public HttpClient sharedClient;
        private TransactionEditDto _newTransaction = new();
        private List<TransactionLineEditDto> _transactionLines = new();
        private List<ItemListDto> _itemsList = new();

        
        public NewTransactionForm(HttpClient httpClient) {
            InitializeComponent();
            this.sharedClient = httpClient;
            transactionEditDtoBindingSource.DataSource = new BindingSource() { DataSource = _newTransaction };
        }

        private async void NewTransactionForm_Load(object sender, EventArgs e) {
            await setFormBindings();
            await LoadDataFromDb();
        }

        private async Task setFormBindings() {
            inputTransactionEmployeeId.Properties.DataSource = new BindingSource() { DataSource = (Application.OpenForms["managerForm"] as ManagerForm).employeeList };
            inputTransactionEmployeeId.Properties.ValueMember = "Id";
            inputTransactionEmployeeId.Properties.DisplayMember = "Surname";

            //_transactionLines.Add(new TransactionLineEditDto());
            //_transactionLines.Add(new TransactionLineEditDto());

            BindingList<TransactionLineEditDto> transactionLines = new BindingList<TransactionLineEditDto>(_transactionLines);


            //_newTransaction.TransactionLines = new List<TransactionLineEditDto>();
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

                    //inputTransactionCustomerId.EditValue = askedCustomer.Id;
                    //inputTransactionCustomerId.Text = askedCustomer.CardNumber;
                    _newTransaction.CustomerId = askedCustomer.Id;
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

        private void btnAddTransactionLine_Click(object sender, EventArgs e) {
            grvTransactionLines.AddNewRow();
        }

        private async void grvTransactionLines_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e) {
            int rowHandle = grvTransactionLines.DataRowCount - 1;

            string itemCode = grvTransactionLines.GetRowCellValue(rowHandle, "ItemId").ToString();
            var item = await getTransactionLineItem(itemCode);
            if (item != null) {
                string lineQuantityStr = grvTransactionLines.GetRowCellValue(rowHandle, "Quantity").ToString();
                decimal lineQuantity = decimal.Parse(lineQuantityStr);
                grvTransactionLines.SetRowCellValue(rowHandle, "ItemPrice", item.Price);
                grvTransactionLines.SetRowCellValue(rowHandle, "NetValue", item.Price * lineQuantity);
            }
            else {
                MessageBox.Show("Item Not Found");
            }
        }

        private async Task<ItemListDto?> getTransactionLineItem(string itemCode) {
            return _itemsList.Find(item => item.Code == itemCode);
        }

        private async Task<List<ItemListDto>> GetItemsAsync(HttpClient httpClient) {
            using HttpResponseMessage response = await httpClient.GetAsync("Item");
            response.EnsureSuccessStatusCode();
            var jsonResponse = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<List<ItemListDto>>(jsonResponse);
        }
    }
}
