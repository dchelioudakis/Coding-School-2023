using FuelStation.Blazor.Shared.DTO.Customer;
using FuelStation.Blazor.Shared.DTO.Employee;
using FuelStation.Blazor.Shared.DTO.Item;
using FuelStation.Blazor.Shared.DTO.Transaction;
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
using WindowsClient.WindowsApiCalls;

namespace WindowsClient {
    public partial class CashierForm : Form {

        public List<CustomerListDto> customerList;
        private List<ItemListDto> _itemList;
        public List<EmployeeListDto> employeeList;
        private List<TransactionListDto> _transactionList;
        public HttpClient sharedClient;
        public CashierForm(HttpClient sharedClient) {
            InitializeComponent();
            this.sharedClient = sharedClient;
        }

        private void btnCustomerCreate_Click(object sender, EventArgs e) {
            CustomerEditForm newCustomerForm = new CustomerEditForm(sharedClient, null);
            newCustomerForm.Text = "Create Customer";
            newCustomerForm.ShowDialog();
        }

        private async void CashierForm_Load(object sender, EventArgs e) {
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
            grdTransactions.DataSource = _transactionList;


            repEmployees.DataSource = new BindingSource() { DataSource = employeeList };
            repEmployees.DisplayMember = "Surname";
            repEmployees.ValueMember = "Id";

            repCustomers.DataSource = new BindingSource() { DataSource = customerList };
            repCustomers.DisplayMember = "CardNumber";
            repCustomers.ValueMember = "Id";

        }

        private void btnCustomerEdit_Click(object sender, EventArgs e) {

        }

        private void btnCustomerDetails_Click(object sender, EventArgs e) {

        }

        private void btnCustomerDelete_Click(object sender, EventArgs e) {

        }

        private void btnTransactionCreate_Click(object sender, EventArgs e) {

        }

        private void btnTransactionEdit_Click(object sender, EventArgs e) {

        }

        private void btnTransactionDetails_Click(object sender, EventArgs e) {

        }

        private void btnTransactionDelete_Click(object sender, EventArgs e) {

        }

        
    }
}
