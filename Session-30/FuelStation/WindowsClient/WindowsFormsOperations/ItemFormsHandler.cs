using FuelStation.Blazor.Shared.DTO.Employee;
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

        public async Task Create(HttpClient httpClient, EmployeeListDto sessionEmployee) {
            ItemEditForm newItemForm = new ItemEditForm(httpClient, null, sessionEmployee);
            newItemForm.Text = "Create Item";
            newItemForm.ShowDialog();
        }

        public async Task Edit(HttpClient httpClient, int itemId, EmployeeListDto sessionEmployee) {
            ItemEditForm editItemForm = new ItemEditForm(httpClient, itemId, sessionEmployee);
            editItemForm.Text = "Edit Item";
            editItemForm.ShowDialog();
        }

        public async Task Details(HttpClient httpClient, int itemId) {
            ItemDetailsForm itemDetailsForm = new ItemDetailsForm(httpClient, itemId);
            itemDetailsForm.ShowDialog();
        }
    }
}
