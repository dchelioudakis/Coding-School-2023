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
    public partial class NewCustomerForm : Form {

        private CustomerEditDto _newCustomer = new();
        public HttpClient sharedClient;
        
        public NewCustomerForm(HttpClient sharedClient) {
            InitializeComponent();
            this.sharedClient = sharedClient;
            this.customerEditDtoBindingSource.DataSource = new BindingSource() { DataSource = _newCustomer };
        }

        private void btnCancelNewCustomer_Click(object sender, EventArgs e) {
            this.Close();
        }

        private async void btnNewCustomerSave_Click(object sender, EventArgs e) {
            //var newCustomer = JsonConvert.SerializeObject(_newCustomer);
            await PostAsJsonAsync(sharedClient, _newCustomer);
            this.Close();
        }

        static async Task PostAsJsonAsync(HttpClient httpClient, CustomerEditDto customer) {
            using HttpResponseMessage response = await httpClient.PostAsJsonAsync(
                "Customer",
                customer);

            response.EnsureSuccessStatusCode();
                

            //var todo = await response.Content.ReadFromJsonAsync<CustomerEditDto>();
            //WriteLine($"{todo}\n");

            // Expected output:
            //   POST https://jsonplaceholder.typicode.com/todos HTTP/1.1
            //   Todo { UserId = 9, Id = 201, Title = Show extensions, Completed = False }
        }
    }
}
