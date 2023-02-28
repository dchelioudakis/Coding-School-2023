using FuelStation.Blazor.Shared.DTO.Employee;
using FuelStation.Blazor.Shared.DTO.Item;
using FuelStation.Model.Enums;
using Newtonsoft.Json;
using System.Net.Http;
using System.Net.Http.Json;
using WindowsClient.ParentFormReload;
using WindowsClient.WindowsApiCalls;

namespace WindowsClient {
    public partial class ItemEditForm : Form {
        private ItemEditDto _item;
        private int? _itemId;
        public HttpClient sharedClient;
        private ItemCaller _itemCaller = new();
        private ParentFormReloader _parentFormReloader = new();
        private EmployeeListDto _sessionEmployee;

        public ItemEditForm(HttpClient sharedClient, int? itemId, EmployeeListDto sessionEmployee) {
            InitializeComponent();
            this.sharedClient = sharedClient;
            _itemId = itemId;
            _sessionEmployee = sessionEmployee;
        }

        private async void EditItemForm_Load(object sender, EventArgs e) {
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

        private async void btnEditItemSave_Click(object sender, EventArgs e) {
            try {
                if (_item.Id == 0) {
                    await _itemCaller.PostAsJsonAsync(sharedClient, _item);
                }
                else {
                    await _itemCaller.PutAsJsonAsync(sharedClient, _item);
                }
                await _parentFormReloader.ReloadParentForm(_sessionEmployee.Type);
                
            }
            catch (Exception ex) {
                MessageBox.Show("Product Code Already in use");

                throw;
                
            }

            this.Close();



        }

        private void btnEditItemCancel_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
