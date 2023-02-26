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
            this.SuspendLayout();
            // 
            // btnManagerLogin
            // 
            this.btnManagerLogin.Location = new System.Drawing.Point(36, 150);
            this.btnManagerLogin.Name = "btnManagerLogin";
            this.btnManagerLogin.Size = new System.Drawing.Size(204, 94);
            this.btnManagerLogin.TabIndex = 0;
            this.btnManagerLogin.Text = "Manager";
            this.btnManagerLogin.Click += new System.EventHandler(this.btnManagerLogin_Click);
            // 
            // btnCashier
            // 
            this.btnCashier.Location = new System.Drawing.Point(259, 150);
            this.btnCashier.Name = "btnCashier";
            this.btnCashier.Size = new System.Drawing.Size(204, 94);
            this.btnCashier.TabIndex = 1;
            this.btnCashier.Text = "Cashier";
            this.btnCashier.Click += new System.EventHandler(this.btnCashier_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCashier);
            this.Controls.Add(this.btnManagerLogin);
            this.Name = "LoginForm";
            this.Text = "User Login";
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnManagerLogin;
        private DevExpress.XtraEditors.SimpleButton btnCashier;
    }
}