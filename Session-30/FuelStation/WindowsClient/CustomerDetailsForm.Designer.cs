namespace WindowsClient {
    partial class CustomerDetailsForm {
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
            this.inputCustomerName = new DevExpress.XtraEditors.TextEdit();
            this.labelCustomerName = new DevExpress.XtraEditors.LabelControl();
            this.labelCustomerSurname = new DevExpress.XtraEditors.LabelControl();
            this.inputCustomerSurname = new DevExpress.XtraEditors.TextEdit();
            this.labelCardNumber = new DevExpress.XtraEditors.LabelControl();
            this.inputCustomerCardNumber = new DevExpress.XtraEditors.TextEdit();
            this.customerDetailsDtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grdTransactions = new DevExpress.XtraGrid.GridControl();
            this.grvTransactions = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTransactionEmployeeId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repEmployees = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTransactionDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTransactionPaymentMethod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTransactionTotalValue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.inputCustomerName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputCustomerSurname.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputCustomerCardNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerDetailsDtoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdTransactions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvTransactions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repEmployees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            this.SuspendLayout();
            // 
            // inputCustomerName
            // 
            this.inputCustomerName.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.customerDetailsDtoBindingSource, "Name", true));
            this.inputCustomerName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerDetailsDtoBindingSource, "Name", true));
            this.inputCustomerName.Location = new System.Drawing.Point(74, 19);
            this.inputCustomerName.Name = "inputCustomerName";
            this.inputCustomerName.Properties.Appearance.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.inputCustomerName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inputCustomerName.Properties.Appearance.Options.UseBackColor = true;
            this.inputCustomerName.Properties.Appearance.Options.UseFont = true;
            this.inputCustomerName.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.inputCustomerName.Size = new System.Drawing.Size(132, 20);
            this.inputCustomerName.TabIndex = 0;
            // 
            // labelCustomerName
            // 
            this.labelCustomerName.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCustomerName.Appearance.Options.UseFont = true;
            this.labelCustomerName.Location = new System.Drawing.Point(30, 20);
            this.labelCustomerName.Name = "labelCustomerName";
            this.labelCustomerName.Size = new System.Drawing.Size(38, 16);
            this.labelCustomerName.TabIndex = 1;
            this.labelCustomerName.Text = "Name:";
            // 
            // labelCustomerSurname
            // 
            this.labelCustomerSurname.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCustomerSurname.Appearance.Options.UseFont = true;
            this.labelCustomerSurname.Location = new System.Drawing.Point(257, 20);
            this.labelCustomerSurname.Name = "labelCustomerSurname";
            this.labelCustomerSurname.Size = new System.Drawing.Size(57, 16);
            this.labelCustomerSurname.TabIndex = 3;
            this.labelCustomerSurname.Text = "Surname:";
            // 
            // inputCustomerSurname
            // 
            this.inputCustomerSurname.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.customerDetailsDtoBindingSource, "Surname", true));
            this.inputCustomerSurname.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerDetailsDtoBindingSource, "Surname", true));
            this.inputCustomerSurname.Location = new System.Drawing.Point(320, 18);
            this.inputCustomerSurname.Name = "inputCustomerSurname";
            this.inputCustomerSurname.Properties.Appearance.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.inputCustomerSurname.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inputCustomerSurname.Properties.Appearance.Options.UseBackColor = true;
            this.inputCustomerSurname.Properties.Appearance.Options.UseFont = true;
            this.inputCustomerSurname.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.inputCustomerSurname.Size = new System.Drawing.Size(143, 20);
            this.inputCustomerSurname.TabIndex = 2;
            // 
            // labelCardNumber
            // 
            this.labelCardNumber.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCardNumber.Appearance.Options.UseFont = true;
            this.labelCardNumber.Location = new System.Drawing.Point(506, 20);
            this.labelCardNumber.Name = "labelCardNumber";
            this.labelCardNumber.Size = new System.Drawing.Size(76, 16);
            this.labelCardNumber.TabIndex = 5;
            this.labelCardNumber.Text = "Card Number";
            // 
            // inputCustomerCardNumber
            // 
            this.inputCustomerCardNumber.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.customerDetailsDtoBindingSource, "CardNumber", true));
            this.inputCustomerCardNumber.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerDetailsDtoBindingSource, "CardNumber", true));
            this.inputCustomerCardNumber.Location = new System.Drawing.Point(588, 19);
            this.inputCustomerCardNumber.Name = "inputCustomerCardNumber";
            this.inputCustomerCardNumber.Properties.Appearance.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.inputCustomerCardNumber.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inputCustomerCardNumber.Properties.Appearance.Options.UseBackColor = true;
            this.inputCustomerCardNumber.Properties.Appearance.Options.UseFont = true;
            this.inputCustomerCardNumber.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.inputCustomerCardNumber.Size = new System.Drawing.Size(161, 20);
            this.inputCustomerCardNumber.TabIndex = 4;
            // 
            // customerDetailsDtoBindingSource
            // 
            this.customerDetailsDtoBindingSource.DataSource = typeof(FuelStation.Blazor.Shared.DTO.Customer.CustomerDetailsDto);
            // 
            // grdTransactions
            // 
            this.grdTransactions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdTransactions.Location = new System.Drawing.Point(12, 141);
            this.grdTransactions.MainView = this.grvTransactions;
            this.grdTransactions.Name = "grdTransactions";
            this.grdTransactions.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repEmployees});
            this.grdTransactions.Size = new System.Drawing.Size(776, 297);
            this.grdTransactions.TabIndex = 6;
            this.grdTransactions.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvTransactions});
            // 
            // grvTransactions
            // 
            this.grvTransactions.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
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
            // colTransactionEmployeeId
            // 
            this.colTransactionEmployeeId.Caption = "Employee";
            this.colTransactionEmployeeId.ColumnEdit = this.repEmployees;
            this.colTransactionEmployeeId.FieldName = "EmployeeId";
            this.colTransactionEmployeeId.Name = "colTransactionEmployeeId";
            this.colTransactionEmployeeId.Visible = true;
            this.colTransactionEmployeeId.VisibleIndex = 0;
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
            this.colTransactionDate.VisibleIndex = 1;
            // 
            // colTransactionPaymentMethod
            // 
            this.colTransactionPaymentMethod.Caption = "Payment Method";
            this.colTransactionPaymentMethod.FieldName = "PaymentMethod";
            this.colTransactionPaymentMethod.Name = "colTransactionPaymentMethod";
            this.colTransactionPaymentMethod.Visible = true;
            this.colTransactionPaymentMethod.VisibleIndex = 2;
            // 
            // colTransactionTotalValue
            // 
            this.colTransactionTotalValue.Caption = "Total";
            this.colTransactionTotalValue.FieldName = "TotalValue";
            this.colTransactionTotalValue.Name = "colTransactionTotalValue";
            this.colTransactionTotalValue.Visible = true;
            this.colTransactionTotalValue.VisibleIndex = 3;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(12, 107);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(171, 18);
            this.labelControl1.TabIndex = 7;
            this.labelControl1.Text = "Customer Transactions";
            // 
            // CustomerDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.grdTransactions);
            this.Controls.Add(this.labelCardNumber);
            this.Controls.Add(this.inputCustomerCardNumber);
            this.Controls.Add(this.labelCustomerSurname);
            this.Controls.Add(this.inputCustomerSurname);
            this.Controls.Add(this.labelCustomerName);
            this.Controls.Add(this.inputCustomerName);
            this.Name = "CustomerDetailsForm";
            this.Text = "Customer Details";
            this.Load += new System.EventHandler(this.CustomerDetailsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.inputCustomerName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputCustomerSurname.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputCustomerCardNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerDetailsDtoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdTransactions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvTransactions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repEmployees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit inputCustomerName;
        private DevExpress.XtraEditors.LabelControl labelCustomerName;
        private BindingSource customerDetailsDtoBindingSource;
        private DevExpress.XtraEditors.LabelControl labelCustomerSurname;
        private DevExpress.XtraEditors.TextEdit inputCustomerSurname;
        private DevExpress.XtraEditors.LabelControl labelCardNumber;
        private DevExpress.XtraEditors.TextEdit inputCustomerCardNumber;
        private DevExpress.XtraGrid.GridControl grdTransactions;
        private DevExpress.XtraGrid.Views.Grid.GridView grvTransactions;
        private DevExpress.XtraGrid.Columns.GridColumn colTransactionEmployeeId;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repEmployees;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colTransactionDate;
        private DevExpress.XtraGrid.Columns.GridColumn colTransactionPaymentMethod;
        private DevExpress.XtraGrid.Columns.GridColumn colTransactionTotalValue;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}