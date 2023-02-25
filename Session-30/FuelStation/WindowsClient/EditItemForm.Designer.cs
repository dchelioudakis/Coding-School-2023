namespace WindowsClient {
    partial class EditItemForm {
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
            this.labelItemPrice = new DevExpress.XtraEditors.LabelControl();
            this.inputItemPrice = new DevExpress.XtraEditors.TextEdit();
            this.itemEditDtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelItemDescription = new DevExpress.XtraEditors.LabelControl();
            this.labelItemCode = new DevExpress.XtraEditors.LabelControl();
            this.inputItemDescription = new DevExpress.XtraEditors.TextEdit();
            this.inputItemCode = new DevExpress.XtraEditors.TextEdit();
            this.btnEditItemCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnEditItemSave = new DevExpress.XtraEditors.SimpleButton();
            this.labelItemCost = new DevExpress.XtraEditors.LabelControl();
            this.inputItemCost = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.comboBoxItemType = new DevExpress.XtraEditors.ComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)(this.inputItemPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemEditDtoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputItemDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputItemCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputItemCost.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxItemType.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelItemPrice
            // 
            this.labelItemPrice.Location = new System.Drawing.Point(12, 121);
            this.labelItemPrice.Name = "labelItemPrice";
            this.labelItemPrice.Size = new System.Drawing.Size(23, 13);
            this.labelItemPrice.TabIndex = 15;
            this.labelItemPrice.Text = "Price";
            // 
            // inputItemPrice
            // 
            this.inputItemPrice.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.itemEditDtoBindingSource, "Price", true));
            this.inputItemPrice.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemEditDtoBindingSource, "Price", true));
            this.inputItemPrice.Location = new System.Drawing.Point(12, 140);
            this.inputItemPrice.Name = "inputItemPrice";
            this.inputItemPrice.Size = new System.Drawing.Size(173, 20);
            this.inputItemPrice.TabIndex = 14;
            // 
            // itemEditDtoBindingSource
            // 
            this.itemEditDtoBindingSource.DataSource = typeof(FuelStation.Blazor.Shared.DTO.Item.ItemEditDto);
            // 
            // labelItemDescription
            // 
            this.labelItemDescription.Location = new System.Drawing.Point(12, 67);
            this.labelItemDescription.Name = "labelItemDescription";
            this.labelItemDescription.Size = new System.Drawing.Size(53, 13);
            this.labelItemDescription.TabIndex = 13;
            this.labelItemDescription.Text = "Description";
            // 
            // labelItemCode
            // 
            this.labelItemCode.Location = new System.Drawing.Point(135, 9);
            this.labelItemCode.Name = "labelItemCode";
            this.labelItemCode.Size = new System.Drawing.Size(25, 13);
            this.labelItemCode.TabIndex = 12;
            this.labelItemCode.Text = "Code";
            // 
            // inputItemDescription
            // 
            this.inputItemDescription.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.itemEditDtoBindingSource, "Description", true));
            this.inputItemDescription.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemEditDtoBindingSource, "Description", true));
            this.inputItemDescription.Location = new System.Drawing.Point(12, 86);
            this.inputItemDescription.Name = "inputItemDescription";
            this.inputItemDescription.Size = new System.Drawing.Size(173, 20);
            this.inputItemDescription.TabIndex = 11;
            // 
            // inputItemCode
            // 
            this.inputItemCode.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.itemEditDtoBindingSource, "Code", true));
            this.inputItemCode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemEditDtoBindingSource, "Code", true));
            this.inputItemCode.EditValue = "";
            this.inputItemCode.Location = new System.Drawing.Point(135, 28);
            this.inputItemCode.Name = "inputItemCode";
            this.inputItemCode.Size = new System.Drawing.Size(173, 20);
            this.inputItemCode.TabIndex = 10;
            // 
            // btnEditItemCancel
            // 
            this.btnEditItemCancel.Location = new System.Drawing.Point(233, 227);
            this.btnEditItemCancel.Name = "btnEditItemCancel";
            this.btnEditItemCancel.Size = new System.Drawing.Size(75, 23);
            this.btnEditItemCancel.TabIndex = 9;
            this.btnEditItemCancel.Text = "Cancel";
            this.btnEditItemCancel.Click += new System.EventHandler(this.btnEditItemCancel_Click);
            // 
            // btnEditItemSave
            // 
            this.btnEditItemSave.Location = new System.Drawing.Point(135, 227);
            this.btnEditItemSave.Name = "btnEditItemSave";
            this.btnEditItemSave.Size = new System.Drawing.Size(75, 23);
            this.btnEditItemSave.TabIndex = 8;
            this.btnEditItemSave.Text = "Save";
            this.btnEditItemSave.Click += new System.EventHandler(this.btnEditItemSave_Click);
            // 
            // labelItemCost
            // 
            this.labelItemCost.Location = new System.Drawing.Point(219, 121);
            this.labelItemCost.Name = "labelItemCost";
            this.labelItemCost.Size = new System.Drawing.Size(22, 13);
            this.labelItemCost.TabIndex = 17;
            this.labelItemCost.Text = "Cost";
            // 
            // inputItemCost
            // 
            this.inputItemCost.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.itemEditDtoBindingSource, "Cost", true));
            this.inputItemCost.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemEditDtoBindingSource, "Cost", true));
            this.inputItemCost.Location = new System.Drawing.Point(219, 140);
            this.inputItemCost.Name = "inputItemCost";
            this.inputItemCost.Size = new System.Drawing.Size(173, 20);
            this.inputItemCost.TabIndex = 16;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(219, 67);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(24, 13);
            this.labelControl2.TabIndex = 19;
            this.labelControl2.Text = "Type";
            // 
            // comboBoxItemType
            // 
            this.comboBoxItemType.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.itemEditDtoBindingSource, "Type", true));
            this.comboBoxItemType.Location = new System.Drawing.Point(219, 86);
            this.comboBoxItemType.Name = "comboBoxItemType";
            this.comboBoxItemType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxItemType.Size = new System.Drawing.Size(173, 20);
            this.comboBoxItemType.TabIndex = 20;
            // 
            // EditItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 262);
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
            this.Controls.Add(this.btnEditItemCancel);
            this.Controls.Add(this.btnEditItemSave);
            this.Name = "EditItemForm";
            this.Text = "Edit Item";
            this.Load += new System.EventHandler(this.EditItemForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.inputItemPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemEditDtoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputItemDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputItemCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputItemCost.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxItemType.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelItemPrice;
        private DevExpress.XtraEditors.TextEdit inputItemPrice;
        private DevExpress.XtraEditors.LabelControl labelItemDescription;
        private DevExpress.XtraEditors.LabelControl labelItemCode;
        private DevExpress.XtraEditors.TextEdit inputItemDescription;
        private DevExpress.XtraEditors.TextEdit inputItemCode;
        private DevExpress.XtraEditors.SimpleButton btnEditItemCancel;
        private DevExpress.XtraEditors.SimpleButton btnEditItemSave;
        private DevExpress.XtraEditors.LabelControl labelItemCost;
        private DevExpress.XtraEditors.TextEdit inputItemCost;
        private BindingSource itemEditDtoBindingSource;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxItemType;
    }
}