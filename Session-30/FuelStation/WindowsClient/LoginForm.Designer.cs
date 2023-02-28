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
            this.inputUsername = new DevExpress.XtraEditors.TextEdit();
            this.inputPassword = new DevExpress.XtraEditors.TextEdit();
            this.labelPassword = new DevExpress.XtraEditors.LabelControl();
            this.labelUsername = new DevExpress.XtraEditors.LabelControl();
            this.btnLogin = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.inputUsername.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputPassword.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // inputUsername
            // 
            this.inputUsername.Location = new System.Drawing.Point(77, 105);
            this.inputUsername.Name = "inputUsername";
            this.inputUsername.Size = new System.Drawing.Size(207, 20);
            this.inputUsername.TabIndex = 3;
            // 
            // inputPassword
            // 
            this.inputPassword.Location = new System.Drawing.Point(77, 165);
            this.inputPassword.Name = "inputPassword";
            this.inputPassword.Size = new System.Drawing.Size(207, 20);
            this.inputPassword.TabIndex = 4;
            // 
            // labelPassword
            // 
            this.labelPassword.Location = new System.Drawing.Point(80, 146);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(46, 13);
            this.labelPassword.TabIndex = 6;
            this.labelPassword.Text = "Password";
            // 
            // labelUsername
            // 
            this.labelUsername.Location = new System.Drawing.Point(80, 86);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(48, 13);
            this.labelUsername.TabIndex = 7;
            this.labelUsername.Text = "Username";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(77, 210);
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
            this.ClientSize = new System.Drawing.Size(367, 319);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.inputPassword);
            this.Controls.Add(this.inputUsername);
            this.Name = "LoginForm";
            this.Text = "User Login";
            ((System.ComponentModel.ISupportInitialize)(this.inputUsername.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputPassword.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.TextEdit inputUsername;
        private DevExpress.XtraEditors.TextEdit inputPassword;
        private DevExpress.XtraEditors.LabelControl labelPassword;
        private DevExpress.XtraEditors.LabelControl labelUsername;
        private DevExpress.XtraEditors.SimpleButton btnLogin;
    }
}