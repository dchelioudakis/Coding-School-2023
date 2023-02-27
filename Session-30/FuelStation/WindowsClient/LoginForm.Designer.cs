namespace WindowsClient {
    partial class LoginForm {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.btnManagerLogin = new DevExpress.XtraEditors.SimpleButton();
            this.btnCashier = new DevExpress.XtraEditors.SimpleButton();
            this.brnStaff = new DevExpress.XtraEditors.SimpleButton();
            this.inputUsername = new DevExpress.XtraEditors.TextEdit();
            this.inputPassword = new DevExpress.XtraEditors.TextEdit();
            this.labelPassword = new DevExpress.XtraEditors.LabelControl();
            this.labelUsername = new DevExpress.XtraEditors.LabelControl();
            this.btnLogin = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.inputUsername.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputPassword.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnManagerLogin
            // 
            this.btnManagerLogin.Location = new System.Drawing.Point(73, 12);
            this.btnManagerLogin.Name = "btnManagerLogin";
            this.btnManagerLogin.Size = new System.Drawing.Size(204, 94);
            this.btnManagerLogin.TabIndex = 0;
            this.btnManagerLogin.Text = "Manager";
            this.btnManagerLogin.Click += new System.EventHandler(this.btnManagerLogin_Click);
            // 
            // btnCashier
            // 
            this.btnCashier.Location = new System.Drawing.Point(294, 12);
            this.btnCashier.Name = "btnCashier";
            this.btnCashier.Size = new System.Drawing.Size(204, 94);
            this.btnCashier.TabIndex = 1;
            this.btnCashier.Text = "Cashier";
            this.btnCashier.Click += new System.EventHandler(this.btnCashier_Click);
            // 
            // brnStaff
            // 
            this.brnStaff.Location = new System.Drawing.Point(514, 12);
            this.brnStaff.Name = "brnStaff";
            this.brnStaff.Size = new System.Drawing.Size(204, 94);
            this.brnStaff.TabIndex = 2;
            this.brnStaff.Text = "Staff";
            this.brnStaff.Click += new System.EventHandler(this.brnStaff_Click);
            // 
            // inputUsername
            // 
            this.inputUsername.Location = new System.Drawing.Point(291, 190);
            this.inputUsername.Name = "inputUsername";
            this.inputUsername.Size = new System.Drawing.Size(207, 20);
            this.inputUsername.TabIndex = 3;
            // 
            // inputPassword
            // 
            this.inputPassword.Location = new System.Drawing.Point(291, 250);
            this.inputPassword.Name = "inputPassword";
            this.inputPassword.Size = new System.Drawing.Size(207, 20);
            this.inputPassword.TabIndex = 4;
            // 
            // labelPassword
            // 
            this.labelPassword.Location = new System.Drawing.Point(294, 231);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(46, 13);
            this.labelPassword.TabIndex = 6;
            this.labelPassword.Text = "Password";
            // 
            // labelUsername
            // 
            this.labelUsername.Location = new System.Drawing.Point(294, 171);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(48, 13);
            this.labelUsername.TabIndex = 7;
            this.labelUsername.Text = "Username";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(291, 295);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(72, 26);
            this.btnLogin.TabIndex = 8;
            this.btnLogin.Text = "Login";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.inputPassword);
            this.Controls.Add(this.inputUsername);
            this.Controls.Add(this.brnStaff);
            this.Controls.Add(this.btnCashier);
            this.Controls.Add(this.btnManagerLogin);
            this.Name = "LoginForm";
            this.Text = "User Login";
            ((System.ComponentModel.ISupportInitialize)(this.inputUsername.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputPassword.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnManagerLogin;
        private DevExpress.XtraEditors.SimpleButton btnCashier;
        private DevExpress.XtraEditors.SimpleButton brnStaff;
        private DevExpress.XtraEditors.TextEdit inputUsername;
        private DevExpress.XtraEditors.TextEdit inputPassword;
        private DevExpress.XtraEditors.LabelControl labelPassword;
        private DevExpress.XtraEditors.LabelControl labelUsername;
        private DevExpress.XtraEditors.SimpleButton btnLogin;
    }
}