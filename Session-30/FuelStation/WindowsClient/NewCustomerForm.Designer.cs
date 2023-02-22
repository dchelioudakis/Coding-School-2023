namespace WindowsClient {
    partial class NewCustomerForm {
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
            this.btnNewCustomerSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancelNewCustomer = new DevExpress.XtraEditors.SimpleButton();
            this.inputCustomerName = new DevExpress.XtraEditors.TextEdit();
            this.customerEditDtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inputCustomerSurname = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.inputCustomerCardNumber = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.inputCustomerName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerEditDtoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputCustomerSurname.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputCustomerCardNumber.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNewCustomerSave
            // 
            this.btnNewCustomerSave.Location = new System.Drawing.Point(19, 195);
            this.btnNewCustomerSave.Name = "btnNewCustomerSave";
            this.btnNewCustomerSave.Size = new System.Drawing.Size(75, 23);
            this.btnNewCustomerSave.TabIndex = 0;
            this.btnNewCustomerSave.Text = "Save";
            this.btnNewCustomerSave.Click += new System.EventHandler(this.btnNewCustomerSave_Click);
            // 
            // btnCancelNewCustomer
            // 
            this.btnCancelNewCustomer.Location = new System.Drawing.Point(117, 195);
            this.btnCancelNewCustomer.Name = "btnCancelNewCustomer";
            this.btnCancelNewCustomer.Size = new System.Drawing.Size(75, 23);
            this.btnCancelNewCustomer.TabIndex = 1;
            this.btnCancelNewCustomer.Text = "Cancel";
            this.btnCancelNewCustomer.Click += new System.EventHandler(this.btnCancelNewCustomer_Click);
            // 
            // inputCustomerName
            // 
            this.inputCustomerName.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.customerEditDtoBindingSource, "Name", true));
            this.inputCustomerName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerEditDtoBindingSource, "Name", true));
            this.inputCustomerName.EditValue = "";
            this.inputCustomerName.Location = new System.Drawing.Point(19, 37);
            this.inputCustomerName.Name = "inputCustomerName";
            this.inputCustomerName.Size = new System.Drawing.Size(173, 20);
            this.inputCustomerName.TabIndex = 2;
            // 
            // customerEditDtoBindingSource
            // 
            this.customerEditDtoBindingSource.DataSource = typeof(FuelStation.Blazor.Shared.DTO.Customer.CustomerEditDto);
            // 
            // inputCustomerSurname
            // 
            this.inputCustomerSurname.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.customerEditDtoBindingSource, "Surname", true));
            this.inputCustomerSurname.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerEditDtoBindingSource, "Surname", true));
            this.inputCustomerSurname.Location = new System.Drawing.Point(19, 92);
            this.inputCustomerSurname.Name = "inputCustomerSurname";
            this.inputCustomerSurname.Size = new System.Drawing.Size(173, 20);
            this.inputCustomerSurname.TabIndex = 3;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(19, 18);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(27, 13);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "Name";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(19, 73);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(42, 13);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "Surname";
            // 
            // inputCustomerCardNumber
            // 
            this.inputCustomerCardNumber.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.customerEditDtoBindingSource, "CardNumber", true));
            this.inputCustomerCardNumber.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerEditDtoBindingSource, "CardNumber", true));
            this.inputCustomerCardNumber.Location = new System.Drawing.Point(19, 146);
            this.inputCustomerCardNumber.Name = "inputCustomerCardNumber";
            this.inputCustomerCardNumber.Size = new System.Drawing.Size(173, 20);
            this.inputCustomerCardNumber.TabIndex = 6;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(19, 127);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(63, 13);
            this.labelControl3.TabIndex = 7;
            this.labelControl3.Text = "Card Number";
            // 
            // NewCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(212, 233);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.inputCustomerCardNumber);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.inputCustomerSurname);
            this.Controls.Add(this.inputCustomerName);
            this.Controls.Add(this.btnCancelNewCustomer);
            this.Controls.Add(this.btnNewCustomerSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "NewCustomerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "New Customer";
            ((System.ComponentModel.ISupportInitialize)(this.inputCustomerName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerEditDtoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputCustomerSurname.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputCustomerCardNumber.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnNewCustomerSave;
        private DevExpress.XtraEditors.SimpleButton btnCancelNewCustomer;
        private DevExpress.XtraEditors.TextEdit inputCustomerName;
        private DevExpress.XtraEditors.TextEdit inputCustomerSurname;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit inputCustomerCardNumber;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private BindingSource customerEditDtoBindingSource;
    }
}