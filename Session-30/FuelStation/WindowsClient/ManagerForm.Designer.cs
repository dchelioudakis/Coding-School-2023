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
            this.tabCustomers = new DevExpress.XtraTab.XtraTabControl();
            this.Customers = new DevExpress.XtraTab.XtraTabPage();
            this.Items = new DevExpress.XtraTab.XtraTabPage();
            this.Transactions = new DevExpress.XtraTab.XtraTabPage();
            ((System.ComponentModel.ISupportInitialize)(this.tabCustomers)).BeginInit();
            this.tabCustomers.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabCustomers
            // 
            this.tabCustomers.Location = new System.Drawing.Point(12, 12);
            this.tabCustomers.Name = "tabCustomers";
            this.tabCustomers.SelectedTabPage = this.Customers;
            this.tabCustomers.Size = new System.Drawing.Size(909, 512);
            this.tabCustomers.TabIndex = 1;
            this.tabCustomers.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.Customers,
            this.Items,
            this.Transactions});
            // 
            // Customers
            // 
            this.Customers.Name = "Customers";
            this.Customers.Size = new System.Drawing.Size(907, 487);
            this.Customers.Text = "Customers";
            // 
            // Items
            // 
            this.Items.Name = "Items";
            this.Items.Size = new System.Drawing.Size(907, 487);
            this.Items.Text = "Items";
            // 
            // Transactions
            // 
            this.Transactions.Name = "Transactions";
            this.Transactions.Size = new System.Drawing.Size(0, 0);
            this.Transactions.Text = "Transactions";
            // 
            // ManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 536);
            this.Controls.Add(this.tabCustomers);
            this.Name = "ManagerForm";
            this.Text = "ManagerForm";
            ((System.ComponentModel.ISupportInitialize)(this.tabCustomers)).EndInit();
            this.tabCustomers.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl tabCustomers;
        private DevExpress.XtraTab.XtraTabPage Customers;
        private DevExpress.XtraTab.XtraTabPage Items;
        private DevExpress.XtraTab.XtraTabPage Transactions;
    }
}