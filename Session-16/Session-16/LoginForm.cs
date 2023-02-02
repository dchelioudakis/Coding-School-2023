using System;
using LibCarService;
using LibSerializer;

namespace Session_16 {
    public partial class LoginForm : Form {

        public CarServiceCenter CarServiceCenter { get; set; }
        
        public LoginForm() {
            InitializeComponent();
            CarServiceCenter = new CarServiceCenter();
        }

        public void LoginForm_Load(object sender, EventArgs e) {

        }

        public void btnCustomer_Click(object sender, EventArgs e) {
            CustomerForm customerForm = new CustomerForm(this);
            customerForm.ShowDialog();
        }

        public void btnManager_Click(object sender, EventArgs e) {
            AdminForm AdminForm = new AdminForm(this);
            AdminForm.ShowDialog();
        }

        public void btnEngineer_Click(object sender, EventArgs e) {
            EngineerForm engineerForm = new EngineerForm(this);
            engineerForm.ShowDialog();
        }

        private void simpleButton1_Click(object sender, EventArgs e) {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            authenticate(username, password);

        }

        private bool authenticate(string username, string password) {

            return true;
        }
    }
}