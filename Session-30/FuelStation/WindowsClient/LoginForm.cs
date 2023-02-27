using DevExpress.XtraBars;
using FuelStation.Blazor.Client.Authentication;
using FuelStation.Blazor.Shared.DTO.Login;
using FuelStation.Model;
using System.Net;
using System.Net.Http;
using System.Net.Http.Json;

namespace WindowsClient {
    public partial class LoginForm : Form {

        private static HttpClient sharedClient = new() {
            BaseAddress = new Uri("https://localhost:7007"),
        };

        private LoginRequest loginRequest = new LoginRequest();

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

        private void brnStaff_Click(object sender, EventArgs e) {
            StaffForm staffForm = new StaffForm(sharedClient);
            staffForm.ShowDialog();
        }

       

        private async void btnLogin_Click(object sender, EventArgs e) {
            loginRequest.UserName = inputUsername.Text;
            loginRequest.Password = inputPassword.Text;

            var loginResponse = await sharedClient.PostAsJsonAsync<LoginRequest>("/Account/Login", loginRequest);

            if (loginResponse.IsSuccessStatusCode) {
                var userSession = await loginResponse.Content.ReadFromJsonAsync<UserSession>();
                //var customAuthStateProvider = (CustomAuthenticationStateProvider)authStateProvider;
                //await customAuthStateProvider.UpdateAuthenticationState(userSession);
                if(userSession.Role == "Manager") {
                    ManagerForm managerForm = new ManagerForm(sharedClient);
                    managerForm.ShowDialog();
                }
                else if(userSession.Role == "Cashier") {
                    CashierForm cashierForm = new CashierForm(sharedClient);
                    cashierForm.ShowDialog();
                }
                else if (userSession.Role == "Staff") {
                    StaffForm staffForm = new StaffForm(sharedClient);
                    staffForm.ShowDialog();
                }
                else {
                    MessageBox.Show("Invalid Account Type");
                }
            }
            else if (loginResponse.StatusCode == HttpStatusCode.Unauthorized) {
                MessageBox.Show("Wrong Credentials");
                return;
            }
        }
    }
}