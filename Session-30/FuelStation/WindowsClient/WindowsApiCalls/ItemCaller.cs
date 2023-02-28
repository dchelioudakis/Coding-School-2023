using FuelStation.Blazor.Shared.DTO.Item;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace WindowsClient.WindowsApiCalls {
    public class ItemCaller {
        public ItemCaller() {

        }

        public async Task<List<ItemListDto>> GetItemsAsync(HttpClient httpClient) {
            using HttpResponseMessage response = await httpClient.GetAsync("Item");
            response.EnsureSuccessStatusCode();
            var jsonResponse = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<List<ItemListDto>>(jsonResponse);
        }

        public async Task PostAsJsonAsync(HttpClient httpClient, ItemEditDto item) {
            using HttpResponseMessage response = await httpClient.PostAsJsonAsync("Item", item);
            
            //response.EnsureSuccessStatusCode();
            
        }

        public async Task PutAsJsonAsync(HttpClient httpClient, ItemEditDto item) {
            using HttpResponseMessage response = await httpClient.PutAsJsonAsync("Item", item);
            response.EnsureSuccessStatusCode();
        }
    }
}
