using FuelStation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace WindowsClient.WindowsFormsOperations {
    public class CustomerFormsHandler {
        public CustomerFormsHandler() {

        }

        public async Task Create(HttpClient httpClient) {
            CustomerEditForm newCustomerForm = new CustomerEditForm(httpClient, null);
            newCustomerForm.Text = "Create Customer";
            newCustomerForm.ShowDialog();
        }

        public async Task Edit(HttpClient httpClient, int? customerId) {
            CustomerEditForm editCustomerForm = new CustomerEditForm(httpClient, customerId);
            editCustomerForm.Text = "Edit Customer";
            editCustomerForm.ShowDialog();
        }

        public async Task Details(HttpClient httpClient, int? customerId) {
            CustomerDetailsForm customerDetailsForm = new CustomerDetailsForm(httpClient, customerId);
            customerDetailsForm.ShowDialog();
        }

        
    }
}
