using FuelStation.Blazor.Shared.DTO.Customer;
using FuelStation.Blazor.Shared.DTO.Employee;
using Newtonsoft.Json;
using System.Net.Http;
using WindowsClient.WindowsApiCalls;
using WindowsClient.ParentFormReload;

namespace WindowsClient {
    public partial class CustomerEditForm : Form {

        private CustomerEditDto _customer;
        private int? _customerId;
        public HttpClient sharedClient;
        private CustomerCaller _customerCaller = new();
        private ParentFormReloader _parentFormReloader = new();
        private EmployeeListDto _sessionEmployee;
        
        public CustomerEditForm(HttpClient sharedClient, int? customerId, EmployeeListDto sessionEmployee) {
            InitializeComponent();
            this.sharedClient = sharedClient;
            _customerId = customerId;
            _sessionEmployee = sessionEmployee;
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
                await _customerCaller.PostAsJsonAsync(sharedClient, _customer);
            }
            else {
                await _customerCaller.PutAsJsonAsync(sharedClient, _customer); 
            }
            await _parentFormReloader.ReloadParentForm(_sessionEmployee.Type);
            this.Close();
        }

    }
}
