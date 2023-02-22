using DevExpress.XtraPivotGrid.Data;
using DevExpress.XtraRichEdit.Import.Html;
using FuelStation.Blazor.Shared.DTO.Customer;
using FuelStation.Blazor.Shared.DTO.Employee;
using FuelStation.Blazor.Shared.DTO.Item;
using FuelStation.Blazor.Shared.DTO.Transaction;
using FuelStation.EF.Repositories;
using FuelStation.Model;
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
        private List<CustomerListDto> _customerList;
        private List<ItemListDto> _itemList;
        private List<EmployeeListDto> _employeeList;
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
            _customerList = await GetCustomersAsync(sharedClient);
            _itemList = await GetItemsAsync(sharedClient);
            _transactionList = await GetTransactionsAsync(sharedClient);
            _employeeList = await GetEmployeesAsync(sharedClient);
        }

        private async Task LoadDataToGrids() {
            grdCustomers.DataSource = _customerList;
            grdItems.DataSource = _itemList;
            grdTransactions.DataSource = _transactionList;


            repEmployees.DataSource = new BindingSource() { DataSource = _employeeList };
            repEmployees.DisplayMember = "Surname";
            repEmployees.ValueMember = "Id";

            repCustomers.DataSource = new BindingSource() { DataSource = _customerList };
            repCustomers.DisplayMember = "CardNumber";
            repCustomers.ValueMember = "Id";
           
        }

        private void btnCustomerCreate_Click(object sender, EventArgs e) {
            NewCustomerForm newCustomerForm = new NewCustomerForm(sharedClient);
            newCustomerForm.ShowDialog();
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

        private void btnCreateTransaction_Click(object sender, EventArgs e) {
            NewTransactionForm newTransactionForm = new NewTransactionForm(sharedClient);
            newTransactionForm.ShowDialog();
        }
    }
}
