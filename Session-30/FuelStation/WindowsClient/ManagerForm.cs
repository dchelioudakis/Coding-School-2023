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
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsClient {
    public partial class ManagerForm : Form {
        public List<CustomerListDto> customerList;
        private List<ItemListDto> _itemList;
        public List<EmployeeListDto> employeeList;
        private List<TransactionListDto> _transactionList;
        public HttpClient sharedClient;

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
            customerList = await GetCustomersAsync(sharedClient);
            _itemList = await GetItemsAsync(sharedClient);
            _transactionList = await GetTransactionsAsync(sharedClient);
            employeeList = await GetEmployeesAsync(sharedClient);
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

        

        private async Task<List<CustomerListDto>> GetCustomersAsync(HttpClient httpClient) {
            using HttpResponseMessage response = await httpClient.GetAsync("Customer");
            response.EnsureSuccessStatusCode();
            var jsonResponse = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<List<CustomerListDto>>(jsonResponse);
        }

        private async Task<List<ItemListDto>> GetItemsAsync(HttpClient httpClient) {
            using HttpResponseMessage response = await httpClient.GetAsync("Item");
            response.EnsureSuccessStatusCode();
            var jsonResponse = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<List<ItemListDto>>(jsonResponse);
        }

        private async Task<List<TransactionListDto>> GetTransactionsAsync(HttpClient httpClient) {
            using HttpResponseMessage response = await httpClient.GetAsync("Transaction");
            response.EnsureSuccessStatusCode();
            var jsonResponse = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<List<TransactionListDto>>(jsonResponse);
        }

        private async Task<List<EmployeeListDto>> GetEmployeesAsync(HttpClient httpClient) {
            using HttpResponseMessage response = await httpClient.GetAsync("Employee");
            response.EnsureSuccessStatusCode();
            var jsonResponse = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<List<EmployeeListDto>>(jsonResponse);
        }

        private void btnCustomerCreate_Click(object sender, EventArgs e) {
            CustomerEditForm newCustomerForm = new CustomerEditForm(sharedClient, null);
            newCustomerForm.Text = "Create Customer";
            newCustomerForm.ShowDialog();
        }

        private void btnCustomerEdit_Click(object sender, EventArgs e) {
            int rowHandle = grvManagerCustomers.FocusedRowHandle;
            int customerId = Int32.Parse(grvManagerCustomers.GetRowCellValue(rowHandle, "Id").ToString());
            
            CustomerEditForm editCustomerForm = new CustomerEditForm(sharedClient, customerId);
            editCustomerForm.Text = "Edit Customer";
            editCustomerForm.ShowDialog();
        }


        private void btnTransactionCreate_Click(object sender, EventArgs e) {
            TransactionCreateForm newTransactionForm = new TransactionCreateForm(sharedClient);
            newTransactionForm.ShowDialog();
        }

        private async void btnCustomerDetails_Click(object sender, EventArgs e) {
            int rowHandle = grvManagerCustomers.FocusedRowHandle;
            int customerId = Int32.Parse(grvManagerCustomers.GetRowCellValue(rowHandle, "Id").ToString());
            CustomerDetailsForm customerDetailsForm = new CustomerDetailsForm(sharedClient, customerId);
            customerDetailsForm.ShowDialog();
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

        private void btnItemCreate_Click(object sender, EventArgs e) {
            ItemEditForm newItemForm = new ItemEditForm(sharedClient, null);
            newItemForm.Text = "Create Item";
            newItemForm.ShowDialog();
        }

        private async void btnItemEdit_Click(object sender, EventArgs e) {
            int rowHandle = grvItems.FocusedRowHandle;
            int itemId = Int32.Parse(grvItems.GetRowCellValue(rowHandle, "Id").ToString());

            ItemEditForm editItemForm = new ItemEditForm(sharedClient, itemId);
            editItemForm.Text = "Edit Item";
            editItemForm.ShowDialog();
        }
        private async void btnItemDetails_Click(object sender, EventArgs e) {
            int rowHandle = grvItems.FocusedRowHandle;
            int itemId = Int32.Parse(grvItems.GetRowCellValue(rowHandle, "Id").ToString());

            ItemDetailsForm itemDetailsForm = new ItemDetailsForm(sharedClient, itemId);
            itemDetailsForm.ShowDialog();
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
    }
}
