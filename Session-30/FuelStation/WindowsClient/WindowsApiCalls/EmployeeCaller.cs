using FuelStation.Blazor.Shared.DTO.Employee;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace WindowsClient.WindowsApiCalls {
    public class EmployeeCaller {
        public EmployeeCaller() {

        }

        public async Task<List<EmployeeListDto>> GetEmployeesAsync(HttpClient httpClient) {
            using HttpResponseMessage response = await httpClient.GetAsync("Employee");
            response.EnsureSuccessStatusCode();
            var jsonResponse = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<List<EmployeeListDto>>(jsonResponse);
        }
    }
}
