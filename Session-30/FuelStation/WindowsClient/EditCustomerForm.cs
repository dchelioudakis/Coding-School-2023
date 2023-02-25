using DevExpress.XtraRichEdit.Import.Html;
using FuelStation.Blazor.Shared.DTO.Customer;
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
    public partial class EditCustomerForm : Form {

        private CustomerEditDto _customer;
        public HttpClient sharedClient;
        
        public EditCustomerForm(HttpClient sharedClient, CustomerEditDto? customer) {
            InitializeComponent();
            this.sharedClient = sharedClient;
            if(customer != null ) {
                _customer = customer;
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
            //var todo = await response.Content.ReadFromJsonAsync<CustomerEditDto>();
        }

        private async Task PutAsJsonAsync(HttpClient httpClient, CustomerEditDto customer) {
            using HttpResponseMessage response = await httpClient.PutAsJsonAsync("Customer", customer);

            response.EnsureSuccessStatusCode();
            if (Application.OpenForms["managerForm"] != null) {
                (Application.OpenForms["managerForm"] as ManagerForm).FormInit();
            }
            //var todo = await response.Content.ReadFromJsonAsync<CustomerEditDto>();
        }
    }
}
