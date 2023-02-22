using DevExpress.XtraRichEdit.Import.Html;
using FuelStation.Blazor.Shared.DTO.Customer;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsClient {
    public partial class NewCustomerForm : Form {

        private CustomerEditDto _newCustomer = new();
        public NewCustomerForm() {
            InitializeComponent();

            this.customerEditDtoBindingSource.DataSource = new BindingSource() { DataSource = _newCustomer };
        }

        private void btnCancelNewCustomer_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void btnNewCustomerSave_Click(object sender, EventArgs e) {
            var newCustomer = JsonConvert.SerializeObject(_newCustomer);

        }
    }
}
