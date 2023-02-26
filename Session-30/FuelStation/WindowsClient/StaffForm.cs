using FuelStation.Blazor.Shared.DTO.Employee;
using FuelStation.Blazor.Shared.DTO.Item;
using FuelStation.Blazor.Shared.DTO.Transaction;
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
using WindowsClient.WindowsApiCalls;
using WindowsClient.WindowsFormsOperations;

namespace WindowsClient {
    public partial class StaffForm : Form {

        private List<ItemListDto> _itemList;
        public HttpClient sharedClient;
        private ItemFormsHandler _itemFormsHandler = new();

        public StaffForm(HttpClient sharedClient) {
            InitializeComponent();
            this.sharedClient = sharedClient;
        }

        private async void StaffForm_Load(object sender, EventArgs e) {
            await LoadDataFromDb();
            await LoadDataToGrids();
        }

        private async Task LoadDataFromDb() {
            ItemCaller itemCaller = new ItemCaller();
            _itemList = await itemCaller.GetItemsAsync(sharedClient);
        }

        private async Task LoadDataToGrids() {
            grdItems.DataSource = _itemList;
        }

        private async void btnItemCreate_Click(object sender, EventArgs e) {
            await _itemFormsHandler.Create(sharedClient);
        }

        private async void btnItemEdit_Click(object sender, EventArgs e) {
            int itemId = Int32.Parse(grvItems.GetRowCellValue(grvItems.FocusedRowHandle, "Id").ToString());
            await _itemFormsHandler.Edit(sharedClient, itemId);
        }

        private async void btnItemDetails_Click(object sender, EventArgs e) {
            int itemId = Int32.Parse(grvItems.GetRowCellValue(grvItems.FocusedRowHandle, "Id").ToString());
            await _itemFormsHandler.Details(sharedClient, itemId);
        }

        private async void btnItemDelete_Click(object sender, EventArgs e) {
            int rowHandle = grvItems.FocusedRowHandle;
            int itemId = Int32.Parse(grvItems.GetRowCellValue(rowHandle, "Id").ToString());
            DialogResult dialogResult = MessageBox.Show("Item Delete. Are your sure?", "Item Delete", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes) {
                using HttpResponseMessage response = await sharedClient.DeleteAsync($"item/{itemId}");
                response.EnsureSuccessStatusCode();
            }
            else {
                return;
            }
        }
    }
}
