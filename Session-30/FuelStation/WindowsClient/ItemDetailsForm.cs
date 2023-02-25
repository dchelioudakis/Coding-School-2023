using FuelStation.Blazor.Shared.DTO.Item;
using FuelStation.Model.Enums;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsClient {
    public partial class ItemDetailsForm : Form {
        private ItemEditDto _item;
        private int? _itemId;
        public HttpClient sharedClient;
        public ItemDetailsForm(HttpClient sharedClient, int? itemId) {
            InitializeComponent();
            this.sharedClient = sharedClient;
            _itemId = itemId;
        }
        private async void ItemDetailsForm_Load(object sender, EventArgs e) {
            if (_itemId != null) {
                using HttpResponseMessage response = await sharedClient.GetAsync($"item/{_itemId}");
                response.EnsureSuccessStatusCode();
                var jsonResponse = await response.Content.ReadAsStringAsync();

                _item = JsonConvert.DeserializeObject<ItemEditDto>(jsonResponse);
            }
            else {
                _item = new ItemEditDto();
            }

            this.itemEditDtoBindingSource.DataSource = new BindingSource() { DataSource = _item };
            comboBoxItemType.Properties.Items.AddRange(typeof(ItemType).GetEnumValues());
        }

        private void btnItemDetailsClose_Click(object sender, EventArgs e) {
            this.Close();
        }

    }
}
