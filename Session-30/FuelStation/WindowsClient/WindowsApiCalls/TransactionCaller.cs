using FuelStation.Blazor.Shared.DTO.Transaction;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace WindowsClient.WindowsApiCalls {
    public class TransactionCaller {
        public TransactionCaller() {

        }

        public async Task<List<TransactionListDto>> GetTransactionsAsync(HttpClient httpClient) {
            using HttpResponseMessage response = await httpClient.GetAsync("Transaction");
            response.EnsureSuccessStatusCode();
            var jsonResponse = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<List<TransactionListDto>>(jsonResponse);
        }

        public async Task PostAsJsonAsync(HttpClient httpClient, TransactionCreateDto transaction) {
            using HttpResponseMessage response = await httpClient.PostAsJsonAsync("Transaction", transaction);
            response.EnsureSuccessStatusCode();
        }
    }
}
