namespace WindowsClient {
    partial class CashierForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CashierForm));
            this.navManager = new DevExpress.XtraBars.Navigation.NavigationPane();
            this.Customers = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.btnCustomerDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnCustomerDetails = new DevExpress.XtraEditors.SimpleButton();
            this.btnCustomerEdit = new DevExpress.XtraEditors.SimpleButton();
            this.grdCustomers = new DevExpress.XtraGrid.GridControl();
            this.grvCustomers = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCustomerId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomerName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomerSurname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomerCardNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnCustomerCreate = new DevExpress.XtraEditors.SimpleButton();
            this.pageTransactions = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.btnTransactionDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnTransactionDetails = new DevExpress.XtraEditors.SimpleButton();
            this.btnTransactionEdit = new DevExpress.XtraEditors.SimpleButton();
            this.btnTransactionCreate = new DevExpress.XtraEditors.SimpleButton();
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
            ((System.ComponentModel.ISupportInitialize)(this.navManager)).BeginInit();
            this.navManager.SuspendLayout();
            this.Customers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvCustomers)).BeginInit();
            this.pageTransactions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdTransactions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvTransactions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repEmployees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            this.SuspendLayout();
            // 
            // navManager
            // 
            this.navManager.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.navManager.Controls.Add(this.Customers);
            this.navManager.Controls.Add(this.pageTransactions);
            this.navManager.Location = new System.Drawing.Point(10, 10);
            this.navManager.Name = "navManager";
            this.navManager.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.Customers,
            this.pageTransactions});
            this.navManager.RegularSize = new System.Drawing.Size(1068, 546);
            this.navManager.SelectedPage = this.Customers;
            this.navManager.Size = new System.Drawing.Size(1068, 546);
            this.navManager.TabIndex = 3;
            this.navManager.Text = "Customers";
            // 
            // Customers
            // 
            this.Customers.Caption = "Customers";
            this.Customers.Controls.Add(this.btnCustomerDelete);
            this.Customers.Controls.Add(this.btnCustomerDetails);
            this.Customers.Controls.Add(this.btnCustomerEdit);
            this.Customers.Controls.Add(this.grdCustomers);
            this.Customers.Controls.Add(this.btnCustomerCreate);
            this.Customers.Name = "Customers";
            this.Customers.Size = new System.Drawing.Size(952, 473);
            // 
            // btnCustomerDelete
            // 
            this.btnCustomerDelete.Appearance.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCustomerDelete.Appearance.Options.UseBackColor = true;
            this.btnCustomerDelete.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnCustomerDelete.ImageOptions.SvgImage")));
            this.btnCustomerDelete.ImageOptions.SvgImageSize = new System.Drawing.Size(20, 20);
            this.btnCustomerDelete.Location = new System.Drawing.Point(225, 3);
            this.btnCustomerDelete.Name = "btnCustomerDelete";
            this.btnCustomerDelete.Size = new System.Drawing.Size(68, 26);
            this.btnCustomerDelete.TabIndex = 4;
            this.btnCustomerDelete.Text = "Delete";
            this.btnCustomerDelete.Click += new System.EventHandler(this.btnCustomerDelete_Click);
            // 
            // btnCustomerDetails
            // 
            this.btnCustomerDetails.Appearance.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCustomerDetails.Appearance.Options.UseBackColor = true;
            this.btnCustomerDetails.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnCustomerDetails.ImageOptions.SvgImage")));
            this.btnCustomerDetails.ImageOptions.SvgImageSize = new System.Drawing.Size(20, 20);
            this.btnCustomerDetails.Location = new System.Drawing.Point(151, 3);
            this.btnCustomerDetails.Name = "btnCustomerDetails";
            this.btnCustomerDetails.Size = new System.Drawing.Size(68, 26);
            this.btnCustomerDetails.TabIndex = 3;
            this.btnCustomerDetails.Text = "Details";
            this.btnCustomerDetails.Click += new System.EventHandler(this.btnCustomerDetails_Click);
            // 
            // btnCustomerEdit
            // 
            this.btnCustomerEdit.Appearance.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCustomerEdit.Appearance.Options.UseBackColor = true;
            this.btnCustomerEdit.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnCustomerEdit.ImageOptions.SvgImage")));
            this.btnCustomerEdit.ImageOptions.SvgImageSize = new System.Drawing.Size(20, 20);
            this.btnCustomerEdit.Location = new System.Drawing.Point(77, 3);
            this.btnCustomerEdit.Name = "btnCustomerEdit";
            this.btnCustomerEdit.Size = new System.Drawing.Size(68, 26);
            this.btnCustomerEdit.TabIndex = 2;
            this.btnCustomerEdit.Text = "Edit";
            this.btnCustomerEdit.Click += new System.EventHandler(this.btnCustomerEdit_Click);
            // 
            // grdCustomers
            // 
            this.grdCustomers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdCustomers.EmbeddedNavigator.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.False;
            this.grdCustomers.Location = new System.Drawing.Point(3, 45);
            this.grdCustomers.MainView = this.grvCustomers;
            this.grdCustomers.Name = "grdCustomers";
            this.grdCustomers.Size = new System.Drawing.Size(946, 425);
            this.grdCustomers.TabIndex = 0;
            this.grdCustomers.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvCustomers});
            // 
            // grvCustomers
            // 
            this.grvCustomers.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCustomerId,
            this.colCustomerName,
            this.colCustomerSurname,
            this.colCustomerCardNumber});
            this.grvCustomers.GridControl = this.grdCustomers;
            this.grvCustomers.Name = "grvCustomers";
            this.grvCustomers.OptionsBehavior.Editable = false;
            this.grvCustomers.OptionsBehavior.ReadOnly = true;
            this.grvCustomers.OptionsView.ShowGroupPanel = false;
            // 
            // colCustomerId
            // 
            this.colCustomerId.Caption = "Id";
            this.colCustomerId.FieldName = "Id";
            this.colCustomerId.Name = "colCustomerId";
            // 
            // colCustomerName
            // 
            this.colCustomerName.Caption = "Name";
            this.colCustomerName.FieldName = "Name";
            this.colCustomerName.Name = "colCustomerName";
            this.colCustomerName.Visible = true;
            this.colCustomerName.VisibleIndex = 0;
            // 
            // colCustomerSurname
            // 
            this.colCustomerSurname.Caption = "Surname";
            this.colCustomerSurname.FieldName = "Surname";
            this.colCustomerSurname.Name = "colCustomerSurname";
            this.colCustomerSurname.Visible = true;
            this.colCustomerSurname.VisibleIndex = 1;
            // 
            // colCustomerCardNumber
            // 
            this.colCustomerCardNumber.Caption = "Card Number";
            this.colCustomerCardNumber.FieldName = "CardNumber";
            this.colCustomerCardNumber.Name = "colCustomerCardNumber";
            this.colCustomerCardNumber.Visible = true;
            this.colCustomerCardNumber.VisibleIndex = 2;
            // 
            // btnCustomerCreate
            // 
            this.btnCustomerCreate.Appearance.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCustomerCreate.Appearance.Options.UseBackColor = true;
            this.btnCustomerCreate.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnCustomerCreate.ImageOptions.SvgImage")));
            this.btnCustomerCreate.ImageOptions.SvgImageSize = new System.Drawing.Size(20, 20);
            this.btnCustomerCreate.Location = new System.Drawing.Point(3, 3);
            this.btnCustomerCreate.Name = "btnCustomerCreate";
            this.btnCustomerCreate.Size = new System.Drawing.Size(68, 26);
            this.btnCustomerCreate.TabIndex = 1;
            this.btnCustomerCreate.Text = "Create";
            this.btnCustomerCreate.Click += new System.EventHandler(this.btnCustomerCreate_Click);
            // 
            // pageTransactions
            // 
            this.pageTransactions.Caption = "Transactions";
            this.pageTransactions.Controls.Add(this.btnTransactionDelete);
            this.pageTransactions.Controls.Add(this.btnTransactionDetails);
            this.pageTransactions.Controls.Add(this.btnTransactionEdit);
            this.pageTransactions.Controls.Add(this.btnTransactionCreate);
            this.pageTransactions.Controls.Add(this.grdTransactions);
            this.pageTransactions.Name = "pageTransactions";
            this.pageTransactions.Size = new System.Drawing.Size(952, 473);
            // 
            // btnTransactionDelete
            // 
            this.btnTransactionDelete.Appearance.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnTransactionDelete.Appearance.Options.UseBackColor = true;
            this.btnTransactionDelete.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnTransactionDelete.ImageOptions.SvgImage")));
            this.btnTransactionDelete.ImageOptions.SvgImageSize = new System.Drawing.Size(20, 20);
            this.btnTransactionDelete.Location = new System.Drawing.Point(225, 3);
            this.btnTransactionDelete.Name = "btnTransactionDelete";
            this.btnTransactionDelete.Size = new System.Drawing.Size(68, 26);
            this.btnTransactionDelete.TabIndex = 8;
            this.btnTransactionDelete.Text = "Delete";
            this.btnTransactionDelete.Click += new System.EventHandler(this.btnTransactionDelete_Click);
            // 
            // btnTransactionDetails
            // 
            this.btnTransactionDetails.Appearance.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnTransactionDetails.Appearance.Options.UseBackColor = true;
            this.btnTransactionDetails.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnTransactionDetails.ImageOptions.SvgImage")));
            this.btnTransactionDetails.ImageOptions.SvgImageSize = new System.Drawing.Size(20, 20);
            this.btnTransactionDetails.Location = new System.Drawing.Point(151, 3);
            this.btnTransactionDetails.Name = "btnTransactionDetails";
            this.btnTransactionDetails.Size = new System.Drawing.Size(68, 26);
            this.btnTransactionDetails.TabIndex = 7;
            this.btnTransactionDetails.Text = "Details";
            this.btnTransactionDetails.Click += new System.EventHandler(this.btnTransactionDetails_Click);
            // 
            // btnTransactionEdit
            // 
            this.btnTransactionEdit.Appearance.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnTransactionEdit.Appearance.Options.UseBackColor = true;
            this.btnTransactionEdit.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnTransactionEdit.ImageOptions.SvgImage")));
            this.btnTransactionEdit.ImageOptions.SvgImageSize = new System.Drawing.Size(20, 20);
            this.btnTransactionEdit.Location = new System.Drawing.Point(77, 3);
            this.btnTransactionEdit.Name = "btnTransactionEdit";
            this.btnTransactionEdit.Size = new System.Drawing.Size(68, 26);
            this.btnTransactionEdit.TabIndex = 6;
            this.btnTransactionEdit.Text = "Edit";
            this.btnTransactionEdit.Click += new System.EventHandler(this.btnTransactionEdit_Click);
            // 
            // btnTransactionCreate
            // 
            this.btnTransactionCreate.Appearance.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnTransactionCreate.Appearance.Options.UseBackColor = true;
            this.btnTransactionCreate.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnTransactionCreate.ImageOptions.SvgImage")));
            this.btnTransactionCreate.ImageOptions.SvgImageSize = new System.Drawing.Size(20, 20);
            this.btnTransactionCreate.Location = new System.Drawing.Point(3, 3);
            this.btnTransactionCreate.Name = "btnTransactionCreate";
            this.btnTransactionCreate.Size = new System.Drawing.Size(68, 26);
            this.btnTransactionCreate.TabIndex = 5;
            this.btnTransactionCreate.Text = "Create";
            this.btnTransactionCreate.Click += new System.EventHandler(this.btnTransactionCreate_Click);
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
            this.grdTransactions.Size = new System.Drawing.Size(949, 428);
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
            // CashierForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 568);
            this.Controls.Add(this.navManager);
            this.Name = "CashierForm";
            this.Text = "CashierForm";
            this.Load += new System.EventHandler(this.CashierForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.navManager)).EndInit();
            this.navManager.ResumeLayout(false);
            this.Customers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvCustomers)).EndInit();
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

        private DevExpress.XtraBars.Navigation.NavigationPane navManager;
        private DevExpress.XtraBars.Navigation.NavigationPage Customers;
        private DevExpress.XtraEditors.SimpleButton btnCustomerDelete;
        private DevExpress.XtraEditors.SimpleButton btnCustomerDetails;
        private DevExpress.XtraEditors.SimpleButton btnCustomerEdit;
        private DevExpress.XtraGrid.GridControl grdCustomers;
        private DevExpress.XtraGrid.Views.Grid.GridView grvCustomers;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerId;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerName;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerSurname;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerCardNumber;
        private DevExpress.XtraEditors.SimpleButton btnCustomerCreate;
        private DevExpress.XtraBars.Navigation.NavigationPage pageTransactions;
        private DevExpress.XtraEditors.SimpleButton btnTransactionDelete;
        private DevExpress.XtraEditors.SimpleButton btnTransactionDetails;
        private DevExpress.XtraEditors.SimpleButton btnTransactionEdit;
        private DevExpress.XtraEditors.SimpleButton btnTransactionCreate;
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
    }
}