using FuelStation.Blazor.Shared.DTO.Customer;
using FuelStation.Blazor.Shared.DTO.Employee;
using FuelStation.Blazor.Shared.DTO.Transaction;
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
    public partial class CustomerDetailsForm : Form {

        private CustomerDetailsDto _customer;
        private int? _customerId;
        public HttpClient sharedClient;

        public CustomerDetailsForm(HttpClient sharedClient, int? customerId) {
            InitializeComponent();
            this.sharedClient = sharedClient;
            _customerId = customerId;
        }

        private async void CustomerDetailsForm_Load(object sender, EventArgs e) {
            if (_customerId != null) {
                using HttpResponseMessage response = await sharedClient.GetAsync($"customerlist/details/{_customerId}");
                response.EnsureSuccessStatusCode();
                var jsonResponse = await response.Content.ReadAsStringAsync();

                _customer = JsonConvert.DeserializeObject<CustomerDetailsDto>(jsonResponse);

                customerDetailsDtoBindingSource.DataSource = _customer;
                grdTransactions.DataSource = _customer.Transactions;

                List<EmployeeEditDto> customerTransactionsEmployees = new();
                foreach (var transaction in _customer.Transactions) {
                    customerTransactionsEmployees.Add(transaction.Employee);
                }
                repEmployees.DataSource = new BindingSource() { DataSource = customerTransactionsEmployees };
                repEmployees.DisplayMember = "Surname";
                repEmployees.ValueMember = "Id";
            }
            else { 
                MessageBox.Show("Error retrieving customer. Customer Not Found");
            }
        }
    }
}
