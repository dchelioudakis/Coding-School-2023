using DevExpress.XtraPivotGrid.Data;
using DevExpress.XtraRichEdit.Import.Html;
using FuelStation.Blazor.Shared.DTO.Customer;
using FuelStation.Blazor.Shared.DTO.Employee;
using FuelStation.Blazor.Shared.DTO.Item;
using FuelStation.Blazor.Shared.DTO.Transaction;
using FuelStation.EF.Repositories;
using FuelStation.Model;
using FuelStation.Model.Enums;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Printing;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsClient.WindowsApiCalls;
using WindowsClient.WindowsFormsOperations;

namespace WindowsClient {
    public partial class ManagerForm : Form {
        public List<CustomerListDto> customerList;
        private List<ItemListDto> _itemList;
        public List<EmployeeListDto> employeeList;
        private List<TransactionListDto> _transactionList;
        public HttpClient sharedClient;
        private CustomerFormsHandler _customerFormsHandler = new();
        private ItemFormsHandler _itemFormsHandler = new(); 
        private TransactionFormsHandler _transactionFormsHandler = new();

        public ManagerForm(HttpClient sharedClient) {
            InitializeComponent();
            this.sharedClient = sharedClient;
        }

        private async void ManagerForm_Load(object sender, EventArgs e) {
            await FormInit();
        }

        
        public async Task FormInit() {
            await LoadDataFromDb();
            await LoadDataToGrids();
        }

        private async Task LoadDataFromDb() {
            CustomerCaller customerCaller = new CustomerCaller();
            customerList = await customerCaller.GetCustomersAsync(sharedClient);

            ItemCaller itemCaller = new ItemCaller();
            _itemList = await itemCaller.GetItemsAsync(sharedClient);

            TransactionCaller transactionCaller = new TransactionCaller();
            _transactionList = await transactionCaller.GetTransactionsAsync(sharedClient);

            EmployeeCaller employeeCaller = new EmployeeCaller();
            employeeList = await employeeCaller.GetEmployeesAsync(sharedClient);
        }

        private async Task LoadDataToGrids() {
            grdCustomers.DataSource = customerList;
            grdItems.DataSource = _itemList;
            grdTransactions.DataSource = _transactionList;


            repEmployees.DataSource = new BindingSource() { DataSource = employeeList };
            repEmployees.DisplayMember = "Surname";
            repEmployees.ValueMember = "Id";

            repCustomers.DataSource = new BindingSource() { DataSource = customerList };
            repCustomers.DisplayMember = "CardNumber";
            repCustomers.ValueMember = "Id";
           
        }

        private async void btnCustomerCreate_Click(object sender, EventArgs e) {
            await _customerFormsHandler.Create(sharedClient);
        }

        private async void btnCustomerEdit_Click(object sender, EventArgs e) {
            int customerId = Int32.Parse(grvManagerCustomers.GetRowCellValue(grvManagerCustomers.FocusedRowHandle, "Id").ToString());
            await _customerFormsHandler.Edit(sharedClient, customerId);
        }


        private async void btnCustomerDetails_Click(object sender, EventArgs e) {
            int customerId = Int32.Parse(grvManagerCustomers.GetRowCellValue(grvManagerCustomers.FocusedRowHandle, "Id").ToString());
            await _customerFormsHandler.Details(sharedClient, customerId);
        }

        private async void btnCustomerDelete_Click(object sender, EventArgs e) {
            int rowHandle = grvManagerCustomers.FocusedRowHandle;
            int customerId = Int32.Parse(grvManagerCustomers.GetRowCellValue(rowHandle, "Id").ToString());
            DialogResult dialogResult = MessageBox.Show("Customer Delete. Are your sure?", "Customer Delete", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes) {
                using HttpResponseMessage response = await sharedClient.DeleteAsync($"customer/{customerId}");
                response.EnsureSuccessStatusCode();
                await FormInit();
            }
            else {
                return;
            }
        }

        private async void btnItemCreate_Click(object sender, EventArgs e) {
            await _itemFormsHandler.Create(sharedClient);
        }

        private async void btnItemEdit_Click(object sender, EventArgs e) {
            int itemId = Int32.Parse(grvItems.GetRowCellValue(grvItems.FocusedRowHandle, "Id").ToString());
            await _itemFormsHandler.Edit(sharedClient, itemId);
        }
        private async void btnItemDetails_Click(object sender, EventArgs e) {
            int itemId = Int32.Parse(grvItems.GetRowCellValue(grvItems.FocusedRowHandle, "Id").ToString());
            await _itemFormsHandler.Details(sharedClient, itemId);
        }

        private async void btnItemDelete_Click(object sender, EventArgs e) {
            int rowHandle = grvItems.FocusedRowHandle;
            int itemId = Int32.Parse(grvItems.GetRowCellValue(rowHandle, "Id").ToString());
            DialogResult dialogResult = MessageBox.Show("Item Delete. Are your sure?", "Item Delete", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes) {
                using HttpResponseMessage response = await sharedClient.DeleteAsync($"item/{itemId}");
                response.EnsureSuccessStatusCode();
                await FormInit();
            }
            else {
                return;
            }
        }

        private async void btnTransactionCreate_Click(object sender, EventArgs e) {
            await _transactionFormsHandler.Create(sharedClient);
        }

        private async void btnTransactionEdit_Click(object sender, EventArgs e) {
            int transactionId = Int32.Parse(grvTransactions.GetRowCellValue(grvTransactions.FocusedRowHandle, "Id").ToString());
            await _transactionFormsHandler.Edit(sharedClient, transactionId);
        }

        private async void btnTransactionDetails_Click(object sender, EventArgs e) {
            int transactionId = Int32.Parse(grvTransactions.GetRowCellValue(grvTransactions.FocusedRowHandle, "Id").ToString());
            await _transactionFormsHandler.Details(sharedClient, transactionId);
        }

        private async void btnTransactionDelete_Click(object sender, EventArgs e) {
            int rowHandle = grvTransactions.FocusedRowHandle;
            int transactionId = Int32.Parse(grvTransactions.GetRowCellValue(rowHandle, "Id").ToString());
            DialogResult dialogResult = MessageBox.Show("Transaction Delete. This action will delete all the dependent transaction lines. Are your sure?", "Transaction Delete", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes) {
                using HttpResponseMessage response = await sharedClient.DeleteAsync($"transaction/{transactionId}");
                response.EnsureSuccessStatusCode();
                await FormInit();
            }
            else {
                return;
            }
        }
    }
}
