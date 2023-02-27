using FuelStation.Blazor.Shared.DTO.Customer;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace WindowsClient.WindowsApiCalls {
    public class CustomerCaller {

        public CustomerCaller() {

        }

        public async Task<List<CustomerListDto>> GetCustomersAsync(HttpClient httpClient) {
            using HttpResponseMessage response = await httpClient.GetAsync("Customer");
            response.EnsureSuccessStatusCode();
            var jsonResponse = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<List<CustomerListDto>>(jsonResponse);
        }

        public async Task PostAsJsonAsync(HttpClient httpClient, CustomerEditDto customer) {
            using HttpResponseMessage response = await httpClient.PostAsJsonAsync("Customer", customer);
            response.EnsureSuccessStatusCode();
        }

        public async Task PutAsJsonAsync(HttpClient httpClient, CustomerEditDto customer) {
            using HttpResponseMessage response = await httpClient.PutAsJsonAsync("Customer", customer);
            response.EnsureSuccessStatusCode();
        }
    }
}
