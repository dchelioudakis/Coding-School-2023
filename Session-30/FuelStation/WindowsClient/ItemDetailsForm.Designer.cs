namespace WindowsClient {
    partial class ItemDetailsForm {
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
            this.comboBoxItemType = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelItemCost = new DevExpress.XtraEditors.LabelControl();
            this.inputItemCost = new DevExpress.XtraEditors.TextEdit();
            this.labelItemPrice = new DevExpress.XtraEditors.LabelControl();
            this.inputItemPrice = new DevExpress.XtraEditors.TextEdit();
            this.labelItemDescription = new DevExpress.XtraEditors.LabelControl();
            this.labelItemCode = new DevExpress.XtraEditors.LabelControl();
            this.inputItemDescription = new DevExpress.XtraEditors.TextEdit();
            this.inputItemCode = new DevExpress.XtraEditors.TextEdit();
            this.btnItemDetailsClose = new DevExpress.XtraEditors.SimpleButton();
            this.itemEditDtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxItemType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputItemCost.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputItemPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputItemDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputItemCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemEditDtoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxItemType
            // 
            this.comboBoxItemType.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.itemEditDtoBindingSource, "Type", true));
            this.comboBoxItemType.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemEditDtoBindingSource, "Type", true));
            this.comboBoxItemType.Enabled = false;
            this.comboBoxItemType.Location = new System.Drawing.Point(256, 100);
            this.comboBoxItemType.Name = "comboBoxItemType";
            this.comboBoxItemType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxItemType.Size = new System.Drawing.Size(173, 20);
            this.comboBoxItemType.TabIndex = 30;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(256, 81);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(24, 13);
            this.labelControl2.TabIndex = 29;
            this.labelControl2.Text = "Type";
            // 
            // labelItemCost
            // 
            this.labelItemCost.Location = new System.Drawing.Point(256, 135);
            this.labelItemCost.Name = "labelItemCost";
            this.labelItemCost.Size = new System.Drawing.Size(22, 13);
            this.labelItemCost.TabIndex = 28;
            this.labelItemCost.Text = "Cost";
            // 
            // inputItemCost
            // 
            this.inputItemCost.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.itemEditDtoBindingSource, "Cost", true));
            this.inputItemCost.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemEditDtoBindingSource, "Cost", true));
            this.inputItemCost.Enabled = false;
            this.inputItemCost.Location = new System.Drawing.Point(256, 154);
            this.inputItemCost.Name = "inputItemCost";
            this.inputItemCost.Size = new System.Drawing.Size(173, 20);
            this.inputItemCost.TabIndex = 27;
            // 
            // labelItemPrice
            // 
            this.labelItemPrice.Location = new System.Drawing.Point(49, 135);
            this.labelItemPrice.Name = "labelItemPrice";
            this.labelItemPrice.Size = new System.Drawing.Size(23, 13);
            this.labelItemPrice.TabIndex = 26;
            this.labelItemPrice.Text = "Price";
            // 
            // inputItemPrice
            // 
            this.inputItemPrice.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.itemEditDtoBindingSource, "Price", true));
            this.inputItemPrice.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemEditDtoBindingSource, "Price", true));
            this.inputItemPrice.Enabled = false;
            this.inputItemPrice.Location = new System.Drawing.Point(49, 154);
            this.inputItemPrice.Name = "inputItemPrice";
            this.inputItemPrice.Size = new System.Drawing.Size(173, 20);
            this.inputItemPrice.TabIndex = 25;
            // 
            // labelItemDescription
            // 
            this.labelItemDescription.Location = new System.Drawing.Point(49, 81);
            this.labelItemDescription.Name = "labelItemDescription";
            this.labelItemDescription.Size = new System.Drawing.Size(53, 13);
            this.labelItemDescription.TabIndex = 24;
            this.labelItemDescription.Text = "Description";
            // 
            // labelItemCode
            // 
            this.labelItemCode.Location = new System.Drawing.Point(172, 23);
            this.labelItemCode.Name = "labelItemCode";
            this.labelItemCode.Size = new System.Drawing.Size(25, 13);
            this.labelItemCode.TabIndex = 23;
            this.labelItemCode.Text = "Code";
            // 
            // inputItemDescription
            // 
            this.inputItemDescription.DataBindings.Add(new System.Windows.Forms.Binding("DataContext", this.itemEditDtoBindingSource, "Description", true));
            this.inputItemDescription.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemEditDtoBindingSource, "Description", true));
            this.inputItemDescription.Enabled = false;
            this.inputItemDescription.Location = new System.Drawing.Point(49, 100);
            this.inputItemDescription.Name = "inputItemDescription";
            this.inputItemDescription.Size = new System.Drawing.Size(173, 20);
            this.inputItemDescription.TabIndex = 22;
            // 
            // inputItemCode
            // 
            this.inputItemCode.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.itemEditDtoBindingSource, "Code", true));
            this.inputItemCode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemEditDtoBindingSource, "Code", true));
            this.inputItemCode.EditValue = "";
            this.inputItemCode.Enabled = false;
            this.inputItemCode.Location = new System.Drawing.Point(172, 42);
            this.inputItemCode.Name = "inputItemCode";
            this.inputItemCode.Size = new System.Drawing.Size(173, 20);
            this.inputItemCode.TabIndex = 21;
            // 
            // btnItemDetailsClose
            // 
            this.btnItemDetailsClose.Location = new System.Drawing.Point(203, 217);
            this.btnItemDetailsClose.Name = "btnItemDetailsClose";
            this.btnItemDetailsClose.Size = new System.Drawing.Size(75, 23);
            this.btnItemDetailsClose.TabIndex = 31;
            this.btnItemDetailsClose.Text = "Close";
            this.btnItemDetailsClose.Click += new System.EventHandler(this.btnItemDetailsClose_Click);
            // 
            // itemEditDtoBindingSource
            // 
            this.itemEditDtoBindingSource.DataSource = typeof(FuelStation.Blazor.Shared.DTO.Item.ItemEditDto);
            // 
            // ItemDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 252);
            this.Controls.Add(this.btnItemDetailsClose);
            this.Controls.Add(this.comboBoxItemType);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelItemCost);
            this.Controls.Add(this.inputItemCost);
            this.Controls.Add(this.labelItemPrice);
            this.Controls.Add(this.inputItemPrice);
            this.Controls.Add(this.labelItemDescription);
            this.Controls.Add(this.labelItemCode);
            this.Controls.Add(this.inputItemDescription);
            this.Controls.Add(this.inputItemCode);
            this.Name = "ItemDetailsForm";
            this.Text = "Item Details";
            this.Load += new System.EventHandler(this.ItemDetailsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxItemType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputItemCost.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputItemPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputItemDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputItemCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemEditDtoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.ComboBoxEdit comboBoxItemType;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelItemCost;
        private DevExpress.XtraEditors.TextEdit inputItemCost;
        private DevExpress.XtraEditors.LabelControl labelItemPrice;
        private DevExpress.XtraEditors.TextEdit inputItemPrice;
        private DevExpress.XtraEditors.LabelControl labelItemDescription;
        private DevExpress.XtraEditors.LabelControl labelItemCode;
        private DevExpress.XtraEditors.TextEdit inputItemDescription;
        private DevExpress.XtraEditors.TextEdit inputItemCode;
        private DevExpress.XtraEditors.SimpleButton btnItemDetailsClose;
        private BindingSource itemEditDtoBindingSource;
    }
}