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
            this.btnManager = new DevExpress.XtraEditors.SimpleButton();
            this.btnStaff = new DevExpress.XtraEditors.SimpleButton();
            this.btnCashier = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // btnManager
            // 
            this.btnManager.Location = new System.Drawing.Point(44, 321);
            this.btnManager.Name = "btnManager";
            this.btnManager.Size = new System.Drawing.Size(150, 93);
            this.btnManager.TabIndex = 3;
            this.btnManager.Text = "Manager";
            // 
            // btnStaff
            // 
            this.btnStaff.Location = new System.Drawing.Point(307, 321);
            this.btnStaff.Name = "btnStaff";
            this.btnStaff.Size = new System.Drawing.Size(150, 93);
            this.btnStaff.TabIndex = 4;
            this.btnStaff.Text = "Staff";
            // 
            // btnCashier
            // 
            this.btnCashier.Location = new System.Drawing.Point(574, 321);
            this.btnCashier.Name = "btnCashier";
            this.btnCashier.Size = new System.Drawing.Size(150, 93);
            this.btnCashier.TabIndex = 5;
            this.btnCashier.Text = "Cashier";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCashier);
            this.Controls.Add(this.btnStaff);
            this.Controls.Add(this.btnManager);
            this.Name = "LoginForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnManager;
        private DevExpress.XtraEditors.SimpleButton btnStaff;
        private DevExpress.XtraEditors.SimpleButton btnCashier;
    }
}