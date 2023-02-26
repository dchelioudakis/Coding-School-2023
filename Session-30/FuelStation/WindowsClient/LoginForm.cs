using FuelStation.Model;
using System.Net.Http;

namespace WindowsClient {
    public partial class LoginForm : Form {

        private static HttpClient sharedClient = new() {
            BaseAddress = new Uri("https://localhost:7007"),
        };
        public LoginForm() {
            InitializeComponent();
        }

        private void btnManagerLogin_Click(object sender, EventArgs e) {
            ManagerForm managerForm = new ManagerForm(sharedClient);
            managerForm.ShowDialog();
        }

        private void btnCashier_Click(object sender, EventArgs e) {
            CashierForm cashierForm = new CashierForm(sharedClient);
            cashierForm.ShowDialog();
        }
    }
}