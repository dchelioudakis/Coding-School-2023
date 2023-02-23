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
            this.repTransactionLineItem = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colTransactionLineDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTransactionLineQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTransactionLineItemPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTransactionLineNetValue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTransactionLineDiscountPercent = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTransactionLineDiscountValue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTransactionLineTotalValue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnAddTransactionLine = new DevExpress.XtraEditors.SimpleButton();
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
            ((System.ComponentModel.ISupportInitialize)(this.repTransactionLineItem)).BeginInit();
            this.SuspendLayout();
            // 
            // inputTransactionEmployeeId
            // 
            this.inputTransactionEmployeeId.DataBindings.Add(new System.Windows.Forms.Binding("DataContext", this.transactionEditDtoBindingSource, "EmployeeId", true));
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
            this.inputTransactionTotalValue.Location = new System.Drawing.Point(592, 75);
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
            this.labelTransactionTotalValue.Location = new System.Drawing.Point(592, 56);
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
            this.inputTransactionCustomerName.Location = new System.Drawing.Point(206, 75);
            this.inputTransactionCustomerName.Name = "inputTransactionCustomerName";
            this.inputTransactionCustomerName.Properties.ReadOnly = true;
            this.inputTransactionCustomerName.Size = new System.Drawing.Size(148, 20);
            this.inputTransactionCustomerName.TabIndex = 11;
            // 
            // labelTransactionCustomerName
            // 
            this.labelTransactionCustomerName.Location = new System.Drawing.Point(206, 56);
            this.labelTransactionCustomerName.Name = "labelTransactionCustomerName";
            this.labelTransactionCustomerName.Size = new System.Drawing.Size(76, 13);
            this.labelTransactionCustomerName.TabIndex = 12;
            this.labelTransactionCustomerName.Text = "Customer Name";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(387, 56);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(91, 13);
            this.labelControl1.TabIndex = 13;
            this.labelControl1.Text = "Customer Surname";
            // 
            // inputTransactionCustomerSurname
            // 
            this.inputTransactionCustomerSurname.DataBindings.Add(new System.Windows.Forms.Binding("DataContext", this.transactionEditDtoBindingSource, "CustomerId", true));
            this.inputTransactionCustomerSurname.Location = new System.Drawing.Point(387, 75);
            this.inputTransactionCustomerSurname.Name = "inputTransactionCustomerSurname";
            this.inputTransactionCustomerSurname.Properties.ReadOnly = true;
            this.inputTransactionCustomerSurname.Size = new System.Drawing.Size(148, 20);
            this.inputTransactionCustomerSurname.TabIndex = 14;
            // 
            // labelTransactionLines
            // 
            this.labelTransactionLines.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTransactionLines.Appearance.Options.UseFont = true;
            this.labelTransactionLines.Location = new System.Drawing.Point(12, 125);
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
            this.grdTransactionLines.Location = new System.Drawing.Point(12, 150);
            this.grdTransactionLines.MainView = this.grvTransactionLines;
            this.grdTransactionLines.Name = "grdTransactionLines";
            this.grdTransactionLines.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repTransactionLineItem});
            this.grdTransactionLines.Size = new System.Drawing.Size(687, 288);
            this.grdTransactionLines.TabIndex = 16;
            this.grdTransactionLines.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvTransactionLines});
            // 
            // grvTransactionLines
            // 
            this.grvTransactionLines.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTransactionLineItemId,
            this.colTransactionLineDescription,
            this.colTransactionLineQuantity,
            this.colTransactionLineItemPrice,
            this.colTransactionLineNetValue,
            this.colTransactionLineDiscountPercent,
            this.colTransactionLineDiscountValue,
            this.colTransactionLineTotalValue});
            this.grvTransactionLines.GridControl = this.grdTransactionLines;
            this.grvTransactionLines.Name = "grvTransactionLines";
            this.grvTransactionLines.OptionsView.ShowGroupPanel = false;
            this.grvTransactionLines.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.grvTransactionLines_RowUpdated);
            // 
            // colTransactionLineItemId
            // 
            this.colTransactionLineItemId.Caption = "Item";
            this.colTransactionLineItemId.FieldName = "ItemId";
            this.colTransactionLineItemId.Name = "colTransactionLineItemId";
            this.colTransactionLineItemId.Visible = true;
            this.colTransactionLineItemId.VisibleIndex = 0;
            // 
            // repTransactionLineItem
            // 
            this.repTransactionLineItem.AutoHeight = false;
            this.repTransactionLineItem.Name = "repTransactionLineItem";
            // 
            // colTransactionLineDescription
            // 
            this.colTransactionLineDescription.Caption = "Description";
            this.colTransactionLineDescription.Name = "colTransactionLineDescription";
            this.colTransactionLineDescription.OptionsColumn.AllowEdit = false;
            this.colTransactionLineDescription.OptionsColumn.AllowFocus = false;
            this.colTransactionLineDescription.OptionsColumn.ReadOnly = true;
            this.colTransactionLineDescription.Visible = true;
            this.colTransactionLineDescription.VisibleIndex = 1;
            // 
            // colTransactionLineQuantity
            // 
            this.colTransactionLineQuantity.Caption = "Quantity";
            this.colTransactionLineQuantity.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTransactionLineQuantity.FieldName = "Quantity";
            this.colTransactionLineQuantity.Name = "colTransactionLineQuantity";
            this.colTransactionLineQuantity.Visible = true;
            this.colTransactionLineQuantity.VisibleIndex = 2;
            // 
            // colTransactionLineItemPrice
            // 
            this.colTransactionLineItemPrice.Caption = "Item Price";
            this.colTransactionLineItemPrice.FieldName = "ItemPrice";
            this.colTransactionLineItemPrice.Name = "colTransactionLineItemPrice";
            this.colTransactionLineItemPrice.OptionsColumn.AllowEdit = false;
            this.colTransactionLineItemPrice.OptionsColumn.AllowFocus = false;
            this.colTransactionLineItemPrice.OptionsColumn.ReadOnly = true;
            this.colTransactionLineItemPrice.Visible = true;
            this.colTransactionLineItemPrice.VisibleIndex = 3;
            // 
            // colTransactionLineNetValue
            // 
            this.colTransactionLineNetValue.Caption = "Net Value";
            this.colTransactionLineNetValue.FieldName = "NetValue";
            this.colTransactionLineNetValue.Name = "colTransactionLineNetValue";
            this.colTransactionLineNetValue.OptionsColumn.AllowEdit = false;
            this.colTransactionLineNetValue.OptionsColumn.AllowFocus = false;
            this.colTransactionLineNetValue.OptionsColumn.ReadOnly = true;
            this.colTransactionLineNetValue.Visible = true;
            this.colTransactionLineNetValue.VisibleIndex = 4;
            // 
            // colTransactionLineDiscountPercent
            // 
            this.colTransactionLineDiscountPercent.Caption = "Discount(%)";
            this.colTransactionLineDiscountPercent.FieldName = "DiscountPercent";
            this.colTransactionLineDiscountPercent.Name = "colTransactionLineDiscountPercent";
            this.colTransactionLineDiscountPercent.OptionsColumn.AllowEdit = false;
            this.colTransactionLineDiscountPercent.OptionsColumn.AllowFocus = false;
            this.colTransactionLineDiscountPercent.OptionsColumn.ReadOnly = true;
            this.colTransactionLineDiscountPercent.Visible = true;
            this.colTransactionLineDiscountPercent.VisibleIndex = 5;
            // 
            // colTransactionLineDiscountValue
            // 
            this.colTransactionLineDiscountValue.Caption = "Discount(€)";
            this.colTransactionLineDiscountValue.FieldName = "DiscountValue";
            this.colTransactionLineDiscountValue.Name = "colTransactionLineDiscountValue";
            this.colTransactionLineDiscountValue.OptionsColumn.AllowEdit = false;
            this.colTransactionLineDiscountValue.OptionsColumn.AllowFocus = false;
            this.colTransactionLineDiscountValue.OptionsColumn.ReadOnly = true;
            this.colTransactionLineDiscountValue.Visible = true;
            this.colTransactionLineDiscountValue.VisibleIndex = 6;
            // 
            // colTransactionLineTotalValue
            // 
            this.colTransactionLineTotalValue.Caption = "Total";
            this.colTransactionLineTotalValue.FieldName = "TotalValue";
            this.colTransactionLineTotalValue.Name = "colTransactionLineTotalValue";
            this.colTransactionLineTotalValue.OptionsColumn.AllowEdit = false;
            this.colTransactionLineTotalValue.OptionsColumn.AllowFocus = false;
            this.colTransactionLineTotalValue.OptionsColumn.ReadOnly = true;
            this.colTransactionLineTotalValue.Visible = true;
            this.colTransactionLineTotalValue.VisibleIndex = 7;
            // 
            // btnAddTransactionLine
            // 
            this.btnAddTransactionLine.Location = new System.Drawing.Point(168, 125);
            this.btnAddTransactionLine.Name = "btnAddTransactionLine";
            this.btnAddTransactionLine.Size = new System.Drawing.Size(75, 23);
            this.btnAddTransactionLine.TabIndex = 17;
            this.btnAddTransactionLine.Text = "Add Line";
            this.btnAddTransactionLine.Click += new System.EventHandler(this.btnAddTransactionLine_Click);
            // 
            // NewTransactionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 450);
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
            ((System.ComponentModel.ISupportInitialize)(this.repTransactionLineItem)).EndInit();
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
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repTransactionLineItem;
        private DevExpress.XtraGrid.Columns.GridColumn colTransactionLineDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colTransactionLineQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn colTransactionLineItemPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colTransactionLineNetValue;
        private DevExpress.XtraGrid.Columns.GridColumn colTransactionLineDiscountPercent;
        private DevExpress.XtraGrid.Columns.GridColumn colTransactionLineDiscountValue;
        private DevExpress.XtraGrid.Columns.GridColumn colTransactionLineTotalValue;
        private DevExpress.XtraEditors.SimpleButton btnAddTransactionLine;
    }
}