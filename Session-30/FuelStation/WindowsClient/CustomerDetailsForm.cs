using FuelStation.Blazor.Shared.DTO.Customer;
using FuelStation.Blazor.Shared.DTO.Employee;
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

namespace WindowsClient {
    public partial class CustomerDetailsForm : Form {

        private CustomerDetailsDto _customer;
        public HttpClient sharedClient;

        public CustomerDetailsForm(HttpClient sharedClient, CustomerDetailsDto customer) {
            InitializeComponent();
            this.sharedClient = sharedClient;
            _customer = customer;
        }

        private void CustomerDetailsForm_Load(object sender, EventArgs e) {
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
    }
}
