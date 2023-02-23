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
            this.inputTransactionDate = new DevExpress.XtraEditors.TextEdit();
            this.labelTransactionCustomerId = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelTransactionDate = new DevExpress.XtraEditors.LabelControl();
            this.labelTransactionTotalValue = new DevExpress.XtraEditors.LabelControl();
            this.inputTransactionCustomerId = new DevExpress.XtraEditors.TextEdit();
            this.customerListDtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inputTransactionCustomerName = new DevExpress.XtraEditors.TextEdit();
            this.labelTransactionCustomerName = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.inputTransactionCustomerSurname = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.inputTransactionEmployeeId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionEditDtoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeListDtoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputTransactionTotalValue.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputTransactionDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputTransactionCustomerId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerListDtoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputTransactionCustomerName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputTransactionCustomerSurname.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // inputTransactionEmployeeId
            // 
            this.inputTransactionEmployeeId.DataBindings.Add(new System.Windows.Forms.Binding("DataContext", this.transactionEditDtoBindingSource, "EmployeeId", true));
            this.inputTransactionEmployeeId.Location = new System.Drawing.Point(261, 31);
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
            this.inputTransactionTotalValue.DataBindings.Add(new System.Windows.Forms.Binding("DataContext", this.transactionEditDtoBindingSource, "TotalValue", true));
            this.inputTransactionTotalValue.Location = new System.Drawing.Point(592, 76);
            this.inputTransactionTotalValue.Name = "inputTransactionTotalValue";
            this.inputTransactionTotalValue.Properties.ReadOnly = true;
            this.inputTransactionTotalValue.Size = new System.Drawing.Size(100, 20);
            this.inputTransactionTotalValue.TabIndex = 3;
            // 
            // inputTransactionDate
            // 
            this.inputTransactionDate.DataBindings.Add(new System.Windows.Forms.Binding("DataContext", this.transactionEditDtoBindingSource, "Date", true));
            this.inputTransactionDate.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.transactionEditDtoBindingSource, "Date", true));
            this.inputTransactionDate.EditValue = new System.DateTime(2023, 2, 1, 12, 11, 45, 0);
            this.inputTransactionDate.Location = new System.Drawing.Point(12, 31);
            this.inputTransactionDate.Name = "inputTransactionDate";
            this.inputTransactionDate.Properties.ReadOnly = true;
            this.inputTransactionDate.Size = new System.Drawing.Size(100, 20);
            this.inputTransactionDate.TabIndex = 4;
            // 
            // labelTransactionCustomerId
            // 
            this.labelTransactionCustomerId.Location = new System.Drawing.Point(12, 57);
            this.labelTransactionCustomerId.Name = "labelTransactionCustomerId";
            this.labelTransactionCustomerId.Size = new System.Drawing.Size(112, 13);
            this.labelTransactionCustomerId.TabIndex = 5;
            this.labelTransactionCustomerId.Text = "Customer Card Number";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(261, 12);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(46, 13);
            this.labelControl2.TabIndex = 6;
            this.labelControl2.Text = "Employee";
            // 
            // labelTransactionDate
            // 
            this.labelTransactionDate.Location = new System.Drawing.Point(12, 12);
            this.labelTransactionDate.Name = "labelTransactionDate";
            this.labelTransactionDate.Size = new System.Drawing.Size(23, 13);
            this.labelTransactionDate.TabIndex = 8;
            this.labelTransactionDate.Text = "Date";
            // 
            // labelTransactionTotalValue
            // 
            this.labelTransactionTotalValue.Location = new System.Drawing.Point(592, 57);
            this.labelTransactionTotalValue.Name = "labelTransactionTotalValue";
            this.labelTransactionTotalValue.Size = new System.Drawing.Size(24, 13);
            this.labelTransactionTotalValue.TabIndex = 9;
            this.labelTransactionTotalValue.Text = "Total";
            // 
            // inputTransactionCustomerId
            // 
            this.inputTransactionCustomerId.DataBindings.Add(new System.Windows.Forms.Binding("DataContext", this.transactionEditDtoBindingSource, "CustomerId", true));
            this.inputTransactionCustomerId.Location = new System.Drawing.Point(12, 76);
            this.inputTransactionCustomerId.Name = "inputTransactionCustomerId";
            this.inputTransactionCustomerId.Size = new System.Drawing.Size(148, 20);
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
            this.inputTransactionCustomerName.Location = new System.Drawing.Point(206, 76);
            this.inputTransactionCustomerName.Name = "inputTransactionCustomerName";
            this.inputTransactionCustomerName.Properties.ReadOnly = true;
            this.inputTransactionCustomerName.Size = new System.Drawing.Size(148, 20);
            this.inputTransactionCustomerName.TabIndex = 11;
            // 
            // labelTransactionCustomerName
            // 
            this.labelTransactionCustomerName.Location = new System.Drawing.Point(206, 57);
            this.labelTransactionCustomerName.Name = "labelTransactionCustomerName";
            this.labelTransactionCustomerName.Size = new System.Drawing.Size(76, 13);
            this.labelTransactionCustomerName.TabIndex = 12;
            this.labelTransactionCustomerName.Text = "Customer Name";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(387, 57);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(91, 13);
            this.labelControl1.TabIndex = 13;
            this.labelControl1.Text = "Customer Surname";
            // 
            // inputTransactionCustomerSurname
            // 
            this.inputTransactionCustomerSurname.DataBindings.Add(new System.Windows.Forms.Binding("DataContext", this.transactionEditDtoBindingSource, "CustomerId", true));
            this.inputTransactionCustomerSurname.Location = new System.Drawing.Point(387, 76);
            this.inputTransactionCustomerSurname.Name = "inputTransactionCustomerSurname";
            this.inputTransactionCustomerSurname.Properties.ReadOnly = true;
            this.inputTransactionCustomerSurname.Size = new System.Drawing.Size(148, 20);
            this.inputTransactionCustomerSurname.TabIndex = 14;
            // 
            // NewTransactionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 450);
            this.Controls.Add(this.inputTransactionCustomerSurname);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.labelTransactionCustomerName);
            this.Controls.Add(this.inputTransactionCustomerName);
            this.Controls.Add(this.inputTransactionCustomerId);
            this.Controls.Add(this.labelTransactionTotalValue);
            this.Controls.Add(this.labelTransactionDate);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelTransactionCustomerId);
            this.Controls.Add(this.inputTransactionDate);
            this.Controls.Add(this.inputTransactionTotalValue);
            this.Controls.Add(this.inputTransactionEmployeeId);
            this.Name = "NewTransactionForm";
            this.Text = "NewTransactionForm";
            this.Load += new System.EventHandler(this.NewTransactionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.inputTransactionEmployeeId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionEditDtoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeListDtoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputTransactionTotalValue.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputTransactionDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputTransactionCustomerId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerListDtoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputTransactionCustomerName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputTransactionCustomerSurname.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SearchLookUpEdit inputTransactionEmployeeId;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.TextEdit inputTransactionTotalValue;
        private DevExpress.XtraEditors.TextEdit inputTransactionDate;
        private DevExpress.XtraEditors.LabelControl labelTransactionCustomerId;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelTransactionDate;
        private DevExpress.XtraEditors.LabelControl labelTransactionTotalValue;
        private DevExpress.XtraEditors.TextEdit inputTransactionCustomerId;
        private BindingSource transactionEditDtoBindingSource;
        private BindingSource customerListDtoBindingSource;
        private BindingSource employeeListDtoBindingSource;
        private DevExpress.XtraEditors.TextEdit inputTransactionCustomerName;
        private DevExpress.XtraEditors.LabelControl labelTransactionCustomerName;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit inputTransactionCustomerSurname;
    }
}