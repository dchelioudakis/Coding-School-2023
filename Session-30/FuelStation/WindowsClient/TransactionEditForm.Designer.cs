namespace WindowsClient {
    partial class TransactionEditForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransactionEditForm));
            this.transactionEditDtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnDeleteTransactionLine = new DevExpress.XtraEditors.SimpleButton();
            this.btnAddTransactionLine = new DevExpress.XtraEditors.SimpleButton();
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
            this.labelTransactionLines = new DevExpress.XtraEditors.LabelControl();
            this.inputTransactionCustomerSurname = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelTransactionCustomerName = new DevExpress.XtraEditors.LabelControl();
            this.inputTransactionCustomerName = new DevExpress.XtraEditors.TextEdit();
            this.inputTransactionCustomerCard = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelTransactionCustomerId = new DevExpress.XtraEditors.LabelControl();
            this.inputTransactionEmployeeId = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.comboBoxPaymentMethod = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelPaymentMethod = new DevExpress.XtraEditors.LabelControl();
            this.inputTransactionDate = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.btnSaveChanges = new DevExpress.XtraEditors.SimpleButton();
            this.labelTransactionTotalValue = new DevExpress.XtraEditors.LabelControl();
            this.inputTransactionTotalValue = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionEditDtoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdTransactionLines)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvTransactionLines)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repTransactionLineItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputTransactionCustomerSurname.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputTransactionCustomerName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputTransactionCustomerCard.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputTransactionEmployeeId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxPaymentMethod.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputTransactionDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputTransactionTotalValue.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // transactionEditDtoBindingSource
            // 
            this.transactionEditDtoBindingSource.DataSource = typeof(FuelStation.Blazor.Shared.DTO.Transaction.TransactionEditDto);
            // 
            // btnDeleteTransactionLine
            // 
            this.btnDeleteTransactionLine.Appearance.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDeleteTransactionLine.Appearance.Options.UseBackColor = true;
            this.btnDeleteTransactionLine.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDeleteTransactionLine.ImageOptions.SvgImage")));
            this.btnDeleteTransactionLine.ImageOptions.SvgImageSize = new System.Drawing.Size(20, 20);
            this.btnDeleteTransactionLine.Location = new System.Drawing.Point(223, 161);
            this.btnDeleteTransactionLine.Name = "btnDeleteTransactionLine";
            this.btnDeleteTransactionLine.Size = new System.Drawing.Size(93, 23);
            this.btnDeleteTransactionLine.TabIndex = 35;
            this.btnDeleteTransactionLine.Text = "Delete Line";
            this.btnDeleteTransactionLine.Click += new System.EventHandler(this.btnDeleteTransactionLine_Click);
            // 
            // btnAddTransactionLine
            // 
            this.btnAddTransactionLine.Appearance.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAddTransactionLine.Appearance.Options.UseBackColor = true;
            this.btnAddTransactionLine.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnAddTransactionLine.ImageOptions.SvgImage")));
            this.btnAddTransactionLine.ImageOptions.SvgImageSize = new System.Drawing.Size(20, 20);
            this.btnAddTransactionLine.Location = new System.Drawing.Point(142, 161);
            this.btnAddTransactionLine.Name = "btnAddTransactionLine";
            this.btnAddTransactionLine.Size = new System.Drawing.Size(75, 23);
            this.btnAddTransactionLine.TabIndex = 32;
            this.btnAddTransactionLine.Text = "New Line";
            this.btnAddTransactionLine.Click += new System.EventHandler(this.btnAddTransactionLine_Click);
            // 
            // grdTransactionLines
            // 
            this.grdTransactionLines.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdTransactionLines.Location = new System.Drawing.Point(11, 190);
            this.grdTransactionLines.MainView = this.grvTransactionLines;
            this.grdTransactionLines.Name = "grdTransactionLines";
            this.grdTransactionLines.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repTransactionLineItems});
            this.grdTransactionLines.Size = new System.Drawing.Size(776, 293);
            this.grdTransactionLines.TabIndex = 31;
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
            // labelTransactionLines
            // 
            this.labelTransactionLines.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTransactionLines.Appearance.Options.UseFont = true;
            this.labelTransactionLines.Location = new System.Drawing.Point(11, 161);
            this.labelTransactionLines.Name = "labelTransactionLines";
            this.labelTransactionLines.Size = new System.Drawing.Size(123, 19);
            this.labelTransactionLines.TabIndex = 30;
            this.labelTransactionLines.Text = "Transaction Lines";
            // 
            // inputTransactionCustomerSurname
            // 
            this.inputTransactionCustomerSurname.Enabled = false;
            this.inputTransactionCustomerSurname.Location = new System.Drawing.Point(179, 76);
            this.inputTransactionCustomerSurname.Name = "inputTransactionCustomerSurname";
            this.inputTransactionCustomerSurname.Properties.ReadOnly = true;
            this.inputTransactionCustomerSurname.Size = new System.Drawing.Size(162, 20);
            this.inputTransactionCustomerSurname.TabIndex = 29;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(179, 57);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(91, 13);
            this.labelControl1.TabIndex = 28;
            this.labelControl1.Text = "Customer Surname";
            // 
            // labelTransactionCustomerName
            // 
            this.labelTransactionCustomerName.Location = new System.Drawing.Point(11, 57);
            this.labelTransactionCustomerName.Name = "labelTransactionCustomerName";
            this.labelTransactionCustomerName.Size = new System.Drawing.Size(76, 13);
            this.labelTransactionCustomerName.TabIndex = 27;
            this.labelTransactionCustomerName.Text = "Customer Name";
            // 
            // inputTransactionCustomerName
            // 
            this.inputTransactionCustomerName.Enabled = false;
            this.inputTransactionCustomerName.Location = new System.Drawing.Point(12, 76);
            this.inputTransactionCustomerName.Name = "inputTransactionCustomerName";
            this.inputTransactionCustomerName.Properties.ReadOnly = true;
            this.inputTransactionCustomerName.Size = new System.Drawing.Size(161, 20);
            this.inputTransactionCustomerName.TabIndex = 26;
            // 
            // inputTransactionCustomerCard
            // 
            this.inputTransactionCustomerCard.Location = new System.Drawing.Point(11, 28);
            this.inputTransactionCustomerCard.Name = "inputTransactionCustomerCard";
            this.inputTransactionCustomerCard.Size = new System.Drawing.Size(161, 20);
            this.inputTransactionCustomerCard.TabIndex = 25;
            this.inputTransactionCustomerCard.KeyDown += new System.Windows.Forms.KeyEventHandler(this.inputTransactionCustomerId_KeyDown);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(607, 9);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(46, 13);
            this.labelControl2.TabIndex = 24;
            this.labelControl2.Text = "Employee";
            // 
            // labelTransactionCustomerId
            // 
            this.labelTransactionCustomerId.Location = new System.Drawing.Point(11, 9);
            this.labelTransactionCustomerId.Name = "labelTransactionCustomerId";
            this.labelTransactionCustomerId.Size = new System.Drawing.Size(112, 13);
            this.labelTransactionCustomerId.TabIndex = 23;
            this.labelTransactionCustomerId.Text = "Customer Card Number";
            // 
            // inputTransactionEmployeeId
            // 
            this.inputTransactionEmployeeId.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.transactionEditDtoBindingSource, "EmployeeId", true));
            this.inputTransactionEmployeeId.Location = new System.Drawing.Point(607, 28);
            this.inputTransactionEmployeeId.Name = "inputTransactionEmployeeId";
            this.inputTransactionEmployeeId.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.inputTransactionEmployeeId.Properties.PopupView = this.gridView1;
            this.inputTransactionEmployeeId.Size = new System.Drawing.Size(161, 20);
            this.inputTransactionEmployeeId.TabIndex = 22;
            // 
            // gridView1
            // 
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // comboBoxPaymentMethod
            // 
            this.comboBoxPaymentMethod.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.transactionEditDtoBindingSource, "PaymentMethod", true));
            this.comboBoxPaymentMethod.Location = new System.Drawing.Point(389, 76);
            this.comboBoxPaymentMethod.Name = "comboBoxPaymentMethod";
            this.comboBoxPaymentMethod.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxPaymentMethod.Size = new System.Drawing.Size(174, 20);
            this.comboBoxPaymentMethod.TabIndex = 37;
            // 
            // labelPaymentMethod
            // 
            this.labelPaymentMethod.Location = new System.Drawing.Point(389, 57);
            this.labelPaymentMethod.Name = "labelPaymentMethod";
            this.labelPaymentMethod.Size = new System.Drawing.Size(81, 13);
            this.labelPaymentMethod.TabIndex = 38;
            this.labelPaymentMethod.Text = "Payment Method";
            // 
            // inputTransactionDate
            // 
            this.inputTransactionDate.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.transactionEditDtoBindingSource, "Date", true));
            this.inputTransactionDate.Enabled = false;
            this.inputTransactionDate.Location = new System.Drawing.Point(389, 28);
            this.inputTransactionDate.Name = "inputTransactionDate";
            this.inputTransactionDate.Properties.ReadOnly = true;
            this.inputTransactionDate.Size = new System.Drawing.Size(174, 20);
            this.inputTransactionDate.TabIndex = 39;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(389, 9);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(23, 13);
            this.labelControl6.TabIndex = 40;
            this.labelControl6.Text = "Date";
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Location = new System.Drawing.Point(11, 122);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(75, 23);
            this.btnSaveChanges.TabIndex = 41;
            this.btnSaveChanges.Text = "Save";
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // labelTransactionTotalValue
            // 
            this.labelTransactionTotalValue.Appearance.Options.UseFont = true;
            this.labelTransactionTotalValue.Location = new System.Drawing.Point(607, 57);
            this.labelTransactionTotalValue.Name = "labelTransactionTotalValue";
            this.labelTransactionTotalValue.Size = new System.Drawing.Size(42, 13);
            this.labelTransactionTotalValue.TabIndex = 43;
            this.labelTransactionTotalValue.Text = "Total(€):";
            // 
            // inputTransactionTotalValue
            // 
            this.inputTransactionTotalValue.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.transactionEditDtoBindingSource, "TotalValue", true));
            this.inputTransactionTotalValue.Enabled = false;
            this.inputTransactionTotalValue.Location = new System.Drawing.Point(607, 76);
            this.inputTransactionTotalValue.Name = "inputTransactionTotalValue";
            this.inputTransactionTotalValue.Properties.Appearance.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.inputTransactionTotalValue.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inputTransactionTotalValue.Properties.Appearance.Options.UseBackColor = true;
            this.inputTransactionTotalValue.Properties.Appearance.Options.UseFont = true;
            this.inputTransactionTotalValue.Properties.ReadOnly = true;
            this.inputTransactionTotalValue.Size = new System.Drawing.Size(161, 20);
            this.inputTransactionTotalValue.TabIndex = 42;
            // 
            // TransactionEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 495);
            this.Controls.Add(this.labelTransactionTotalValue);
            this.Controls.Add(this.inputTransactionTotalValue);
            this.Controls.Add(this.btnSaveChanges);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.inputTransactionDate);
            this.Controls.Add(this.labelPaymentMethod);
            this.Controls.Add(this.comboBoxPaymentMethod);
            this.Controls.Add(this.btnDeleteTransactionLine);
            this.Controls.Add(this.btnAddTransactionLine);
            this.Controls.Add(this.grdTransactionLines);
            this.Controls.Add(this.labelTransactionLines);
            this.Controls.Add(this.inputTransactionCustomerSurname);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.labelTransactionCustomerName);
            this.Controls.Add(this.inputTransactionCustomerName);
            this.Controls.Add(this.inputTransactionCustomerCard);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelTransactionCustomerId);
            this.Controls.Add(this.inputTransactionEmployeeId);
            this.Name = "TransactionEditForm";
            this.Text = "TransactionEditForm";
            this.Load += new System.EventHandler(this.TransactionEditForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.transactionEditDtoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdTransactionLines)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvTransactionLines)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repTransactionLineItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputTransactionCustomerSurname.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputTransactionCustomerName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputTransactionCustomerCard.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputTransactionEmployeeId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxPaymentMethod.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputTransactionDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputTransactionTotalValue.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton btnDeleteTransactionLine;
        private DevExpress.XtraEditors.SimpleButton btnAddTransactionLine;
        private DevExpress.XtraGrid.GridControl grdTransactionLines;
        private DevExpress.XtraGrid.Views.Grid.GridView grvTransactionLines;
        private DevExpress.XtraGrid.Columns.GridColumn colTransactionLineItemId;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit repTransactionLineItems;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemSearchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colTransactionLineQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn colTransactionLineItemPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colTransactionLineNetValue;
        private DevExpress.XtraGrid.Columns.GridColumn colTransactionLineDiscountPercent;
        private DevExpress.XtraGrid.Columns.GridColumn colTransactionLineDiscountValue;
        private DevExpress.XtraGrid.Columns.GridColumn colTransactionLineTotalValue;
        private DevExpress.XtraEditors.LabelControl labelTransactionLines;
        private DevExpress.XtraEditors.TextEdit inputTransactionCustomerSurname;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelTransactionCustomerName;
        private DevExpress.XtraEditors.TextEdit inputTransactionCustomerName;
        private DevExpress.XtraEditors.TextEdit inputTransactionCustomerCard;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelTransactionCustomerId;
        private DevExpress.XtraEditors.SearchLookUpEdit inputTransactionEmployeeId;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxPaymentMethod;
        private DevExpress.XtraEditors.LabelControl labelPaymentMethod;
        private BindingSource transactionEditDtoBindingSource;
        private DevExpress.XtraEditors.TextEdit inputTransactionDate;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.SimpleButton btnSaveChanges;
        private DevExpress.XtraEditors.LabelControl labelTransactionTotalValue;
        private DevExpress.XtraEditors.TextEdit inputTransactionTotalValue;
    }
}