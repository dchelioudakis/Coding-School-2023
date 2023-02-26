namespace WindowsClient {
    partial class StaffForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffForm));
            this.navManager = new DevExpress.XtraBars.Navigation.NavigationPane();
            this.pageItems = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.btnItemDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnItemDetails = new DevExpress.XtraEditors.SimpleButton();
            this.btnItemEdit = new DevExpress.XtraEditors.SimpleButton();
            this.btnItemCreate = new DevExpress.XtraEditors.SimpleButton();
            this.grdItems = new DevExpress.XtraGrid.GridControl();
            this.grvItems = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colItemCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItemDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItemType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItemPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItemCost = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.navManager)).BeginInit();
            this.navManager.SuspendLayout();
            this.pageItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvItems)).BeginInit();
            this.SuspendLayout();
            // 
            // navManager
            // 
            this.navManager.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.navManager.Controls.Add(this.pageItems);
            this.navManager.Location = new System.Drawing.Point(12, 5);
            this.navManager.Name = "navManager";
            this.navManager.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.pageItems});
            this.navManager.RegularSize = new System.Drawing.Size(1162, 575);
            this.navManager.SelectedPage = this.pageItems;
            this.navManager.Size = new System.Drawing.Size(1162, 575);
            this.navManager.TabIndex = 3;
            this.navManager.Text = "Customers";
            // 
            // pageItems
            // 
            this.pageItems.Caption = "Items";
            this.pageItems.Controls.Add(this.btnItemDelete);
            this.pageItems.Controls.Add(this.btnItemDetails);
            this.pageItems.Controls.Add(this.btnItemEdit);
            this.pageItems.Controls.Add(this.btnItemCreate);
            this.pageItems.Controls.Add(this.grdItems);
            this.pageItems.Name = "pageItems";
            this.pageItems.Size = new System.Drawing.Size(1080, 502);
            // 
            // btnItemDelete
            // 
            this.btnItemDelete.Appearance.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnItemDelete.Appearance.Options.UseBackColor = true;
            this.btnItemDelete.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnItemDelete.ImageOptions.SvgImage")));
            this.btnItemDelete.ImageOptions.SvgImageSize = new System.Drawing.Size(20, 20);
            this.btnItemDelete.Location = new System.Drawing.Point(225, 3);
            this.btnItemDelete.Name = "btnItemDelete";
            this.btnItemDelete.Size = new System.Drawing.Size(68, 26);
            this.btnItemDelete.TabIndex = 8;
            this.btnItemDelete.Text = "Delete";
            this.btnItemDelete.Click += new System.EventHandler(this.btnItemDelete_Click);
            // 
            // btnItemDetails
            // 
            this.btnItemDetails.Appearance.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnItemDetails.Appearance.Options.UseBackColor = true;
            this.btnItemDetails.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnItemDetails.ImageOptions.SvgImage")));
            this.btnItemDetails.ImageOptions.SvgImageSize = new System.Drawing.Size(20, 20);
            this.btnItemDetails.Location = new System.Drawing.Point(151, 3);
            this.btnItemDetails.Name = "btnItemDetails";
            this.btnItemDetails.Size = new System.Drawing.Size(68, 26);
            this.btnItemDetails.TabIndex = 7;
            this.btnItemDetails.Text = "Details";
            this.btnItemDetails.Click += new System.EventHandler(this.btnItemDetails_Click);
            // 
            // btnItemEdit
            // 
            this.btnItemEdit.Appearance.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnItemEdit.Appearance.Options.UseBackColor = true;
            this.btnItemEdit.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnItemEdit.ImageOptions.SvgImage")));
            this.btnItemEdit.ImageOptions.SvgImageSize = new System.Drawing.Size(20, 20);
            this.btnItemEdit.Location = new System.Drawing.Point(77, 3);
            this.btnItemEdit.Name = "btnItemEdit";
            this.btnItemEdit.Size = new System.Drawing.Size(68, 26);
            this.btnItemEdit.TabIndex = 6;
            this.btnItemEdit.Text = "Edit";
            this.btnItemEdit.Click += new System.EventHandler(this.btnItemEdit_Click);
            // 
            // btnItemCreate
            // 
            this.btnItemCreate.Appearance.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnItemCreate.Appearance.Options.UseBackColor = true;
            this.btnItemCreate.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnItemCreate.ImageOptions.SvgImage")));
            this.btnItemCreate.ImageOptions.SvgImageSize = new System.Drawing.Size(20, 20);
            this.btnItemCreate.Location = new System.Drawing.Point(3, 3);
            this.btnItemCreate.Name = "btnItemCreate";
            this.btnItemCreate.Size = new System.Drawing.Size(68, 26);
            this.btnItemCreate.TabIndex = 5;
            this.btnItemCreate.Text = "Create";
            this.btnItemCreate.Click += new System.EventHandler(this.btnItemCreate_Click);
            // 
            // grdItems
            // 
            this.grdItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdItems.Location = new System.Drawing.Point(3, 45);
            this.grdItems.MainView = this.grvItems;
            this.grdItems.Name = "grdItems";
            this.grdItems.Size = new System.Drawing.Size(1908, 877);
            this.grdItems.TabIndex = 1;
            this.grdItems.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvItems});
            // 
            // grvItems
            // 
            this.grvItems.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colItemCode,
            this.colItemDescription,
            this.colItemType,
            this.colItemPrice,
            this.colItemCost});
            this.grvItems.GridControl = this.grdItems;
            this.grvItems.Name = "grvItems";
            this.grvItems.OptionsBehavior.Editable = false;
            this.grvItems.OptionsBehavior.ReadOnly = true;
            this.grvItems.OptionsView.ShowGroupPanel = false;
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
            // colItemType
            // 
            this.colItemType.Caption = "Type";
            this.colItemType.FieldName = "Type";
            this.colItemType.Name = "colItemType";
            this.colItemType.Visible = true;
            this.colItemType.VisibleIndex = 2;
            // 
            // colItemPrice
            // 
            this.colItemPrice.Caption = "Price";
            this.colItemPrice.FieldName = "Price";
            this.colItemPrice.Name = "colItemPrice";
            this.colItemPrice.Visible = true;
            this.colItemPrice.VisibleIndex = 3;
            // 
            // colItemCost
            // 
            this.colItemCost.Caption = "Cost";
            this.colItemCost.FieldName = "Cost";
            this.colItemCost.Name = "colItemCost";
            this.colItemCost.Visible = true;
            this.colItemCost.VisibleIndex = 4;
            // 
            // StaffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 592);
            this.Controls.Add(this.navManager);
            this.Name = "StaffForm";
            this.Text = "StaffForm";
            this.Load += new System.EventHandler(this.StaffForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.navManager)).EndInit();
            this.navManager.ResumeLayout(false);
            this.pageItems.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvItems)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.NavigationPane navManager;
        private DevExpress.XtraBars.Navigation.NavigationPage pageItems;
        private DevExpress.XtraEditors.SimpleButton btnItemDelete;
        private DevExpress.XtraEditors.SimpleButton btnItemDetails;
        private DevExpress.XtraEditors.SimpleButton btnItemEdit;
        private DevExpress.XtraEditors.SimpleButton btnItemCreate;
        private DevExpress.XtraGrid.GridControl grdItems;
        private DevExpress.XtraGrid.Views.Grid.GridView grvItems;
        private DevExpress.XtraGrid.Columns.GridColumn colItemCode;
        private DevExpress.XtraGrid.Columns.GridColumn colItemDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colItemType;
        private DevExpress.XtraGrid.Columns.GridColumn colItemPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colItemCost;
    }
}