﻿namespace WindowsClient {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerForm));
            this.grdCustomers = new DevExpress.XtraGrid.GridControl();
            this.grvManagerCustomers = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCustomerName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomerSurname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomerCardNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnCustomerCreate = new DevExpress.XtraEditors.SimpleButton();
            this.navManager = new DevExpress.XtraBars.Navigation.NavigationPane();
            this.Customers = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.btnCustomerDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnCustomerDetails = new DevExpress.XtraEditors.SimpleButton();
            this.btnCustomerEdit = new DevExpress.XtraEditors.SimpleButton();
            this.pageItems = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.grdItems = new DevExpress.XtraGrid.GridControl();
            this.grvItems = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.pageTransactions = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.simpleButton5 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton6 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton7 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton8 = new DevExpress.XtraEditors.SimpleButton();
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
            this.colItemCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItemDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItemPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItemCost = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.grvManagerCustomers.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCustomerName,
            this.colCustomerSurname,
            this.colCustomerCardNumber});
            this.grvManagerCustomers.GridControl = this.grdCustomers;
            this.grvManagerCustomers.Name = "grvManagerCustomers";
            this.grvManagerCustomers.OptionsBehavior.Editable = false;
            this.grvManagerCustomers.OptionsBehavior.ReadOnly = true;
            this.grvManagerCustomers.OptionsView.ShowGroupPanel = false;
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
            this.Customers.Controls.Add(this.btnCustomerDelete);
            this.Customers.Controls.Add(this.btnCustomerDetails);
            this.Customers.Controls.Add(this.btnCustomerEdit);
            this.Customers.Controls.Add(this.grdCustomers);
            this.Customers.Controls.Add(this.btnCustomerCreate);
            this.Customers.Name = "Customers";
            this.Customers.Size = new System.Drawing.Size(876, 523);
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
            // 
            // pageItems
            // 
            this.pageItems.Caption = "Items";
            this.pageItems.Controls.Add(this.simpleButton1);
            this.pageItems.Controls.Add(this.simpleButton2);
            this.pageItems.Controls.Add(this.simpleButton3);
            this.pageItems.Controls.Add(this.simpleButton4);
            this.pageItems.Controls.Add(this.grdItems);
            this.pageItems.Name = "pageItems";
            this.pageItems.Size = new System.Drawing.Size(876, 523);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.simpleButton1.Appearance.Options.UseBackColor = true;
            this.simpleButton1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton1.ImageOptions.SvgImage")));
            this.simpleButton1.ImageOptions.SvgImageSize = new System.Drawing.Size(20, 20);
            this.simpleButton1.Location = new System.Drawing.Point(225, 3);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(68, 26);
            this.simpleButton1.TabIndex = 8;
            this.simpleButton1.Text = "Delete";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.simpleButton2.Appearance.Options.UseBackColor = true;
            this.simpleButton2.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton2.ImageOptions.SvgImage")));
            this.simpleButton2.ImageOptions.SvgImageSize = new System.Drawing.Size(20, 20);
            this.simpleButton2.Location = new System.Drawing.Point(151, 3);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(68, 26);
            this.simpleButton2.TabIndex = 7;
            this.simpleButton2.Text = "Details";
            // 
            // simpleButton3
            // 
            this.simpleButton3.Appearance.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.simpleButton3.Appearance.Options.UseBackColor = true;
            this.simpleButton3.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton3.ImageOptions.SvgImage")));
            this.simpleButton3.ImageOptions.SvgImageSize = new System.Drawing.Size(20, 20);
            this.simpleButton3.Location = new System.Drawing.Point(77, 3);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(68, 26);
            this.simpleButton3.TabIndex = 6;
            this.simpleButton3.Text = "Edit";
            // 
            // simpleButton4
            // 
            this.simpleButton4.Appearance.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.simpleButton4.Appearance.Options.UseBackColor = true;
            this.simpleButton4.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton4.ImageOptions.SvgImage")));
            this.simpleButton4.ImageOptions.SvgImageSize = new System.Drawing.Size(20, 20);
            this.simpleButton4.Location = new System.Drawing.Point(3, 3);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(68, 26);
            this.simpleButton4.TabIndex = 5;
            this.simpleButton4.Text = "Create";
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
            this.grvItems.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colItemCode,
            this.colItemDescription,
            this.colItemPrice,
            this.colItemCost});
            this.grvItems.GridControl = this.grdItems;
            this.grvItems.Name = "grvItems";
            this.grvItems.OptionsBehavior.Editable = false;
            this.grvItems.OptionsBehavior.ReadOnly = true;
            this.grvItems.OptionsView.ShowGroupPanel = false;
            // 
            // pageTransactions
            // 
            this.pageTransactions.Caption = "Transactions";
            this.pageTransactions.Controls.Add(this.simpleButton5);
            this.pageTransactions.Controls.Add(this.simpleButton6);
            this.pageTransactions.Controls.Add(this.simpleButton7);
            this.pageTransactions.Controls.Add(this.simpleButton8);
            this.pageTransactions.Controls.Add(this.grdTransactions);
            this.pageTransactions.Name = "pageTransactions";
            this.pageTransactions.Size = new System.Drawing.Size(876, 523);
            // 
            // simpleButton5
            // 
            this.simpleButton5.Appearance.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.simpleButton5.Appearance.Options.UseBackColor = true;
            this.simpleButton5.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton5.ImageOptions.SvgImage")));
            this.simpleButton5.ImageOptions.SvgImageSize = new System.Drawing.Size(20, 20);
            this.simpleButton5.Location = new System.Drawing.Point(225, 3);
            this.simpleButton5.Name = "simpleButton5";
            this.simpleButton5.Size = new System.Drawing.Size(68, 26);
            this.simpleButton5.TabIndex = 8;
            this.simpleButton5.Text = "Delete";
            // 
            // simpleButton6
            // 
            this.simpleButton6.Appearance.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.simpleButton6.Appearance.Options.UseBackColor = true;
            this.simpleButton6.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton6.ImageOptions.SvgImage")));
            this.simpleButton6.ImageOptions.SvgImageSize = new System.Drawing.Size(20, 20);
            this.simpleButton6.Location = new System.Drawing.Point(151, 3);
            this.simpleButton6.Name = "simpleButton6";
            this.simpleButton6.Size = new System.Drawing.Size(68, 26);
            this.simpleButton6.TabIndex = 7;
            this.simpleButton6.Text = "Details";
            // 
            // simpleButton7
            // 
            this.simpleButton7.Appearance.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.simpleButton7.Appearance.Options.UseBackColor = true;
            this.simpleButton7.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton7.ImageOptions.SvgImage")));
            this.simpleButton7.ImageOptions.SvgImageSize = new System.Drawing.Size(20, 20);
            this.simpleButton7.Location = new System.Drawing.Point(77, 3);
            this.simpleButton7.Name = "simpleButton7";
            this.simpleButton7.Size = new System.Drawing.Size(68, 26);
            this.simpleButton7.TabIndex = 6;
            this.simpleButton7.Text = "Edit";
            // 
            // simpleButton8
            // 
            this.simpleButton8.Appearance.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.simpleButton8.Appearance.Options.UseBackColor = true;
            this.simpleButton8.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton8.ImageOptions.SvgImage")));
            this.simpleButton8.ImageOptions.SvgImageSize = new System.Drawing.Size(20, 20);
            this.simpleButton8.Location = new System.Drawing.Point(3, 3);
            this.simpleButton8.Name = "simpleButton8";
            this.simpleButton8.Size = new System.Drawing.Size(68, 26);
            this.simpleButton8.TabIndex = 5;
            this.simpleButton8.Text = "Create";
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
            // colItemCode
            // 
            this.colItemCode.Caption = "Code";
            this.colItemCode.FieldName = "Code";
            this.colItemCode.Name = "colItemCode";
            this.colItemCode.Visible = true;
            this.colItemCode.VisibleIndex = 0;
            // 
            // colItemDescription
            // 
            this.colItemDescription.Caption = "Description";
            this.colItemDescription.FieldName = "Description";
            this.colItemDescription.Name = "colItemDescription";
            this.colItemDescription.Visible = true;
            this.colItemDescription.VisibleIndex = 1;
            // 
            // colItemPrice
            // 
            this.colItemPrice.Caption = "Price";
            this.colItemPrice.FieldName = "Price";
            this.colItemPrice.Name = "colItemPrice";
            this.colItemPrice.Visible = true;
            this.colItemPrice.VisibleIndex = 2;
            // 
            // colItemCost
            // 
            this.colItemCost.Caption = "Cost";
            this.colItemCost.FieldName = "Cost";
            this.colItemCost.Name = "colItemCost";
            this.colItemCost.Visible = true;
            this.colItemCost.VisibleIndex = 3;
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
        private DevExpress.XtraEditors.SimpleButton btnCustomerDelete;
        private DevExpress.XtraEditors.SimpleButton btnCustomerDetails;
        private DevExpress.XtraEditors.SimpleButton btnCustomerEdit;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerName;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerSurname;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerCardNumber;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private DevExpress.XtraEditors.SimpleButton simpleButton5;
        private DevExpress.XtraEditors.SimpleButton simpleButton6;
        private DevExpress.XtraEditors.SimpleButton simpleButton7;
        private DevExpress.XtraEditors.SimpleButton simpleButton8;
        private DevExpress.XtraGrid.Columns.GridColumn colItemCode;
        private DevExpress.XtraGrid.Columns.GridColumn colItemDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colItemPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colItemCost;
    }
}