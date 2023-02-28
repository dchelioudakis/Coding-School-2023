namespace WindowsClient {
    partial class TransactionCreateForm {
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransactionCreateForm));
            this.inputTransactionEmployeeId = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.transactionEditDtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.employeeListDtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inputTransactionTotalValue = new DevExpress.XtraEditors.TextEdit();
            this.labelTransactionCustomerId = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelTransactionTotalValue = new DevExpress.XtraEditors.LabelControl();
            this.inputTransactionCustomerId = new DevExpress.XtraEditors.TextEdit();
            this.customerListDtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inputTransactionCustomerName = new DevExpress.XtraEditors.TextEdit();
            this.labelTransactionCustomerName = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.inputTransactionCustomerSurname = new DevExpress.XtraEditors.TextEdit();
            this.labelTransactionLines = new DevExpress.XtraEditors.LabelControl();
            this.grdTransactionLines = new DevExpress.XtraGrid.GridControl();
            this.grvTransactionLines = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTransactionLineItemId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repTransactionLineItems = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.repositoryItemSearchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTransactionLineQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTransactionLineItemPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTransactionLineNetValue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTransactionLineDiscountPercent = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTransactionLineDiscountValue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTransactionLineTotalValue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnAddTransactionLine = new DevExpress.XtraEditors.SimpleButton();
            this.btnCash = new DevExpress.XtraEditors.SimpleButton();
            this.btnCard = new DevExpress.XtraEditors.SimpleButton();
            this.btnDeleteTransactionLine = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.inputTransactionTotalQuantity = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.inputTransactionNetValue = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.inputTransactionTotalDiscount = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.inputTransactionEmployeeId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionEditDtoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeListDtoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputTransactionTotalValue.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputTransactionCustomerId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerListDtoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputTransactionCustomerName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputTransactionCustomerSurname.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdTransactionLines)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvTransactionLines)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repTransactionLineItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputTransactionTotalQuantity.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputTransactionNetValue.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputTransactionTotalDiscount.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // inputTransactionEmployeeId
            // 
            this.inputTransactionEmployeeId.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.transactionEditDtoBindingSource, "EmployeeId", true));
            this.inputTransactionEmployeeId.Location = new System.Drawing.Point(186, 30);
            this.inputTransactionEmployeeId.Name = "inputTransactionEmployeeId";
            this.inputTransactionEmployeeId.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.inputTransactionEmployeeId.Properties.PopupView = this.gridView1;
            this.inputTransactionEmployeeId.Properties.ReadOnly = true;
            this.inputTransactionEmployeeId.Size = new System.Drawing.Size(161, 20);
            this.inputTransactionEmployeeId.TabIndex = 1;
            // 
            // transactionEditDtoBindingSource
            // 
            this.transactionEditDtoBindingSource.DataSource = typeof(FuelStation.Blazor.Shared.DTO.Transaction.TransactionEditDto);
            // 
            // gridView1
            // 
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // employeeListDtoBindingSource
            // 
            this.employeeListDtoBindingSource.DataSource = typeof(FuelStation.Blazor.Shared.DTO.Employee.EmployeeListDto);
            // 
            // inputTransactionTotalValue
            // 
            this.inputTransactionTotalValue.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.transactionEditDtoBindingSource, "TotalValue", true));
            this.inputTransactionTotalValue.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.transactionEditDtoBindingSource, "TotalValue", true));
            this.inputTransactionTotalValue.Location = new System.Drawing.Point(115, 105);
            this.inputTransactionTotalValue.Name = "inputTransactionTotalValue";
            this.inputTransactionTotalValue.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.inputTransactionTotalValue.Properties.Appearance.Options.UseFont = true;
            this.inputTransactionTotalValue.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.inputTransactionTotalValue.Properties.ReadOnly = true;
            this.inputTransactionTotalValue.Size = new System.Drawing.Size(79, 22);
            this.inputTransactionTotalValue.TabIndex = 3;
            // 
            // labelTransactionCustomerId
            // 
            this.labelTransactionCustomerId.Location = new System.Drawing.Point(12, 11);
            this.labelTransactionCustomerId.Name = "labelTransactionCustomerId";
            this.labelTransactionCustomerId.Size = new System.Drawing.Size(112, 13);
            this.labelTransactionCustomerId.TabIndex = 5;
            this.labelTransactionCustomerId.Text = "Customer Card Number";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(186, 11);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(46, 13);
            this.labelControl2.TabIndex = 6;
            this.labelControl2.Text = "Employee";
            // 
            // labelTransactionTotalValue
            // 
            this.labelTransactionTotalValue.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTransactionTotalValue.Appearance.Options.UseFont = true;
            this.labelTransactionTotalValue.Location = new System.Drawing.Point(8, 107);
            this.labelTransactionTotalValue.Name = "labelTransactionTotalValue";
            this.labelTransactionTotalValue.Size = new System.Drawing.Size(67, 18);
            this.labelTransactionTotalValue.TabIndex = 9;
            this.labelTransactionTotalValue.Text = "Total(€):";
            // 
            // inputTransactionCustomerId
            // 
            this.inputTransactionCustomerId.Location = new System.Drawing.Point(12, 30);
            this.inputTransactionCustomerId.Name = "inputTransactionCustomerId";
            this.inputTransactionCustomerId.Size = new System.Drawing.Size(161, 20);
            this.inputTransactionCustomerId.TabIndex = 10;
            this.inputTransactionCustomerId.KeyDown += new System.Windows.Forms.KeyEventHandler(this.inputTransactionCustomerId_KeyDown);
            // 
            // customerListDtoBindingSource
            // 
            this.customerListDtoBindingSource.DataSource = typeof(FuelStation.Blazor.Shared.DTO.Customer.CustomerListDto);
            // 
            // inputTransactionCustomerName
            // 
            this.inputTransactionCustomerName.DataBindings.Add(new System.Windows.Forms.Binding("DataContext", this.transactionEditDtoBindingSource, "CustomerId", true));
            this.inputTransactionCustomerName.Location = new System.Drawing.Point(12, 75);
            this.inputTransactionCustomerName.Name = "inputTransactionCustomerName";
            this.inputTransactionCustomerName.Properties.ReadOnly = true;
            this.inputTransactionCustomerName.Size = new System.Drawing.Size(161, 20);
            this.inputTransactionCustomerName.TabIndex = 11;
            // 
            // labelTransactionCustomerName
            // 
            this.labelTransactionCustomerName.Location = new System.Drawing.Point(12, 56);
            this.labelTransactionCustomerName.Name = "labelTransactionCustomerName";
            this.labelTransactionCustomerName.Size = new System.Drawing.Size(76, 13);
            this.labelTransactionCustomerName.TabIndex = 12;
            this.labelTransactionCustomerName.Text = "Customer Name";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(185, 56);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(91, 13);
            this.labelControl1.TabIndex = 13;
            this.labelControl1.Text = "Customer Surname";
            // 
            // inputTransactionCustomerSurname
            // 
            this.inputTransactionCustomerSurname.DataBindings.Add(new System.Windows.Forms.Binding("DataContext", this.transactionEditDtoBindingSource, "CustomerId", true));
            this.inputTransactionCustomerSurname.Location = new System.Drawing.Point(185, 75);
            this.inputTransactionCustomerSurname.Name = "inputTransactionCustomerSurname";
            this.inputTransactionCustomerSurname.Properties.ReadOnly = true;
            this.inputTransactionCustomerSurname.Size = new System.Drawing.Size(162, 20);
            this.inputTransactionCustomerSurname.TabIndex = 14;
            // 
            // labelTransactionLines
            // 
            this.labelTransactionLines.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTransactionLines.Appearance.Options.UseFont = true;
            this.labelTransactionLines.Location = new System.Drawing.Point(12, 177);
            this.labelTransactionLines.Name = "labelTransactionLines";
            this.labelTransactionLines.Size = new System.Drawing.Size(123, 19);
            this.labelTransactionLines.TabIndex = 15;
            this.labelTransactionLines.Text = "Transaction Lines";
            // 
            // grdTransactionLines
            // 
            this.grdTransactionLines.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdTransactionLines.Location = new System.Drawing.Point(12, 202);
            this.grdTransactionLines.MainView = this.grvTransactionLines;
            this.grdTransactionLines.Name = "grdTransactionLines";
            this.grdTransactionLines.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repTransactionLineItems});
            this.grdTransactionLines.Size = new System.Drawing.Size(687, 319);
            this.grdTransactionLines.TabIndex = 16;
            this.grdTransactionLines.UseEmbeddedNavigator = true;
            this.grdTransactionLines.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvTransactionLines});
            // 
            // grvTransactionLines
            // 
            this.grvTransactionLines.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTransactionLineItemId,
            this.colTransactionLineQuantity,
            this.colTransactionLineItemPrice,
            this.colTransactionLineNetValue,
            this.colTransactionLineDiscountPercent,
            this.colTransactionLineDiscountValue,
            this.colTransactionLineTotalValue});
            this.grvTransactionLines.GridControl = this.grdTransactionLines;
            this.grvTransactionLines.Name = "grvTransactionLines";
            this.grvTransactionLines.OptionsView.ShowGroupPanel = false;
            this.grvTransactionLines.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.grvTransactionLines_CellValueChanged);
            // 
            // colTransactionLineItemId
            // 
            this.colTransactionLineItemId.Caption = "Item";
            this.colTransactionLineItemId.ColumnEdit = this.repTransactionLineItems;
            this.colTransactionLineItemId.FieldName = "ItemId";
            this.colTransactionLineItemId.Name = "colTransactionLineItemId";
            this.colTransactionLineItemId.Visible = true;
            this.colTransactionLineItemId.VisibleIndex = 0;
            // 
            // repTransactionLineItems
            // 
            this.repTransactionLineItems.AutoHeight = false;
            this.repTransactionLineItems.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repTransactionLineItems.Name = "repTransactionLineItems";
            this.repTransactionLineItems.PopupView = this.repositoryItemSearchLookUpEdit1View;
            // 
            // repositoryItemSearchLookUpEdit1View
            // 
            this.repositoryItemSearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemSearchLookUpEdit1View.Name = "repositoryItemSearchLookUpEdit1View";
            this.repositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colTransactionLineQuantity
            // 
            this.colTransactionLineQuantity.Caption = "Quantity";
            this.colTransactionLineQuantity.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTransactionLineQuantity.FieldName = "Quantity";
            this.colTransactionLineQuantity.Name = "colTransactionLineQuantity";
            this.colTransactionLineQuantity.UnboundDataType = typeof(decimal);
            this.colTransactionLineQuantity.Visible = true;
            this.colTransactionLineQuantity.VisibleIndex = 1;
            // 
            // colTransactionLineItemPrice
            // 
            this.colTransactionLineItemPrice.Caption = "Item Price";
            this.colTransactionLineItemPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTransactionLineItemPrice.FieldName = "ItemPrice";
            this.colTransactionLineItemPrice.Name = "colTransactionLineItemPrice";
            this.colTransactionLineItemPrice.OptionsColumn.AllowEdit = false;
            this.colTransactionLineItemPrice.OptionsColumn.AllowFocus = false;
            this.colTransactionLineItemPrice.OptionsColumn.ReadOnly = true;
            this.colTransactionLineItemPrice.UnboundDataType = typeof(decimal);
            this.colTransactionLineItemPrice.Visible = true;
            this.colTransactionLineItemPrice.VisibleIndex = 2;
            // 
            // colTransactionLineNetValue
            // 
            this.colTransactionLineNetValue.Caption = "Net Value";
            this.colTransactionLineNetValue.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTransactionLineNetValue.FieldName = "NetValue";
            this.colTransactionLineNetValue.Name = "colTransactionLineNetValue";
            this.colTransactionLineNetValue.OptionsColumn.AllowEdit = false;
            this.colTransactionLineNetValue.OptionsColumn.AllowFocus = false;
            this.colTransactionLineNetValue.OptionsColumn.ReadOnly = true;
            this.colTransactionLineNetValue.UnboundDataType = typeof(decimal);
            this.colTransactionLineNetValue.Visible = true;
            this.colTransactionLineNetValue.VisibleIndex = 3;
            // 
            // colTransactionLineDiscountPercent
            // 
            this.colTransactionLineDiscountPercent.Caption = "Discount(%)";
            this.colTransactionLineDiscountPercent.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTransactionLineDiscountPercent.FieldName = "DiscountPercent";
            this.colTransactionLineDiscountPercent.Name = "colTransactionLineDiscountPercent";
            this.colTransactionLineDiscountPercent.OptionsColumn.AllowEdit = false;
            this.colTransactionLineDiscountPercent.OptionsColumn.AllowFocus = false;
            this.colTransactionLineDiscountPercent.OptionsColumn.ReadOnly = true;
            this.colTransactionLineDiscountPercent.UnboundDataType = typeof(decimal);
            this.colTransactionLineDiscountPercent.Visible = true;
            this.colTransactionLineDiscountPercent.VisibleIndex = 4;
            // 
            // colTransactionLineDiscountValue
            // 
            this.colTransactionLineDiscountValue.Caption = "Discount(€)";
            this.colTransactionLineDiscountValue.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTransactionLineDiscountValue.FieldName = "DiscountValue";
            this.colTransactionLineDiscountValue.Name = "colTransactionLineDiscountValue";
            this.colTransactionLineDiscountValue.OptionsColumn.AllowEdit = false;
            this.colTransactionLineDiscountValue.OptionsColumn.AllowFocus = false;
            this.colTransactionLineDiscountValue.OptionsColumn.ReadOnly = true;
            this.colTransactionLineDiscountValue.UnboundDataType = typeof(decimal);
            this.colTransactionLineDiscountValue.Visible = true;
            this.colTransactionLineDiscountValue.VisibleIndex = 5;
            // 
            // colTransactionLineTotalValue
            // 
            this.colTransactionLineTotalValue.Caption = "Total";
            this.colTransactionLineTotalValue.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTransactionLineTotalValue.FieldName = "TotalValue";
            this.colTransactionLineTotalValue.Name = "colTransactionLineTotalValue";
            this.colTransactionLineTotalValue.OptionsColumn.AllowEdit = false;
            this.colTransactionLineTotalValue.OptionsColumn.AllowFocus = false;
            this.colTransactionLineTotalValue.OptionsColumn.ReadOnly = true;
            this.colTransactionLineTotalValue.UnboundDataType = typeof(decimal);
            this.colTransactionLineTotalValue.Visible = true;
            this.colTransactionLineTotalValue.VisibleIndex = 6;
            // 
            // btnAddTransactionLine
            // 
            this.btnAddTransactionLine.Appearance.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAddTransactionLine.Appearance.Options.UseBackColor = true;
            this.btnAddTransactionLine.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnAddTransactionLine.ImageOptions.SvgImage")));
            this.btnAddTransactionLine.ImageOptions.SvgImageSize = new System.Drawing.Size(20, 20);
            this.btnAddTransactionLine.Location = new System.Drawing.Point(173, 177);
            this.btnAddTransactionLine.Name = "btnAddTransactionLine";
            this.btnAddTransactionLine.Size = new System.Drawing.Size(75, 23);
            this.btnAddTransactionLine.TabIndex = 17;
            this.btnAddTransactionLine.Text = "New Line";
            this.btnAddTransactionLine.Click += new System.EventHandler(this.btnAddTransactionLine_Click);
            // 
            // btnCash
            // 
            this.btnCash.Appearance.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCash.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCash.Appearance.Options.UseBackColor = true;
            this.btnCash.Appearance.Options.UseFont = true;
            this.btnCash.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnCash.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnCash.ImageOptions.SvgImage")));
            this.btnCash.Location = new System.Drawing.Point(596, 14);
            this.btnCash.Name = "btnCash";
            this.btnCash.Size = new System.Drawing.Size(103, 66);
            this.btnCash.TabIndex = 18;
            this.btnCash.Text = "Cash";
            this.btnCash.Click += new System.EventHandler(this.btnCash_Click);
            // 
            // btnCard
            // 
            this.btnCard.Appearance.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCard.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCard.Appearance.Options.UseBackColor = true;
            this.btnCard.Appearance.Options.UseFont = true;
            this.btnCard.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnCard.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnCard.ImageOptions.SvgImage")));
            this.btnCard.Location = new System.Drawing.Point(596, 86);
            this.btnCard.Name = "btnCard";
            this.btnCard.Size = new System.Drawing.Size(103, 66);
            this.btnCard.TabIndex = 19;
            this.btnCard.Text = "Card";
            this.btnCard.Click += new System.EventHandler(this.btnCard_Click);
            // 
            // btnDeleteTransactionLine
            // 
            this.btnDeleteTransactionLine.Appearance.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDeleteTransactionLine.Appearance.Options.UseBackColor = true;
            this.btnDeleteTransactionLine.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDeleteTransactionLine.ImageOptions.SvgImage")));
            this.btnDeleteTransactionLine.ImageOptions.SvgImageSize = new System.Drawing.Size(20, 20);
            this.btnDeleteTransactionLine.Location = new System.Drawing.Point(254, 177);
            this.btnDeleteTransactionLine.Name = "btnDeleteTransactionLine";
            this.btnDeleteTransactionLine.Size = new System.Drawing.Size(93, 23);
            this.btnDeleteTransactionLine.TabIndex = 20;
            this.btnDeleteTransactionLine.Text = "Delete Line";
            this.btnDeleteTransactionLine.Click += new System.EventHandler(this.btnDeleteTransactionLine_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.White;
            this.panelControl1.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.panelControl1.Appearance.ForeColor = System.Drawing.Color.Black;
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.Appearance.Options.UseBorderColor = true;
            this.panelControl1.Appearance.Options.UseForeColor = true;
            this.panelControl1.Controls.Add(this.labelControl5);
            this.panelControl1.Controls.Add(this.inputTransactionTotalQuantity);
            this.panelControl1.Controls.Add(this.labelControl4);
            this.panelControl1.Controls.Add(this.inputTransactionNetValue);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.inputTransactionTotalDiscount);
            this.panelControl1.Controls.Add(this.labelTransactionTotalValue);
            this.panelControl1.Controls.Add(this.inputTransactionTotalValue);
            this.panelControl1.Location = new System.Drawing.Point(391, 14);
            this.panelControl1.LookAndFeel.SkinMaskColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelControl1.LookAndFeel.SkinMaskColor2 = System.Drawing.SystemColors.ActiveCaption;
            this.panelControl1.LookAndFeel.SkinName = "Office 2010 Blue";
            this.panelControl1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(199, 138);
            this.panelControl1.TabIndex = 21;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(8, 16);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(52, 13);
            this.labelControl5.TabIndex = 15;
            this.labelControl5.Text = "Quantity:";
            // 
            // inputTransactionTotalQuantity
            // 
            this.inputTransactionTotalQuantity.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.transactionEditDtoBindingSource, "TotalValue", true));
            this.inputTransactionTotalQuantity.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.transactionEditDtoBindingSource, "TotalValue", true));
            this.inputTransactionTotalQuantity.Location = new System.Drawing.Point(115, 14);
            this.inputTransactionTotalQuantity.Name = "inputTransactionTotalQuantity";
            this.inputTransactionTotalQuantity.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.inputTransactionTotalQuantity.Properties.Appearance.Options.UseFont = true;
            this.inputTransactionTotalQuantity.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.inputTransactionTotalQuantity.Properties.ReadOnly = true;
            this.inputTransactionTotalQuantity.Size = new System.Drawing.Size(79, 18);
            this.inputTransactionTotalQuantity.TabIndex = 14;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(8, 42);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(73, 13);
            this.labelControl4.TabIndex = 13;
            this.labelControl4.Text = "Net Value(€):";
            // 
            // inputTransactionNetValue
            // 
            this.inputTransactionNetValue.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.transactionEditDtoBindingSource, "TotalValue", true));
            this.inputTransactionNetValue.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.transactionEditDtoBindingSource, "TotalValue", true));
            this.inputTransactionNetValue.Location = new System.Drawing.Point(115, 41);
            this.inputTransactionNetValue.Name = "inputTransactionNetValue";
            this.inputTransactionNetValue.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.inputTransactionNetValue.Properties.Appearance.Options.UseFont = true;
            this.inputTransactionNetValue.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.inputTransactionNetValue.Properties.ReadOnly = true;
            this.inputTransactionNetValue.Size = new System.Drawing.Size(79, 18);
            this.inputTransactionNetValue.TabIndex = 12;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(8, 68);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(101, 13);
            this.labelControl3.TabIndex = 11;
            this.labelControl3.Text = "Total Discount(€):";
            // 
            // inputTransactionTotalDiscount
            // 
            this.inputTransactionTotalDiscount.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.transactionEditDtoBindingSource, "TotalValue", true));
            this.inputTransactionTotalDiscount.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.transactionEditDtoBindingSource, "TotalValue", true));
            this.inputTransactionTotalDiscount.Location = new System.Drawing.Point(115, 65);
            this.inputTransactionTotalDiscount.Name = "inputTransactionTotalDiscount";
            this.inputTransactionTotalDiscount.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.inputTransactionTotalDiscount.Properties.Appearance.Options.UseFont = true;
            this.inputTransactionTotalDiscount.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.inputTransactionTotalDiscount.Properties.ReadOnly = true;
            this.inputTransactionTotalDiscount.Size = new System.Drawing.Size(79, 18);
            this.inputTransactionTotalDiscount.TabIndex = 10;
            // 
            // TransactionCreateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(711, 533);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.btnDeleteTransactionLine);
            this.Controls.Add(this.btnCard);
            this.Controls.Add(this.btnCash);
            this.Controls.Add(this.btnAddTransactionLine);
            this.Controls.Add(this.grdTransactionLines);
            this.Controls.Add(this.labelTransactionLines);
            this.Controls.Add(this.inputTransactionCustomerSurname);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.labelTransactionCustomerName);
            this.Controls.Add(this.inputTransactionCustomerName);
            this.Controls.Add(this.inputTransactionCustomerId);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelTransactionCustomerId);
            this.Controls.Add(this.inputTransactionEmployeeId);
            this.Name = "TransactionCreateForm";
            this.Text = "New Transaction";
            this.Load += new System.EventHandler(this.NewTransactionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.inputTransactionEmployeeId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionEditDtoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeListDtoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputTransactionTotalValue.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputTransactionCustomerId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerListDtoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputTransactionCustomerName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputTransactionCustomerSurname.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdTransactionLines)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvTransactionLines)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repTransactionLineItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputTransactionTotalQuantity.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputTransactionNetValue.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputTransactionTotalDiscount.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SearchLookUpEdit inputTransactionEmployeeId;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.TextEdit inputTransactionTotalValue;
        private DevExpress.XtraEditors.LabelControl labelTransactionCustomerId;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelTransactionTotalValue;
        private DevExpress.XtraEditors.TextEdit inputTransactionCustomerId;
        private BindingSource transactionEditDtoBindingSource;
        private BindingSource customerListDtoBindingSource;
        private BindingSource employeeListDtoBindingSource;
        private DevExpress.XtraEditors.TextEdit inputTransactionCustomerName;
        private DevExpress.XtraEditors.LabelControl labelTransactionCustomerName;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit inputTransactionCustomerSurname;
        private DevExpress.XtraEditors.LabelControl labelTransactionLines;
        private DevExpress.XtraGrid.GridControl grdTransactionLines;
        private DevExpress.XtraGrid.Views.Grid.GridView grvTransactionLines;
        private DevExpress.XtraGrid.Columns.GridColumn colTransactionLineItemId;
        private DevExpress.XtraGrid.Columns.GridColumn colTransactionLineQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn colTransactionLineItemPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colTransactionLineNetValue;
        private DevExpress.XtraGrid.Columns.GridColumn colTransactionLineDiscountPercent;
        private DevExpress.XtraGrid.Columns.GridColumn colTransactionLineDiscountValue;
        private DevExpress.XtraGrid.Columns.GridColumn colTransactionLineTotalValue;
        private DevExpress.XtraEditors.SimpleButton btnAddTransactionLine;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit repTransactionLineItems;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemSearchLookUpEdit1View;
        private DevExpress.XtraEditors.SimpleButton btnCash;
        private DevExpress.XtraEditors.SimpleButton btnCard;
        private DevExpress.XtraEditors.SimpleButton btnDeleteTransactionLine;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit inputTransactionTotalQuantity;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit inputTransactionNetValue;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit inputTransactionTotalDiscount;
    }
}