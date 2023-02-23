using DevExpress.XtraEditors;
using FuelStation.Blazor.Shared.DTO.Customer;
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
    public partial class NewTransactionForm : Form {

        public HttpClient sharedClient;
        private TransactionEditDto _newTransaction = new();

        
        public NewTransactionForm(HttpClient httpClient) {
            InitializeComponent();
            this.sharedClient = httpClient;
            transactionEditDtoBindingSource.DataSource = new BindingSource() { DataSource = _newTransaction };
        }

        private async void NewTransactionForm_Load(object sender, EventArgs e) {
            await setFormBindings();
        }

        private async Task setFormBindings() {
            inputTransactionEmployeeId.Properties.DataSource = new BindingSource() { DataSource = (Application.OpenForms["managerForm"] as ManagerForm).employeeList };
            inputTransactionEmployeeId.Properties.ValueMember = "Id";
            inputTransactionEmployeeId.Properties.DisplayMember = "Surname";
        }

        private void inputTransactionCustomerId_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyValue == 13) {
                var askedCustomer = (Application.OpenForms["managerForm"] as ManagerForm).customerList.Find(customer => customer.CardNumber == inputTransactionCustomerId.Text);

                if (askedCustomer != null) {
                    inputTransactionCustomerName.Text = askedCustomer.Name;
                    inputTransactionCustomerSurname.Text = askedCustomer.Surname;
                }
            }
        }
    }
}
