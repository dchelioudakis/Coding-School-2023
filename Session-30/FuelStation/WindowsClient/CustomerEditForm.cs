using DevExpress.XtraRichEdit.Import.Html;
using DevExpress.XtraScheduler.Outlook.Interop;
using FuelStation.Blazor.Shared.DTO.Customer;
using FuelStation.Blazor.Shared.DTO.Item;
using FuelStation.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsClient {
    public partial class CustomerEditForm : Form {

        private CustomerEditDto _customer;
        private int? _customerId;
        public HttpClient sharedClient;
        
        public CustomerEditForm(HttpClient sharedClient, int? customerId) {
            InitializeComponent();
            this.sharedClient = sharedClient;
            _customerId = customerId;
        }

        private async void EditCustomerForm_Load(object sender, EventArgs e) {
            if (_customerId != null) {
                using HttpResponseMessage response = await sharedClient.GetAsync($"customer/{_customerId}");
                response.EnsureSuccessStatusCode();
                var jsonResponse = await response.Content.ReadAsStringAsync();

                _customer = JsonConvert.DeserializeObject<CustomerEditDto>(jsonResponse);
            }
            else {
                _customer = new CustomerEditDto();
            }

            this.customerEditDtoBindingSource.DataSource = new BindingSource() { DataSource = _customer };
        }

        private void btnCancelNewCustomer_Click(object sender, EventArgs e) {
            this.Close();
        }

        private async void btnNewCustomerSave_Click(object sender, EventArgs e) {
            if(_customer.Id == 0) {
                await PostAsJsonAsync(sharedClient, _customer);
            }
            else {
                await PutAsJsonAsync(sharedClient, _customer); 
            }
            this.Close();
        }

        private async Task PostAsJsonAsync(HttpClient httpClient, CustomerEditDto customer) {
            using HttpResponseMessage response = await httpClient.PostAsJsonAsync("Customer", customer);
            response.EnsureSuccessStatusCode();
            if (Application.OpenForms["managerForm"] != null) {
                (Application.OpenForms["managerForm"] as ManagerForm).FormInit();
            }
        }

        private async Task PutAsJsonAsync(HttpClient httpClient, CustomerEditDto customer) {
            using HttpResponseMessage response = await httpClient.PutAsJsonAsync("Customer", customer);
            response.EnsureSuccessStatusCode();
            if (Application.OpenForms["managerForm"] != null) {
                (Application.OpenForms["managerForm"] as ManagerForm).FormInit();
            }
        }
    }
}
