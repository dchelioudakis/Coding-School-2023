﻿namespace Session_16 {
    partial class AdminForm {
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions3 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject9 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject10 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject11 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject12 = new DevExpress.Utils.SerializableAppearanceObject();
            this.alertControl1 = new DevExpress.XtraBars.Alerter.AlertControl(this.components);
            this.grvManagers = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grdColName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdColSurname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdColSalary = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdManagers = new DevExpress.XtraGrid.GridControl();
            this.grdEngineers = new DevExpress.XtraGrid.GridControl();
            this.grvEngineers = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grdColEngineerName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdColEngineerSurname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdColEngineerManager = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repManagers = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.repManagersView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grdColEngineerSalary = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdServiceTasks = new DevExpress.XtraGrid.GridControl();
            this.grvServiceTasks = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colServiceTaskCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colServiceTaskDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colServiceTaskHours = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdTransactions = new DevExpress.XtraGrid.GridControl();
            this.grvTransactions = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grdDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdCustomerName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repCustomers = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grdCar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repCars = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grdManager = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repManagers2 = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grdTotalPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTransactionsViewBtn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repTransactionLinesViewBtn = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.grdTransactionLines = new DevExpress.XtraGrid.GridControl();
            this.grvTransactionLines = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTransactionLinesServiceTask = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repTransactionLinesTasks = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTransactionLineEngineer = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repTransactionLineEngineers = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTransactionLinesHours = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTransactionLinePricePerHour = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTransactionLinePrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnLoad = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnPopulate = new DevExpress.XtraEditors.SimpleButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.grdMonthlyLedger = new DevExpress.XtraGrid.GridControl();
            this.grvMonthlyLedger = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMonthlyYear = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMonthlyMonth = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMonthlyIncome = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMonthlyExpenses = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMonthlyTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.tabPane1 = new DevExpress.XtraBars.Navigation.TabPane();
            this.tabManagers = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.tabEngineers = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.tabTasks = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.tabTransactions = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.btnAddLine = new DevExpress.XtraEditors.SimpleButton();
            this.btnAddTransaction = new DevExpress.XtraEditors.SimpleButton();
            this.tabStatistics = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.label1 = new System.Windows.Forms.Label();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.tabCustomers = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.grdCustomers = new DevExpress.XtraGrid.GridControl();
            this.grvCustomers = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCustomerId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomerName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomerSurname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomerTIN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomerPhone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnLoadFromSQL = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.grvManagers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdManagers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdEngineers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvEngineers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repManagers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repManagersView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdServiceTasks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvServiceTasks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdTransactions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvTransactions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repCars)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repManagers2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repTransactionLinesViewBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdTransactionLines)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvTransactionLines)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repTransactionLinesTasks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repTransactionLineEngineers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdMonthlyLedger)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvMonthlyLedger)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).BeginInit();
            this.tabPane1.SuspendLayout();
            this.tabManagers.SuspendLayout();
            this.tabEngineers.SuspendLayout();
            this.tabTasks.SuspendLayout();
            this.tabTransactions.SuspendLayout();
            this.tabStatistics.SuspendLayout();
            this.tabCustomers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // grvManagers
            // 
            this.grvManagers.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.grdColName,
            this.grdColSurname,
            this.grdColSalary});
            this.grvManagers.DetailHeight = 262;
            this.grvManagers.GridControl = this.grdManagers;
            this.grvManagers.Name = "grvManagers";
            this.grvManagers.OptionsView.ShowGroupPanel = false;
            this.grvManagers.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.grvManagers_RowUpdated);
            // 
            // grdColName
            // 
            this.grdColName.Caption = "Name";
            this.grdColName.FieldName = "Name";
            this.grdColName.MinWidth = 22;
            this.grdColName.Name = "grdColName";
            this.grdColName.Visible = true;
            this.grdColName.VisibleIndex = 0;
            this.grdColName.Width = 82;
            // 
            // grdColSurname
            // 
            this.grdColSurname.Caption = "Surname";
            this.grdColSurname.FieldName = "Surname";
            this.grdColSurname.MinWidth = 22;
            this.grdColSurname.Name = "grdColSurname";
            this.grdColSurname.Visible = true;
            this.grdColSurname.VisibleIndex = 1;
            this.grdColSurname.Width = 82;
            // 
            // grdColSalary
            // 
            this.grdColSalary.Caption = "Month Salary";
            this.grdColSalary.FieldName = "SalaryPerMonth";
            this.grdColSalary.MinWidth = 22;
            this.grdColSalary.Name = "grdColSalary";
            this.grdColSalary.Visible = true;
            this.grdColSalary.VisibleIndex = 2;
            this.grdColSalary.Width = 82;
            // 
            // grdManagers
            // 
            this.grdManagers.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grdManagers.Location = new System.Drawing.Point(17, 40);
            this.grdManagers.MainView = this.grvManagers;
            this.grdManagers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grdManagers.Name = "grdManagers";
            this.grdManagers.Size = new System.Drawing.Size(659, 371);
            this.grdManagers.TabIndex = 1;
            this.grdManagers.UseEmbeddedNavigator = true;
            this.grdManagers.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvManagers});
            // 
            // grdEngineers
            // 
            this.grdEngineers.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grdEngineers.Location = new System.Drawing.Point(18, 35);
            this.grdEngineers.MainView = this.grvEngineers;
            this.grdEngineers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grdEngineers.Name = "grdEngineers";
            this.grdEngineers.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repManagers});
            this.grdEngineers.Size = new System.Drawing.Size(657, 376);
            this.grdEngineers.TabIndex = 3;
            this.grdEngineers.UseEmbeddedNavigator = true;
            this.grdEngineers.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvEngineers});
            // 
            // grvEngineers
            // 
            this.grvEngineers.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.grdColEngineerName,
            this.grdColEngineerSurname,
            this.grdColEngineerManager,
            this.grdColEngineerSalary});
            this.grvEngineers.DetailHeight = 262;
            this.grvEngineers.GridControl = this.grdEngineers;
            this.grvEngineers.Name = "grvEngineers";
            this.grvEngineers.OptionsView.ShowGroupPanel = false;
            // 
            // grdColEngineerName
            // 
            this.grdColEngineerName.Caption = "Name";
            this.grdColEngineerName.FieldName = "Name";
            this.grdColEngineerName.MinWidth = 22;
            this.grdColEngineerName.Name = "grdColEngineerName";
            this.grdColEngineerName.Visible = true;
            this.grdColEngineerName.VisibleIndex = 0;
            this.grdColEngineerName.Width = 82;
            // 
            // grdColEngineerSurname
            // 
            this.grdColEngineerSurname.Caption = "Surname";
            this.grdColEngineerSurname.FieldName = "Surname";
            this.grdColEngineerSurname.MinWidth = 22;
            this.grdColEngineerSurname.Name = "grdColEngineerSurname";
            this.grdColEngineerSurname.Visible = true;
            this.grdColEngineerSurname.VisibleIndex = 1;
            this.grdColEngineerSurname.Width = 82;
            // 
            // grdColEngineerManager
            // 
            this.grdColEngineerManager.Caption = "Manager";
            this.grdColEngineerManager.ColumnEdit = this.repManagers;
            this.grdColEngineerManager.FieldName = "ManagerID";
            this.grdColEngineerManager.MinWidth = 22;
            this.grdColEngineerManager.Name = "grdColEngineerManager";
            this.grdColEngineerManager.Visible = true;
            this.grdColEngineerManager.VisibleIndex = 2;
            this.grdColEngineerManager.Width = 82;
            // 
            // repManagers
            // 
            this.repManagers.AutoHeight = false;
            this.repManagers.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repManagers.Name = "repManagers";
            this.repManagers.PopupView = this.repManagersView;
            // 
            // repManagersView
            // 
            this.repManagersView.DetailHeight = 262;
            this.repManagersView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repManagersView.Name = "repManagersView";
            this.repManagersView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repManagersView.OptionsView.ShowGroupPanel = false;
            // 
            // grdColEngineerSalary
            // 
            this.grdColEngineerSalary.Caption = "Month Salary";
            this.grdColEngineerSalary.FieldName = "SalaryPerMonth";
            this.grdColEngineerSalary.MinWidth = 22;
            this.grdColEngineerSalary.Name = "grdColEngineerSalary";
            this.grdColEngineerSalary.Visible = true;
            this.grdColEngineerSalary.VisibleIndex = 3;
            this.grdColEngineerSalary.Width = 82;
            // 
            // grdServiceTasks
            // 
            this.grdServiceTasks.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grdServiceTasks.Location = new System.Drawing.Point(13, 36);
            this.grdServiceTasks.MainView = this.grvServiceTasks;
            this.grdServiceTasks.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grdServiceTasks.Name = "grdServiceTasks";
            this.grdServiceTasks.Size = new System.Drawing.Size(662, 375);
            this.grdServiceTasks.TabIndex = 4;
            this.grdServiceTasks.UseEmbeddedNavigator = true;
            this.grdServiceTasks.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvServiceTasks});
            // 
            // grvServiceTasks
            // 
            this.grvServiceTasks.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colServiceTaskCode,
            this.colServiceTaskDescription,
            this.colServiceTaskHours});
            this.grvServiceTasks.DetailHeight = 262;
            this.grvServiceTasks.GridControl = this.grdServiceTasks;
            this.grvServiceTasks.Name = "grvServiceTasks";
            this.grvServiceTasks.OptionsView.ShowGroupPanel = false;
            this.grvServiceTasks.CellValueChanging += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.grvServiceTasks_CellValueChanging);
            // 
            // colServiceTaskCode
            // 
            this.colServiceTaskCode.Caption = "Code";
            this.colServiceTaskCode.FieldName = "Code";
            this.colServiceTaskCode.MinWidth = 22;
            this.colServiceTaskCode.Name = "colServiceTaskCode";
            this.colServiceTaskCode.Visible = true;
            this.colServiceTaskCode.VisibleIndex = 0;
            this.colServiceTaskCode.Width = 82;
            // 
            // colServiceTaskDescription
            // 
            this.colServiceTaskDescription.Caption = "Description";
            this.colServiceTaskDescription.FieldName = "Description";
            this.colServiceTaskDescription.MinWidth = 22;
            this.colServiceTaskDescription.Name = "colServiceTaskDescription";
            this.colServiceTaskDescription.Visible = true;
            this.colServiceTaskDescription.VisibleIndex = 1;
            this.colServiceTaskDescription.Width = 82;
            // 
            // colServiceTaskHours
            // 
            this.colServiceTaskHours.Caption = "Hours";
            this.colServiceTaskHours.FieldName = "Hours";
            this.colServiceTaskHours.MinWidth = 22;
            this.colServiceTaskHours.Name = "colServiceTaskHours";
            this.colServiceTaskHours.Visible = true;
            this.colServiceTaskHours.VisibleIndex = 2;
            this.colServiceTaskHours.Width = 82;
            // 
            // grdTransactions
            // 
            this.grdTransactions.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2);
            this.grdTransactions.Location = new System.Drawing.Point(13, 21);
            this.grdTransactions.MainView = this.grvTransactions;
            this.grdTransactions.Margin = new System.Windows.Forms.Padding(2);
            this.grdTransactions.Name = "grdTransactions";
            this.grdTransactions.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repCars,
            this.repCustomers,
            this.repManagers2,
            this.repTransactionLinesViewBtn});
            this.grdTransactions.Size = new System.Drawing.Size(662, 167);
            this.grdTransactions.TabIndex = 5;
            this.grdTransactions.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvTransactions});
            // 
            // grvTransactions
            // 
            this.grvTransactions.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.grdDate,
            this.grdCustomerName,
            this.grdCar,
            this.grdManager,
            this.grdTotalPrice,
            this.colTransactionsViewBtn});
            this.grvTransactions.DetailHeight = 210;
            this.grvTransactions.GridControl = this.grdTransactions;
            this.grvTransactions.Name = "grvTransactions";
            this.grvTransactions.OptionsView.ShowGroupPanel = false;
            // 
            // grdDate
            // 
            this.grdDate.Caption = "Date";
            this.grdDate.FieldName = "Date";
            this.grdDate.MinWidth = 21;
            this.grdDate.Name = "grdDate";
            this.grdDate.Visible = true;
            this.grdDate.VisibleIndex = 0;
            this.grdDate.Width = 79;
            // 
            // grdCustomerName
            // 
            this.grdCustomerName.Caption = "Customer Name";
            this.grdCustomerName.ColumnEdit = this.repCustomers;
            this.grdCustomerName.FieldName = "CustomerID";
            this.grdCustomerName.MinWidth = 21;
            this.grdCustomerName.Name = "grdCustomerName";
            this.grdCustomerName.Visible = true;
            this.grdCustomerName.VisibleIndex = 1;
            this.grdCustomerName.Width = 79;
            // 
            // repCustomers
            // 
            this.repCustomers.AutoHeight = false;
            this.repCustomers.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repCustomers.Name = "repCustomers";
            this.repCustomers.PopupView = this.gridView1;
            // 
            // gridView1
            // 
            this.gridView1.DetailHeight = 210;
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // grdCar
            // 
            this.grdCar.Caption = "Car";
            this.grdCar.ColumnEdit = this.repCars;
            this.grdCar.FieldName = "CarID";
            this.grdCar.MinWidth = 21;
            this.grdCar.Name = "grdCar";
            this.grdCar.Visible = true;
            this.grdCar.VisibleIndex = 2;
            this.grdCar.Width = 79;
            // 
            // repCars
            // 
            this.repCars.AutoHeight = false;
            this.repCars.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repCars.Name = "repCars";
            this.repCars.PopupView = this.repositoryItemGridLookUpEdit1View;
            // 
            // repositoryItemGridLookUpEdit1View
            // 
            this.repositoryItemGridLookUpEdit1View.DetailHeight = 210;
            this.repositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit1View.Name = "repositoryItemGridLookUpEdit1View";
            this.repositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // grdManager
            // 
            this.grdManager.Caption = "Manager";
            this.grdManager.ColumnEdit = this.repManagers2;
            this.grdManager.FieldName = "ManagerID";
            this.grdManager.MinWidth = 21;
            this.grdManager.Name = "grdManager";
            this.grdManager.Visible = true;
            this.grdManager.VisibleIndex = 3;
            this.grdManager.Width = 79;
            // 
            // repManagers2
            // 
            this.repManagers2.AutoHeight = false;
            this.repManagers2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repManagers2.Name = "repManagers2";
            this.repManagers2.PopupView = this.gridView2;
            // 
            // gridView2
            // 
            this.gridView2.DetailHeight = 210;
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // grdTotalPrice
            // 
            this.grdTotalPrice.Caption = "Total Price";
            this.grdTotalPrice.FieldName = "TotalPrice";
            this.grdTotalPrice.MinWidth = 21;
            this.grdTotalPrice.Name = "grdTotalPrice";
            this.grdTotalPrice.OptionsColumn.AllowEdit = false;
            this.grdTotalPrice.Visible = true;
            this.grdTotalPrice.VisibleIndex = 4;
            this.grdTotalPrice.Width = 79;
            // 
            // colTransactionsViewBtn
            // 
            this.colTransactionsViewBtn.Caption = "Actions";
            this.colTransactionsViewBtn.ColumnEdit = this.repTransactionLinesViewBtn;
            this.colTransactionsViewBtn.FieldName = "colTransactionsViewBtn";
            this.colTransactionsViewBtn.MinWidth = 22;
            this.colTransactionsViewBtn.Name = "colTransactionsViewBtn";
            this.colTransactionsViewBtn.UnboundDataType = typeof(object);
            this.colTransactionsViewBtn.Visible = true;
            this.colTransactionsViewBtn.VisibleIndex = 5;
            this.colTransactionsViewBtn.Width = 82;
            // 
            // repTransactionLinesViewBtn
            // 
            this.repTransactionLinesViewBtn.AdvancedModeOptions.Label = "Details";
            this.repTransactionLinesViewBtn.AutoHeight = false;
            this.repTransactionLinesViewBtn.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "Details", -1, true, true, false, editorButtonImageOptions3, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject9, serializableAppearanceObject10, serializableAppearanceObject11, serializableAppearanceObject12, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.repTransactionLinesViewBtn.Name = "repTransactionLinesViewBtn";
            this.repTransactionLinesViewBtn.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.repTransactionLinesViewBtn.Click += new System.EventHandler(this.repTransactionLinesViewBtn_Click);
            // 
            // grdTransactionLines
            // 
            this.grdTransactionLines.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grdTransactionLines.Location = new System.Drawing.Point(13, 258);
            this.grdTransactionLines.MainView = this.grvTransactionLines;
            this.grdTransactionLines.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grdTransactionLines.Name = "grdTransactionLines";
            this.grdTransactionLines.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repTransactionLinesTasks,
            this.repTransactionLineEngineers});
            this.grdTransactionLines.Size = new System.Drawing.Size(662, 131);
            this.grdTransactionLines.TabIndex = 6;
            this.grdTransactionLines.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvTransactionLines});
            // 
            // grvTransactionLines
            // 
            this.grvTransactionLines.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTransactionLinesServiceTask,
            this.colTransactionLineEngineer,
            this.colTransactionLinesHours,
            this.colTransactionLinePricePerHour,
            this.colTransactionLinePrice});
            this.grvTransactionLines.DetailHeight = 262;
            this.grvTransactionLines.GridControl = this.grdTransactionLines;
            this.grvTransactionLines.Name = "grvTransactionLines";
            this.grvTransactionLines.OptionsView.ShowGroupPanel = false;
            // 
            // colTransactionLinesServiceTask
            // 
            this.colTransactionLinesServiceTask.Caption = "Task";
            this.colTransactionLinesServiceTask.ColumnEdit = this.repTransactionLinesTasks;
            this.colTransactionLinesServiceTask.FieldName = "ServiceTaskID";
            this.colTransactionLinesServiceTask.MinWidth = 22;
            this.colTransactionLinesServiceTask.Name = "colTransactionLinesServiceTask";
            this.colTransactionLinesServiceTask.Visible = true;
            this.colTransactionLinesServiceTask.VisibleIndex = 0;
            this.colTransactionLinesServiceTask.Width = 82;
            // 
            // repTransactionLinesTasks
            // 
            this.repTransactionLinesTasks.AutoHeight = false;
            this.repTransactionLinesTasks.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repTransactionLinesTasks.Name = "repTransactionLinesTasks";
            this.repTransactionLinesTasks.PopupView = this.gridView3;
            // 
            // gridView3
            // 
            this.gridView3.DetailHeight = 262;
            this.gridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView3.OptionsView.ShowGroupPanel = false;
            // 
            // colTransactionLineEngineer
            // 
            this.colTransactionLineEngineer.Caption = "Engineer";
            this.colTransactionLineEngineer.ColumnEdit = this.repTransactionLineEngineers;
            this.colTransactionLineEngineer.FieldName = "EngineerID";
            this.colTransactionLineEngineer.MinWidth = 22;
            this.colTransactionLineEngineer.Name = "colTransactionLineEngineer";
            this.colTransactionLineEngineer.Visible = true;
            this.colTransactionLineEngineer.VisibleIndex = 1;
            this.colTransactionLineEngineer.Width = 82;
            // 
            // repTransactionLineEngineers
            // 
            this.repTransactionLineEngineers.AutoHeight = false;
            this.repTransactionLineEngineers.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repTransactionLineEngineers.Name = "repTransactionLineEngineers";
            this.repTransactionLineEngineers.PopupView = this.gridView4;
            // 
            // gridView4
            // 
            this.gridView4.DetailHeight = 262;
            this.gridView4.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView4.Name = "gridView4";
            this.gridView4.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView4.OptionsView.ShowGroupPanel = false;
            // 
            // colTransactionLinesHours
            // 
            this.colTransactionLinesHours.Caption = "Hours";
            this.colTransactionLinesHours.FieldName = "Hours";
            this.colTransactionLinesHours.MinWidth = 22;
            this.colTransactionLinesHours.Name = "colTransactionLinesHours";
            this.colTransactionLinesHours.OptionsColumn.AllowEdit = false;
            this.colTransactionLinesHours.Visible = true;
            this.colTransactionLinesHours.VisibleIndex = 2;
            this.colTransactionLinesHours.Width = 82;
            // 
            // colTransactionLinePricePerHour
            // 
            this.colTransactionLinePricePerHour.Caption = "PricePerHour";
            this.colTransactionLinePricePerHour.FieldName = "PricePerHour";
            this.colTransactionLinePricePerHour.MinWidth = 22;
            this.colTransactionLinePricePerHour.Name = "colTransactionLinePricePerHour";
            this.colTransactionLinePricePerHour.OptionsColumn.AllowEdit = false;
            this.colTransactionLinePricePerHour.Visible = true;
            this.colTransactionLinePricePerHour.VisibleIndex = 3;
            this.colTransactionLinePricePerHour.Width = 82;
            // 
            // colTransactionLinePrice
            // 
            this.colTransactionLinePrice.Caption = "Price";
            this.colTransactionLinePrice.FieldName = "Price";
            this.colTransactionLinePrice.MinWidth = 22;
            this.colTransactionLinePrice.Name = "colTransactionLinePrice";
            this.colTransactionLinePrice.OptionsColumn.AllowEdit = false;
            this.colTransactionLinePrice.Visible = true;
            this.colTransactionLinePrice.VisibleIndex = 4;
            this.colTransactionLinePrice.Width = 82;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(516, 480);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(82, 27);
            this.btnLoad.TabIndex = 7;
            this.btnLoad.Text = "Load(JSON)";
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(604, 480);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(82, 27);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnPopulate
            // 
            this.btnPopulate.Location = new System.Drawing.Point(27, 480);
            this.btnPopulate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPopulate.Name = "btnPopulate";
            this.btnPopulate.Size = new System.Drawing.Size(103, 27);
            this.btnPopulate.TabIndex = 9;
            this.btnPopulate.Text = "Populate";
            this.btnPopulate.Click += new System.EventHandler(this.btnPopulate_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(311, 17);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(106, 23);
            this.textBox1.TabIndex = 10;
            this.textBox1.Text = "Managers";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(304, 11);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(106, 23);
            this.textBox2.TabIndex = 11;
            this.textBox2.Text = "Engineers";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(282, 2);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(106, 23);
            this.textBox3.TabIndex = 12;
            this.textBox3.Text = "Transaction";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(308, 12);
            this.textBox4.Margin = new System.Windows.Forms.Padding(2);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(106, 23);
            this.textBox4.TabIndex = 13;
            this.textBox4.Text = "Tasks";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(272, 236);
            this.textBox5.Margin = new System.Windows.Forms.Padding(2);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(106, 23);
            this.textBox5.TabIndex = 14;
            this.textBox5.Text = "Transaction Lines";
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox6
            // 
            this.textBox6.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.textBox6.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.textBox6.Location = new System.Drawing.Point(572, 11);
            this.textBox6.Margin = new System.Windows.Forms.Padding(2);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(104, 22);
            this.textBox6.TabIndex = 15;
            this.textBox6.Text = "Insert engineer info";
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox7
            // 
            this.textBox7.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.textBox7.Location = new System.Drawing.Point(572, 17);
            this.textBox7.Margin = new System.Windows.Forms.Padding(2);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(104, 22);
            this.textBox7.TabIndex = 16;
            this.textBox7.Text = "Insert manager info";
            this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox8
            // 
            this.textBox8.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.textBox8.Location = new System.Drawing.Point(585, 14);
            this.textBox8.Margin = new System.Windows.Forms.Padding(2);
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(91, 22);
            this.textBox8.TabIndex = 17;
            this.textBox8.Text = "Insert task info";
            this.textBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox9
            // 
            this.textBox9.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.textBox9.Location = new System.Drawing.Point(562, 3);
            this.textBox9.Margin = new System.Windows.Forms.Padding(2);
            this.textBox9.Name = "textBox9";
            this.textBox9.ReadOnly = true;
            this.textBox9.Size = new System.Drawing.Size(114, 22);
            this.textBox9.TabIndex = 18;
            this.textBox9.Text = "Insert transaction info";
            this.textBox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "MM/yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(117, 351);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(98, 23);
            this.dateTimePicker1.TabIndex = 19;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // grdMonthlyLedger
            // 
            this.grdMonthlyLedger.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grdMonthlyLedger.Location = new System.Drawing.Point(15, 34);
            this.grdMonthlyLedger.MainView = this.grvMonthlyLedger;
            this.grdMonthlyLedger.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grdMonthlyLedger.Name = "grdMonthlyLedger";
            this.grdMonthlyLedger.Size = new System.Drawing.Size(661, 313);
            this.grdMonthlyLedger.TabIndex = 20;
            this.grdMonthlyLedger.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvMonthlyLedger});
            // 
            // grvMonthlyLedger
            // 
            this.grvMonthlyLedger.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMonthlyYear,
            this.colMonthlyMonth,
            this.colMonthlyIncome,
            this.colMonthlyExpenses,
            this.colMonthlyTotal});
            this.grvMonthlyLedger.DetailHeight = 262;
            this.grvMonthlyLedger.GridControl = this.grdMonthlyLedger;
            this.grvMonthlyLedger.Name = "grvMonthlyLedger";
            this.grvMonthlyLedger.OptionsView.ShowGroupPanel = false;
            // 
            // colMonthlyYear
            // 
            this.colMonthlyYear.Caption = "Year";
            this.colMonthlyYear.FieldName = "Year";
            this.colMonthlyYear.MinWidth = 22;
            this.colMonthlyYear.Name = "colMonthlyYear";
            this.colMonthlyYear.OptionsColumn.AllowEdit = false;
            this.colMonthlyYear.Visible = true;
            this.colMonthlyYear.VisibleIndex = 0;
            this.colMonthlyYear.Width = 82;
            // 
            // colMonthlyMonth
            // 
            this.colMonthlyMonth.Caption = "Month";
            this.colMonthlyMonth.FieldName = "Month";
            this.colMonthlyMonth.MinWidth = 22;
            this.colMonthlyMonth.Name = "colMonthlyMonth";
            this.colMonthlyMonth.OptionsColumn.AllowEdit = false;
            this.colMonthlyMonth.Visible = true;
            this.colMonthlyMonth.VisibleIndex = 1;
            this.colMonthlyMonth.Width = 82;
            // 
            // colMonthlyIncome
            // 
            this.colMonthlyIncome.Caption = "Income";
            this.colMonthlyIncome.FieldName = "Income";
            this.colMonthlyIncome.MinWidth = 22;
            this.colMonthlyIncome.Name = "colMonthlyIncome";
            this.colMonthlyIncome.OptionsColumn.AllowEdit = false;
            this.colMonthlyIncome.Visible = true;
            this.colMonthlyIncome.VisibleIndex = 2;
            this.colMonthlyIncome.Width = 82;
            // 
            // colMonthlyExpenses
            // 
            this.colMonthlyExpenses.Caption = "Expenses";
            this.colMonthlyExpenses.FieldName = "Expenses";
            this.colMonthlyExpenses.MinWidth = 22;
            this.colMonthlyExpenses.Name = "colMonthlyExpenses";
            this.colMonthlyExpenses.OptionsColumn.AllowEdit = false;
            this.colMonthlyExpenses.Visible = true;
            this.colMonthlyExpenses.VisibleIndex = 3;
            this.colMonthlyExpenses.Width = 82;
            // 
            // colMonthlyTotal
            // 
            this.colMonthlyTotal.Caption = "Total";
            this.colMonthlyTotal.FieldName = "Total";
            this.colMonthlyTotal.MinWidth = 22;
            this.colMonthlyTotal.Name = "colMonthlyTotal";
            this.colMonthlyTotal.OptionsColumn.AllowEdit = false;
            this.colMonthlyTotal.Visible = true;
            this.colMonthlyTotal.VisibleIndex = 4;
            this.colMonthlyTotal.Width = 82;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(290, 10);
            this.textBox10.Margin = new System.Windows.Forms.Padding(2);
            this.textBox10.Name = "textBox10";
            this.textBox10.ReadOnly = true;
            this.textBox10.Size = new System.Drawing.Size(106, 23);
            this.textBox10.TabIndex = 21;
            this.textBox10.Text = "Statistics";
            this.textBox10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tabPane1
            // 
            this.tabPane1.AppearanceButton.Pressed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.tabPane1.AppearanceButton.Pressed.Options.UseBackColor = true;
            this.tabPane1.Controls.Add(this.tabManagers);
            this.tabPane1.Controls.Add(this.tabEngineers);
            this.tabPane1.Controls.Add(this.tabTasks);
            this.tabPane1.Controls.Add(this.tabTransactions);
            this.tabPane1.Controls.Add(this.tabStatistics);
            this.tabPane1.Controls.Add(this.tabCustomers);
            this.tabPane1.Location = new System.Drawing.Point(10, 9);
            this.tabPane1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPane1.Name = "tabPane1";
            this.tabPane1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.tabManagers,
            this.tabEngineers,
            this.tabCustomers,
            this.tabTasks,
            this.tabStatistics,
            this.tabTransactions});
            this.tabPane1.RegularSize = new System.Drawing.Size(690, 456);
            this.tabPane1.SelectedPage = this.tabManagers;
            this.tabPane1.Size = new System.Drawing.Size(690, 456);
            this.tabPane1.TabIndex = 23;
            this.tabPane1.Text = "tabPane1";
            // 
            // tabManagers
            // 
            this.tabManagers.Caption = "tabNavigationPage1";
            this.tabManagers.Controls.Add(this.grdManagers);
            this.tabManagers.Controls.Add(this.textBox1);
            this.tabManagers.Controls.Add(this.textBox7);
            this.tabManagers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabManagers.Name = "tabManagers";
            this.tabManagers.PageText = "Managers";
            this.tabManagers.Size = new System.Drawing.Size(690, 423);
            // 
            // tabEngineers
            // 
            this.tabEngineers.Caption = "tabNavigationPage2";
            this.tabEngineers.Controls.Add(this.textBox2);
            this.tabEngineers.Controls.Add(this.grdEngineers);
            this.tabEngineers.Controls.Add(this.textBox6);
            this.tabEngineers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabEngineers.Name = "tabEngineers";
            this.tabEngineers.PageText = "Engineers";
            this.tabEngineers.Size = new System.Drawing.Size(690, 456);
            // 
            // tabTasks
            // 
            this.tabTasks.Caption = "tabNavigationPage3";
            this.tabTasks.Controls.Add(this.grdServiceTasks);
            this.tabTasks.Controls.Add(this.textBox4);
            this.tabTasks.Controls.Add(this.textBox8);
            this.tabTasks.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabTasks.Name = "tabTasks";
            this.tabTasks.PageText = "Tasks";
            this.tabTasks.Size = new System.Drawing.Size(690, 456);
            // 
            // tabTransactions
            // 
            this.tabTransactions.Caption = "tabNavigationPage1";
            this.tabTransactions.Controls.Add(this.btnAddLine);
            this.tabTransactions.Controls.Add(this.btnAddTransaction);
            this.tabTransactions.Controls.Add(this.grdTransactions);
            this.tabTransactions.Controls.Add(this.textBox9);
            this.tabTransactions.Controls.Add(this.textBox3);
            this.tabTransactions.Controls.Add(this.textBox5);
            this.tabTransactions.Controls.Add(this.grdTransactionLines);
            this.tabTransactions.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabTransactions.Name = "tabTransactions";
            this.tabTransactions.PageText = "Transactions";
            this.tabTransactions.Size = new System.Drawing.Size(690, 456);
            // 
            // btnAddLine
            // 
            this.btnAddLine.Location = new System.Drawing.Point(293, 394);
            this.btnAddLine.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddLine.Name = "btnAddLine";
            this.btnAddLine.Size = new System.Drawing.Size(103, 27);
            this.btnAddLine.TabIndex = 25;
            this.btnAddLine.Text = "New Line";
            this.btnAddLine.Click += new System.EventHandler(this.btnAddLine_Click);
            // 
            // btnAddTransaction
            // 
            this.btnAddTransaction.Location = new System.Drawing.Point(293, 190);
            this.btnAddTransaction.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddTransaction.Name = "btnAddTransaction";
            this.btnAddTransaction.Size = new System.Drawing.Size(103, 27);
            this.btnAddTransaction.TabIndex = 24;
            this.btnAddTransaction.Text = "New Transaction";
            this.btnAddTransaction.Click += new System.EventHandler(this.btnAddTransaction_Click);
            // 
            // tabStatistics
            // 
            this.tabStatistics.Caption = "tabNavigationPage1";
            this.tabStatistics.Controls.Add(this.label1);
            this.tabStatistics.Controls.Add(this.simpleButton1);
            this.tabStatistics.Controls.Add(this.textBox10);
            this.tabStatistics.Controls.Add(this.dateTimePicker1);
            this.tabStatistics.Controls.Add(this.grdMonthlyLedger);
            this.tabStatistics.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabStatistics.Name = "tabStatistics";
            this.tabStatistics.PageText = "Statistics";
            this.tabStatistics.Size = new System.Drawing.Size(690, 456);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 352);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 15);
            this.label1.TabIndex = 25;
            this.label1.Text = "Specific Month:";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(572, 351);
            this.simpleButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(103, 27);
            this.simpleButton1.TabIndex = 24;
            this.simpleButton1.Text = "All Months";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // tabCustomers
            // 
            this.tabCustomers.Caption = "Customers";
            this.tabCustomers.Controls.Add(this.grdCustomers);
            this.tabCustomers.Name = "tabCustomers";
            this.tabCustomers.Size = new System.Drawing.Size(690, 423);
            // 
            // grdCustomers
            // 
            this.grdCustomers.Location = new System.Drawing.Point(3, 3);
            this.grdCustomers.MainView = this.grvCustomers;
            this.grdCustomers.Name = "grdCustomers";
            this.grdCustomers.Size = new System.Drawing.Size(687, 420);
            this.grdCustomers.TabIndex = 0;
            this.grdCustomers.UseEmbeddedNavigator = true;
            this.grdCustomers.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvCustomers});
            // 
            // grvCustomers
            // 
            this.grvCustomers.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCustomerId,
            this.colCustomerName,
            this.colCustomerSurname,
            this.colCustomerTIN,
            this.colCustomerPhone});
            this.grvCustomers.GridControl = this.grdCustomers;
            this.grvCustomers.Name = "grvCustomers";
            this.grvCustomers.OptionsView.ShowGroupPanel = false;
            this.grvCustomers.RowDeleting += new DevExpress.Data.RowDeletingEventHandler(this.grvCustomers_RowDeleting);
            this.grvCustomers.RowDeleted += new DevExpress.Data.RowDeletedEventHandler(this.grvCustomers_RowDeleted);
            // 
            // colCustomerId
            // 
            this.colCustomerId.Caption = "Id";
            this.colCustomerId.FieldName = "Id";
            this.colCustomerId.Name = "colCustomerId";
            // 
            // colCustomerName
            // 
            this.colCustomerName.Caption = "Name";
            this.colCustomerName.FieldName = "Name";
            this.colCustomerName.Name = "colCustomerName";
            this.colCustomerName.Visible = true;
            this.colCustomerName.VisibleIndex = 1;
            // 
            // colCustomerSurname
            // 
            this.colCustomerSurname.Caption = "Surname";
            this.colCustomerSurname.FieldName = "Surname";
            this.colCustomerSurname.Name = "colCustomerSurname";
            this.colCustomerSurname.Visible = true;
            this.colCustomerSurname.VisibleIndex = 2;
            // 
            // colCustomerTIN
            // 
            this.colCustomerTIN.Caption = "TIN";
            this.colCustomerTIN.FieldName = "TIN";
            this.colCustomerTIN.Name = "colCustomerTIN";
            this.colCustomerTIN.Visible = true;
            this.colCustomerTIN.VisibleIndex = 3;
            // 
            // colCustomerPhone
            // 
            this.colCustomerPhone.Caption = "Phone";
            this.colCustomerPhone.FieldName = "Phone";
            this.colCustomerPhone.Name = "colCustomerPhone";
            this.colCustomerPhone.Visible = true;
            this.colCustomerPhone.VisibleIndex = 4;
            // 
            // btnLoadFromSQL
            // 
            this.btnLoadFromSQL.Location = new System.Drawing.Point(428, 480);
            this.btnLoadFromSQL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLoadFromSQL.Name = "btnLoadFromSQL";
            this.btnLoadFromSQL.Size = new System.Drawing.Size(82, 27);
            this.btnLoadFromSQL.TabIndex = 24;
            this.btnLoadFromSQL.Text = "Load(SQL)";
            this.btnLoadFromSQL.Click += new System.EventHandler(this.btnLoadFromSQL_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 516);
            this.Controls.Add(this.btnLoadFromSQL);
            this.Controls.Add(this.tabPane1);
            this.Controls.Add(this.btnPopulate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnLoad);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrator";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grvManagers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdManagers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdEngineers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvEngineers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repManagers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repManagersView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdServiceTasks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvServiceTasks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdTransactions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvTransactions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repCars)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repManagers2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repTransactionLinesViewBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdTransactionLines)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvTransactionLines)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repTransactionLinesTasks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repTransactionLineEngineers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdMonthlyLedger)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvMonthlyLedger)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).EndInit();
            this.tabPane1.ResumeLayout(false);
            this.tabManagers.ResumeLayout(false);
            this.tabManagers.PerformLayout();
            this.tabEngineers.ResumeLayout(false);
            this.tabEngineers.PerformLayout();
            this.tabTasks.ResumeLayout(false);
            this.tabTasks.PerformLayout();
            this.tabTransactions.ResumeLayout(false);
            this.tabTransactions.PerformLayout();
            this.tabStatistics.ResumeLayout(false);
            this.tabStatistics.PerformLayout();
            this.tabCustomers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvCustomers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Alerter.AlertControl alertControl1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnSurname;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnSalary;
        private DevExpress.XtraGrid.Views.Grid.GridView grvManagers;
        private DevExpress.XtraGrid.Columns.GridColumn grdColName;
        private DevExpress.XtraGrid.Columns.GridColumn grdColSurname;
        private DevExpress.XtraGrid.Columns.GridColumn grdColSalary;
        private DevExpress.XtraGrid.GridControl grdManagers;
        private DevExpress.XtraGrid.GridControl grdEngineers;
        private DevExpress.XtraGrid.Views.Grid.GridView grvEngineers;
        private DevExpress.XtraGrid.Columns.GridColumn grdColEngineerName;
        private DevExpress.XtraGrid.Columns.GridColumn grdColEngineerSurname;
        private DevExpress.XtraGrid.Columns.GridColumn grdColEngineerManager;
        private DevExpress.XtraGrid.Columns.GridColumn grdColEngineerSalary;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repManagers;
        private DevExpress.XtraGrid.Views.Grid.GridView repManagersView;
        private DevExpress.XtraGrid.GridControl grdServiceTasks;
        private DevExpress.XtraGrid.Views.Grid.GridView grvServiceTasks;
        private DevExpress.XtraGrid.Columns.GridColumn colServiceTaskCode;
        private DevExpress.XtraGrid.Columns.GridColumn colServiceTaskDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colServiceTaskHours;
        private DevExpress.XtraGrid.GridControl grdTransactions;
        private DevExpress.XtraGrid.Views.Grid.GridView grvTransactions;
        private DevExpress.XtraGrid.Columns.GridColumn grdDate;
        private DevExpress.XtraGrid.Columns.GridColumn grdCustomerName;
        private DevExpress.XtraGrid.Columns.GridColumn grdCar;
        private DevExpress.XtraGrid.Columns.GridColumn grdManager;
        private DevExpress.XtraGrid.Columns.GridColumn grdTotalPrice;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repCustomers;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repCars;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repManagers2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.GridControl grdTransactionLines;
        private DevExpress.XtraGrid.Views.Grid.GridView grvTransactionLines;
        private DevExpress.XtraGrid.Columns.GridColumn colTransactionsViewBtn;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repTransactionLinesViewBtn;
        private DevExpress.XtraEditors.SimpleButton btnLoad;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnPopulate;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private TextBox textBox8;
        private TextBox textBox9;
        private DevExpress.XtraGrid.Columns.GridColumn colTransactionLinesServiceTask;
        private DevExpress.XtraGrid.Columns.GridColumn colTransactionLineEngineer;
        private DevExpress.XtraGrid.Columns.GridColumn colTransactionLinesHours;
        private DevExpress.XtraGrid.Columns.GridColumn colTransactionLinePricePerHour;
        private DevExpress.XtraGrid.Columns.GridColumn colTransactionLinePrice;
        private DateTimePicker dateTimePicker1;
        private DevExpress.XtraGrid.GridControl grdMonthlyLedger;
        private DevExpress.XtraGrid.Views.Grid.GridView grvMonthlyLedger;
        private TextBox textBox10;
        private DevExpress.XtraGrid.Columns.GridColumn colMonthlyYear;
        private DevExpress.XtraGrid.Columns.GridColumn colMonthlyMonth;
        private DevExpress.XtraGrid.Columns.GridColumn colMonthlyIncome;
        private DevExpress.XtraGrid.Columns.GridColumn colMonthlyExpenses;
        private DevExpress.XtraGrid.Columns.GridColumn colMonthlyTotal;
        private DevExpress.XtraBars.Navigation.TabPane tabPane1;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabManagers;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabEngineers;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabTasks;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabTransactions;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabStatistics;
        private DevExpress.XtraEditors.SimpleButton btnAddTransaction;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private Label label1;
        private DevExpress.XtraEditors.SimpleButton btnAddLine;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repTransactionLinesTasks;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repTransactionLineEngineers;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private DevExpress.XtraEditors.SimpleButton btnLoadFromSQL;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabCustomers;
        private DevExpress.XtraGrid.GridControl grdCustomers;
        private DevExpress.XtraGrid.Views.Grid.GridView grvCustomers;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerId;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerName;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerSurname;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerTIN;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerPhone;
    }
}