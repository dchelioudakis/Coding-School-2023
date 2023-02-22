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
            this.grdCustomers = new DevExpress.XtraGrid.GridControl();
            this.grvManagerCustomers = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnCustomerCreate = new DevExpress.XtraEditors.SimpleButton();
            this.navManager = new DevExpress.XtraBars.Navigation.NavigationPane();
            this.Customers = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.pageItems = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.grdItems = new DevExpress.XtraGrid.GridControl();
            this.grvItems = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.pageTransactions = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.grdTransactions = new DevExpress.XtraGrid.GridControl();
            this.grvTransactions = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTransactionCustomerId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repCustomers = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTransactionEmployeeId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repEmployees = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTransactionDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTransactionPaymentMethod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTransactionTotalValue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnCreateTransaction = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.grdCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvManagerCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navManager)).BeginInit();
            this.navManager.SuspendLayout();
            this.Customers.SuspendLayout();
            this.pageItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvItems)).BeginInit();
            this.pageTransactions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdTransactions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvTransactions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repEmployees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            this.SuspendLayout();
            // 
            // grdCustomers
            // 
            this.grdCustomers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdCustomers.EmbeddedNavigator.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.False;
            this.grdCustomers.Location = new System.Drawing.Point(3, 45);
            this.grdCustomers.MainView = this.grvManagerCustomers;
            this.grdCustomers.Name = "grdCustomers";
            this.grdCustomers.Size = new System.Drawing.Size(870, 475);
            this.grdCustomers.TabIndex = 0;
            this.grdCustomers.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvManagerCustomers});
            // 
            // grvManagerCustomers
            // 
            this.grvManagerCustomers.GridControl = this.grdCustomers;
            this.grvManagerCustomers.Name = "grvManagerCustomers";
            this.grvManagerCustomers.OptionsBehavior.Editable = false;
            this.grvManagerCustomers.OptionsBehavior.ReadOnly = true;
            this.grvManagerCustomers.OptionsView.ShowGroupPanel = false;
            // 
            // btnCustomerCreate
            // 
            this.btnCustomerCreate.Location = new System.Drawing.Point(3, 3);
            this.btnCustomerCreate.Name = "btnCustomerCreate";
            this.btnCustomerCreate.Size = new System.Drawing.Size(104, 36);
            this.btnCustomerCreate.TabIndex = 1;
            this.btnCustomerCreate.Text = "Create";
            this.btnCustomerCreate.Click += new System.EventHandler(this.btnCustomerCreate_Click);
            // 
            // navManager
            // 
            this.navManager.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.navManager.Controls.Add(this.Customers);
            this.navManager.Controls.Add(this.pageItems);
            this.navManager.Controls.Add(this.pageTransactions);
            this.navManager.Location = new System.Drawing.Point(12, 1);
            this.navManager.Name = "navManager";
            this.navManager.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.Customers,
            this.pageItems,
            this.pageTransactions});
            this.navManager.RegularSize = new System.Drawing.Size(992, 596);
            this.navManager.SelectedPage = this.Customers;
            this.navManager.Size = new System.Drawing.Size(992, 596);
            this.navManager.TabIndex = 2;
            this.navManager.Text = "Customers";
            // 
            // Customers
            // 
            this.Customers.Caption = "Customers";
            this.Customers.Controls.Add(this.grdCustomers);
            this.Customers.Controls.Add(this.btnCustomerCreate);
            this.Customers.Name = "Customers";
            this.Customers.Size = new System.Drawing.Size(876, 523);
            // 
            // pageItems
            // 
            this.pageItems.Caption = "Items";
            this.pageItems.Controls.Add(this.grdItems);
            this.pageItems.Name = "pageItems";
            this.pageItems.Size = new System.Drawing.Size(876, 523);
            // 
            // grdItems
            // 
            this.grdItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdItems.Location = new System.Drawing.Point(3, 45);
            this.grdItems.MainView = this.grvItems;
            this.grdItems.Name = "grdItems";
            this.grdItems.Size = new System.Drawing.Size(870, 475);
            this.grdItems.TabIndex = 1;
            this.grdItems.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvItems});
            // 
            // grvItems
            // 
            this.grvItems.GridControl = this.grdItems;
            this.grvItems.Name = "grvItems";
            this.grvItems.OptionsBehavior.Editable = false;
            this.grvItems.OptionsBehavior.ReadOnly = true;
            this.grvItems.OptionsView.ShowGroupPanel = false;
            // 
            // pageTransactions
            // 
            this.pageTransactions.Caption = "Transactions";
            this.pageTransactions.Controls.Add(this.btnCreateTransaction);
            this.pageTransactions.Controls.Add(this.grdTransactions);
            this.pageTransactions.Name = "pageTransactions";
            this.pageTransactions.Size = new System.Drawing.Size(876, 523);
            // 
            // grdTransactions
            // 
            this.grdTransactions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdTransactions.Location = new System.Drawing.Point(3, 45);
            this.grdTransactions.MainView = this.grvTransactions;
            this.grdTransactions.Name = "grdTransactions";
            this.grdTransactions.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repEmployees,
            this.repCustomers});
            this.grdTransactions.Size = new System.Drawing.Size(870, 475);
            this.grdTransactions.TabIndex = 2;
            this.grdTransactions.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvTransactions});
            // 
            // grvTransactions
            // 
            this.grvTransactions.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTransactionCustomerId,
            this.colTransactionEmployeeId,
            this.colTransactionDate,
            this.colTransactionPaymentMethod,
            this.colTransactionTotalValue});
            this.grvTransactions.GridControl = this.grdTransactions;
            this.grvTransactions.Name = "grvTransactions";
            this.grvTransactions.OptionsBehavior.Editable = false;
            this.grvTransactions.OptionsBehavior.ReadOnly = true;
            this.grvTransactions.OptionsView.ShowGroupPanel = false;
            // 
            // colTransactionCustomerId
            // 
            this.colTransactionCustomerId.Caption = "Customer";
            this.colTransactionCustomerId.ColumnEdit = this.repCustomers;
            this.colTransactionCustomerId.FieldName = "CustomerId";
            this.colTransactionCustomerId.Name = "colTransactionCustomerId";
            this.colTransactionCustomerId.Visible = true;
            this.colTransactionCustomerId.VisibleIndex = 0;
            // 
            // repCustomers
            // 
            this.repCustomers.AutoHeight = false;
            this.repCustomers.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repCustomers.Name = "repCustomers";
            this.repCustomers.PopupView = this.gridView1;
            // 
            // gridView1
            // 
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colTransactionEmployeeId
            // 
            this.colTransactionEmployeeId.Caption = "Employee";
            this.colTransactionEmployeeId.ColumnEdit = this.repEmployees;
            this.colTransactionEmployeeId.FieldName = "EmployeeId";
            this.colTransactionEmployeeId.Name = "colTransactionEmployeeId";
            this.colTransactionEmployeeId.Visible = true;
            this.colTransactionEmployeeId.VisibleIndex = 1;
            // 
            // repEmployees
            // 
            this.repEmployees.AutoHeight = false;
            this.repEmployees.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repEmployees.Name = "repEmployees";
            this.repEmployees.PopupView = this.repositoryItemGridLookUpEdit1View;
            // 
            // repositoryItemGridLookUpEdit1View
            // 
            this.repositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit1View.Name = "repositoryItemGridLookUpEdit1View";
            this.repositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colTransactionDate
            // 
            this.colTransactionDate.Caption = "Date";
            this.colTransactionDate.FieldName = "Date";
            this.colTransactionDate.Name = "colTransactionDate";
            this.colTransactionDate.Visible = true;
            this.colTransactionDate.VisibleIndex = 2;
            // 
            // colTransactionPaymentMethod
            // 
            this.colTransactionPaymentMethod.Caption = "Payment Method";
            this.colTransactionPaymentMethod.FieldName = "PaymentMethod";
            this.colTransactionPaymentMethod.Name = "colTransactionPaymentMethod";
            this.colTransactionPaymentMethod.Visible = true;
            this.colTransactionPaymentMethod.VisibleIndex = 3;
            // 
            // colTransactionTotalValue
            // 
            this.colTransactionTotalValue.Caption = "Total";
            this.colTransactionTotalValue.FieldName = "TotalValue";
            this.colTransactionTotalValue.Name = "colTransactionTotalValue";
            this.colTransactionTotalValue.Visible = true;
            this.colTransactionTotalValue.VisibleIndex = 4;
            // 
            // btnCreateTransaction
            // 
            this.btnCreateTransaction.Location = new System.Drawing.Point(3, 3);
            this.btnCreateTransaction.Name = "btnCreateTransaction";
            this.btnCreateTransaction.Size = new System.Drawing.Size(104, 36);
            this.btnCreateTransaction.TabIndex = 3;
            this.btnCreateTransaction.Text = "Create";
            this.btnCreateTransaction.Click += new System.EventHandler(this.btnCreateTransaction_Click);
            // 
            // ManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 609);
            this.Controls.Add(this.navManager);
            this.Name = "ManagerForm";
            this.Text = "Manager";
            this.Load += new System.EventHandler(this.ManagerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvManagerCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navManager)).EndInit();
            this.navManager.ResumeLayout(false);
            this.Customers.ResumeLayout(false);
            this.pageItems.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvItems)).EndInit();
            this.pageTransactions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdTransactions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvTransactions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repEmployees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grdCustomers;
        private DevExpress.XtraGrid.Views.Grid.GridView grvManagerCustomers;
        private DevExpress.XtraEditors.SimpleButton btnCustomerCreate;
        private DevExpress.XtraBars.Navigation.NavigationPane navManager;
        private DevExpress.XtraBars.Navigation.NavigationPage Customers;
        private DevExpress.XtraBars.Navigation.NavigationPage pageItems;
        private DevExpress.XtraBars.Navigation.NavigationPage pageTransactions;
        private DevExpress.XtraGrid.GridControl grdItems;
        private DevExpress.XtraGrid.Views.Grid.GridView grvItems;
        private DevExpress.XtraGrid.GridControl grdTransactions;
        private DevExpress.XtraGrid.Views.Grid.GridView grvTransactions;
        private DevExpress.XtraGrid.Columns.GridColumn colTransactionCustomerId;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repCustomers;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colTransactionEmployeeId;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repEmployees;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colTransactionDate;
        private DevExpress.XtraGrid.Columns.GridColumn colTransactionPaymentMethod;
        private DevExpress.XtraGrid.Columns.GridColumn colTransactionTotalValue;
        private DevExpress.XtraEditors.SimpleButton btnCreateTransaction;
    }
}