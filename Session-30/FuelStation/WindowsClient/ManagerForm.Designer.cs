namespace WindowsClient {
    partial class ManagerForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.grdManagerCustomers = new DevExpress.XtraGrid.GridControl();
            this.grvManagerCustomers = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnCustomerCreate = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.grdManagerCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvManagerCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // grdManagerCustomers
            // 
            this.grdManagerCustomers.Location = new System.Drawing.Point(12, 80);
            this.grdManagerCustomers.MainView = this.grvManagerCustomers;
            this.grdManagerCustomers.Name = "grdManagerCustomers";
            this.grdManagerCustomers.Size = new System.Drawing.Size(776, 275);
            this.grdManagerCustomers.TabIndex = 0;
            this.grdManagerCustomers.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvManagerCustomers});
            // 
            // grvManagerCustomers
            // 
            this.grvManagerCustomers.GridControl = this.grdManagerCustomers;
            this.grvManagerCustomers.Name = "grvManagerCustomers";
            this.grvManagerCustomers.OptionsBehavior.Editable = false;
            this.grvManagerCustomers.OptionsBehavior.ReadOnly = true;
            this.grvManagerCustomers.OptionsView.ShowGroupPanel = false;
            // 
            // btnCustomerCreate
            // 
            this.btnCustomerCreate.Location = new System.Drawing.Point(75, 361);
            this.btnCustomerCreate.Name = "btnCustomerCreate";
            this.btnCustomerCreate.Size = new System.Drawing.Size(104, 36);
            this.btnCustomerCreate.TabIndex = 1;
            this.btnCustomerCreate.Text = "Create";
            this.btnCustomerCreate.Click += new System.EventHandler(this.btnCustomerCreate_Click);
            // 
            // ManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCustomerCreate);
            this.Controls.Add(this.grdManagerCustomers);
            this.Name = "ManagerForm";
            this.Text = "Manager";
            this.Load += new System.EventHandler(this.ManagerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdManagerCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvManagerCustomers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grdManagerCustomers;
        private DevExpress.XtraGrid.Views.Grid.GridView grvManagerCustomers;
        private DevExpress.XtraEditors.SimpleButton btnCustomerCreate;
    }
}