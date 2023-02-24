namespace WindowsClient {
    partial class NewTransactionForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewTransactionForm));
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
            this.SuspendLayout();
            // 
            // inputTransactionEmployeeId
            // 
            this.inputTransactionEmployeeId.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.transactionEditDtoBindingSource, "EmployeeId", true));
            this.inputTransactionEmployeeId.Location = new System.Drawing.Point(12, 30);
            this.inputTransactionEmployeeId.Name = "inputTransactionEmployeeId";
            this.inputTransactionEmployeeId.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.inputTransactionEmployeeId.Properties.PopupView = this.gridView1;
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
            this.inputTransactionTotalValue.Location = new System.Drawing.Point(449, 40);
            this.inputTransactionTotalValue.Name = "inputTransactionTotalValue";
            this.inputTransactionTotalValue.Properties.ReadOnly = true;
            this.inputTransactionTotalValue.Size = new System.Drawing.Size(100, 20);
            this.inputTransactionTotalValue.TabIndex = 3;
            // 
            // labelTransactionCustomerId
            // 
            this.labelTransactionCustomerId.Location = new System.Drawing.Point(12, 56);
            this.labelTransactionCustomerId.Name = "labelTransactionCustomerId";
            this.labelTransactionCustomerId.Size = new System.Drawing.Size(112, 13);
            this.labelTransactionCustomerId.TabIndex = 5;
            this.labelTransactionCustomerId.Text = "Customer Card Number";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 11);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(46, 13);
            this.labelControl2.TabIndex = 6;
            this.labelControl2.Text = "Employee";
            // 
            // labelTransactionTotalValue
            // 
            this.labelTransactionTotalValue.Location = new System.Drawing.Point(419, 43);
            this.labelTransactionTotalValue.Name = "labelTransactionTotalValue";
            this.labelTransactionTotalValue.Size = new System.Drawing.Size(24, 13);
            this.labelTransactionTotalValue.TabIndex = 9;
            this.labelTransactionTotalValue.Text = "Total";
            // 
            // inputTransactionCustomerId
            // 
            this.inputTransactionCustomerId.Location = new System.Drawing.Point(12, 75);
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
            this.inputTransactionCustomerName.Location = new System.Drawing.Point(12, 120);
            this.inputTransactionCustomerName.Name = "inputTransactionCustomerName";
            this.inputTransactionCustomerName.Properties.ReadOnly = true;
            this.inputTransactionCustomerName.Size = new System.Drawing.Size(161, 20);
            this.inputTransactionCustomerName.TabIndex = 11;
            // 
            // labelTransactionCustomerName
            // 
            this.labelTransactionCustomerName.Location = new System.Drawing.Point(12, 101);
            this.labelTransactionCustomerName.Name = "labelTransactionCustomerName";
            this.labelTransactionCustomerName.Size = new System.Drawing.Size(76, 13);
            this.labelTransactionCustomerName.TabIndex = 12;
            this.labelTransactionCustomerName.Text = "Customer Name";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(185, 101);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(91, 13);
            this.labelControl1.TabIndex = 13;
            this.labelControl1.Text = "Customer Surname";
            // 
            // inputTransactionCustomerSurname
            // 
            this.inputTransactionCustomerSurname.DataBindings.Add(new System.Windows.Forms.Binding("DataContext", this.transactionEditDtoBindingSource, "CustomerId", true));
            this.inputTransactionCustomerSurname.Location = new System.Drawing.Point(185, 120);
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
            this.btnAddTransactionLine.Location = new System.Drawing.Point(168, 177);
            this.btnAddTransactionLine.Name = "btnAddTransactionLine";
            this.btnAddTransactionLine.Size = new System.Drawing.Size(75, 23);
            this.btnAddTransactionLine.TabIndex = 17;
            this.btnAddTransactionLine.Text = "Add Line";
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
            this.btnCash.Location = new System.Drawing.Point(596, 33);
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
            this.btnCard.Location = new System.Drawing.Point(596, 105);
            this.btnCard.Name = "btnCard";
            this.btnCard.Size = new System.Drawing.Size(103, 66);
            this.btnCard.TabIndex = 19;
            this.btnCard.Text = "Card";
            this.btnCard.Click += new System.EventHandler(this.btnCard_Click);
            // 
            // NewTransactionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 533);
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
            this.Controls.Add(this.labelTransactionTotalValue);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelTransactionCustomerId);
            this.Controls.Add(this.inputTransactionTotalValue);
            this.Controls.Add(this.inputTransactionEmployeeId);
            this.Name = "NewTransactionForm";
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
    }
}