using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace WindowsClient.WindowsFormsOperations {
    public class ItemFormsHandler {
        public ItemFormsHandler() {

        }

        public async Task Create(HttpClient httpClient) {
            ItemEditForm newItemForm = new ItemEditForm(httpClient, null);
            newItemForm.Text = "Create Item";
            newItemForm.ShowDialog();
        }

        public async Task Edit(HttpClient httpClient, int itemId) {
            ItemEditForm editItemForm = new ItemEditForm(httpClient, itemId);
            editItemForm.Text = "Edit Item";
            editItemForm.ShowDialog();
        }

        public async Task Details(HttpClient httpClient, int itemId) {
            ItemDetailsForm itemDetailsForm = new ItemDetailsForm(httpClient, itemId);
            itemDetailsForm.ShowDialog();
        }
    }
}
