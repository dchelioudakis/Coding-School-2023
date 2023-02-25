using DevExpress.XtraRichEdit.Model;
using FuelStation.Blazor.Shared.DTO.Customer;
using FuelStation.Blazor.Shared.DTO.Item;
using FuelStation.Model;
using FuelStation.Model.Enums;
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
    public partial class EditItemForm : Form {
        private ItemEditDto _item;
        private int? _itemId;
        public HttpClient sharedClient;

        public EditItemForm(HttpClient sharedClient, int? itemId) {
            InitializeComponent();
            this.sharedClient = sharedClient;
            _itemId = itemId;
        }

        private async void EditItemForm_Load(object sender, EventArgs e) {
            if (_itemId != null) {
                using HttpResponseMessage response = await sharedClient.GetAsync($"itemlist/{_itemId}");
                response.EnsureSuccessStatusCode();
                var jsonResponse = await response.Content.ReadAsStringAsync();

                _item = JsonConvert.DeserializeObject<ItemEditDto>(jsonResponse);
            }
            else {
                _item = new ItemEditDto();
            }
            
            this.itemEditDtoBindingSource.DataSource = new BindingSource() { DataSource = _item };
            comboBoxItemType.Properties.Items.AddRange(typeof(ItemType).GetEnumValues());
            //lookUpItemType.Properties.DataSource = new BindingSource() { DataSource = Enum.GetValues<ItemType>() };
            //var asda = Enum.GetValues<ItemType>();
            //lookUpItemType.Properties.ValueMember = "ItemType";
            //lookUpItemType.Properties.DisplayMember = "ItemType.Value__";
        }

        private async void btnEditItemSave_Click(object sender, EventArgs e) {
            if (_item.Id == 0) {
                await PostAsJsonAsync(sharedClient, _item);
            }
            else {
                await PutAsJsonAsync(sharedClient, _item);
            }
            this.Close();
        }

        private void btnEditItemCancel_Click(object sender, EventArgs e) {
            this.Close();
        }

        private async Task PostAsJsonAsync(HttpClient httpClient, ItemEditDto item) {
            using HttpResponseMessage response = await httpClient.PostAsJsonAsync("Item", item);

            response.EnsureSuccessStatusCode();
            if (Application.OpenForms["managerForm"] != null) {
                (Application.OpenForms["managerForm"] as ManagerForm).FormInit();
            }
            //var todo = await response.Content.ReadFromJsonAsync<CustomerEditDto>();
        }

        private async Task PutAsJsonAsync(HttpClient httpClient, ItemEditDto item) {
            using HttpResponseMessage response = await httpClient.PutAsJsonAsync("Item", item);

            response.EnsureSuccessStatusCode();
            if (Application.OpenForms["managerForm"] != null) {
                (Application.OpenForms["managerForm"] as ManagerForm).FormInit();
            }
            //var todo = await response.Content.ReadFromJsonAsync<CustomerEditDto>();
        }
    }
}
