using FuelStation.Model;

namespace WindowsClient {
    public partial class LoginForm : Form {
        public LoginForm() {
            InitializeComponent();
        }

        private void btnManagerLogin_Click(object sender, EventArgs e) {
            ManagerForm managerForm = new ManagerForm();
            managerForm.ShowDialog();
        }
    }
}