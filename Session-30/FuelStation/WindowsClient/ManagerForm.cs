using DevExpress.XtraPivotGrid.Data;
using DevExpress.XtraRichEdit.Import.Html;
using FuelStation.Blazor.Shared.DTO.Customer;
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
        }

        private async Task LoadDataToGrids() {
            //BindingList<CustomerListDto> customersList = new BindingList<CustomerListDto>(_customerList);
            //grdManagerCustomers.DataSource = new BindingSource() { DataSource = customersList };
            grdCustomers.DataSource = _customerList;
            grdItems.DataSource = _itemList;
            grdTransactions.DataSource = _transactionList;

            //BindingList<Customer> customers = new BindingList<Customer>(carServiceCenter.Customers);
            //grdCustomers.DataSource = new BindingSource() { DataSource = customers };

            //BindingList<Engineer> engineers = new BindingList<Engineer>(carServiceCenter.Engineers);
            //grdEngineers.DataSource = new BindingSource() { DataSource = engineers };

            //repManagers.DataSource = new BindingSource() { DataSource = managers };
            //repManagers.DisplayMember = "Name";
            //repManagers.ValueMember = "ID";
            //repManagersView.Assign(grdManagers.MainView, false);

            //BindingList<ServiceTask> serviceTasks = new BindingList<ServiceTask>(carServiceCenter.ServiceTasks);
            //grdServiceTasks.DataSource = new BindingSource() { DataSource = serviceTasks };

            //BindingList<LibCarService.Transaction> transactions = new BindingList<LibCarService.Transaction>(carServiceCenter.Transactions);
            //grdTransactions.DataSource = new BindingSource() { DataSource = transactions };

            //BindingList<Car> cars = new BindingList<Car>(carServiceCenter.Cars);
            //repCars.DataSource = new BindingSource() { DataSource = cars };
            //repCars.DisplayMember = "Model";
            //repCars.ValueMember = "ID";


            //repCustomers.DataSource = new BindingSource() { DataSource = customers };
            //repCustomers.DisplayMember = "Surname";
            //repCustomers.ValueMember = "ID";



            //repManagers2.DataSource = new BindingSource() { DataSource = managers };
            //repManagers2.DisplayMember = "Surname";
            //repManagers2.ValueMember = "ID";
            //gridView2.Assign(grdManagers.MainView, false);


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
    }
}
