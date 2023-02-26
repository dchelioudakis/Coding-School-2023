using FuelStation.Blazor.Shared.DTO.Item;
using FuelStation.Blazor.Shared.DTO.Transaction;
using FuelStation.Blazor.Shared.DTO.TransactionLine;
using FuelStation.Model.Enums;
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
using WindowsClient.WindowsApiCalls;

namespace WindowsClient {
    public partial class TransactionDetailsForm : Form {

        public HttpClient sharedClient;
        private TransactionEditDto _transaction;
        private List<TransactionLineEditDto> _transactionLines;
        private List<ItemListDto> _itemsList;
        private EmployeeCaller _employeeCaller = new();
        private int? _transactionId;
        public TransactionDetailsForm(HttpClient httpClient, int? transactionId) {
            InitializeComponent();
            this.sharedClient = httpClient;
            _transactionId = transactionId;
        }

        private async void TransactionDetailsForm_Load(object sender, EventArgs e) {
            await setFormBindings();
        }

        private async Task setFormBindings() {
            if (_transactionId != null) {
                using HttpResponseMessage response = await sharedClient.GetAsync($"transaction/{_transactionId}");
                response.EnsureSuccessStatusCode();
                var jsonResponse = await response.Content.ReadAsStringAsync();

                _transaction = JsonConvert.DeserializeObject<TransactionEditDto>(jsonResponse);

                this.transactionEditDtoBindingSource.DataSource = new BindingSource() { DataSource = _transaction };

                inputTransactionEmployeeId.Properties.DataSource = new BindingSource() { DataSource = await _employeeCaller.GetEmployeesAsync(sharedClient) };
                inputTransactionEmployeeId.Properties.ValueMember = "Id";
                inputTransactionEmployeeId.Properties.DisplayMember = "Surname";


                repTransactionLineItems.DataSource = new BindingSource() { DataSource = _itemsList };
                repTransactionLineItems.DisplayMember = "Code";
                repTransactionLineItems.ValueMember = "Id";

                _transactionLines = _transaction.TransactionLines;
                grdTransactionLines.DataSource = new BindingSource() { DataSource = _transactionLines };

                comboBoxPaymentMethod.Properties.Items.AddRange(typeof(PaymentMethod).GetEnumValues());

                inputTransactionCustomerCard.Text = _transaction.Customer.CardNumber;
                inputTransactionCustomerName.Text = _transaction.Customer.Name;
                inputTransactionCustomerSurname.Text = _transaction.Customer.Surname;
            }
        }
    }
}
