using CarSercviceCenter.Orm.Repositories;
using DevExpress.ClipboardSource.SpreadsheetML;
using DevExpress.Office.Utils;
using DevExpress.Utils;
using DevExpress.XtraExport.Helpers;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.BandedGrid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraWaitForm;
using LibCarService;
using LibSerializer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using static LibCarService.ServiceTask;
using GridView = DevExpress.XtraGrid.Views.Grid.GridView;
using Transaction = LibCarService.Transaction;

namespace Session_16 {
    public partial class AdminForm : Form {


        private UserRepo _userRepo = new UserRepo();
        private CustomerRepo _customerRepo = new CustomerRepo();
        private EngineerRepo _engineerRepo = new EngineerRepo();

        CarServiceCenter carServiceCenter;
        //Settings formSettings;
        public AdminForm(LoginForm mainForm) {
            InitializeComponent();
            carServiceCenter = mainForm.CarServiceCenter;
        }

        private void AdminForm_Load(object sender, EventArgs e) {
            carServiceCenter = new CarServiceCenter();
            //carServiceCenter.Settings = new Settings();
            //carServiceCenter.Settings.PricePerHour = 45.5M;
            LoadToGrids();
        }

        private void PopulateCarCenter() {

            //carServiceCenter = new CarServiceCenter();
            DummyCarMech data = new();
            carServiceCenter.Customers = data.Customers;
            carServiceCenter.Cars = data.Cars;
            carServiceCenter.Managers = data.Managers;
            carServiceCenter.Engineers = data.Engineers;
            carServiceCenter.ServiceTasks = data.ServiceTasks;
            carServiceCenter.Transactions = data.Transactions;
            carServiceCenter.TransactionLines = data.TransactionLines;

        }
        private void LoadToGrids() {
            BindingList<Manager> managers = new BindingList<Manager>(carServiceCenter.Managers);
            grdManagers.DataSource = new BindingSource() { DataSource = managers };

            BindingList<Customer> customers = new BindingList<Customer>(carServiceCenter.Customers);
            grdCustomers.DataSource = new BindingSource() { DataSource = customers };

            BindingList<Engineer> engineers = new BindingList<Engineer>(carServiceCenter.Engineers);
            grdEngineers.DataSource = new BindingSource() { DataSource = engineers };

            repManagers.DataSource = new BindingSource() { DataSource = managers };
            repManagers.DisplayMember = "Name";
            repManagers.ValueMember = "ID";
            repManagersView.Assign(grdManagers.MainView, false);

            BindingList<ServiceTask> serviceTasks = new BindingList<ServiceTask>(carServiceCenter.ServiceTasks);
            grdServiceTasks.DataSource = new BindingSource() { DataSource = serviceTasks };

            BindingList<LibCarService.Transaction> transactions = new BindingList<LibCarService.Transaction>(carServiceCenter.Transactions);
            grdTransactions.DataSource = new BindingSource() { DataSource = transactions };

            BindingList<Car> cars = new BindingList<Car>(carServiceCenter.Cars);
            repCars.DataSource = new BindingSource() { DataSource = cars };
            repCars.DisplayMember = "Model";
            repCars.ValueMember = "ID";

            
            repCustomers.DataSource = new BindingSource() { DataSource = customers };
            repCustomers.DisplayMember = "Surname";
            repCustomers.ValueMember = "ID";
            
            

            repManagers2.DataSource = new BindingSource() { DataSource = managers };
            repManagers2.DisplayMember = "Surname";
            repManagers2.ValueMember = "ID";
            gridView2.Assign(grdManagers.MainView, false);

            
        }


        private void grvServiceTasks_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e) {
            if (e.Column.Caption == "Code") {
                MessageBox.Show(e.RowHandle.ToString());

                switch (e.Value) {
                    case CodeEnum.OilChange:
                        grvServiceTasks.SetRowCellValue(e.RowHandle, "Description", "Change the oils");
                        grvServiceTasks.SetRowCellValue(e.RowHandle, "Hours", 1.5M);
                        break;
                    case CodeEnum.TireChange:
                        grvServiceTasks.SetRowCellValue(e.RowHandle, "Description", "Change the tire");
                        grvServiceTasks.SetRowCellValue(e.RowHandle, "Hours", 2.5M);
                        break;
                    case CodeEnum.BrokenWindow:
                        grvServiceTasks.SetRowCellValue(e.RowHandle, "Description", "Fix the broken window");
                        grvServiceTasks.SetRowCellValue(e.RowHandle, "Hours", 1.25M);
                        break;
                    case CodeEnum.EngineChange:
                        grvServiceTasks.SetRowCellValue(e.RowHandle, "Description", "Change the engine");
                        grvServiceTasks.SetRowCellValue(e.RowHandle, "Hours", 5M);
                        break;
                    case CodeEnum.MirrorReplacement:
                        grvServiceTasks.SetRowCellValue(e.RowHandle, "Description", "Replace the mirror");
                        grvServiceTasks.SetRowCellValue(e.RowHandle, "Hours", 0.5M);
                        break;
                    default:
                        break;
                }



            }
        }
        

        private void repTransactionLinesViewBtn_Click(object sender, EventArgs e) {
            //Gets All Transaction Lines of a Transaction
            
            //List<TransactionLine> allTransactionLines = new List<TransactionLine>(carServiceCenter.TransactionLines);
            int row = grvTransactions.GetFocusedDataSourceRowIndex();
            Guid currentTranstactionID = (Guid)grvTransactions.GetRowCellValue(row, "ID");
            List<TransactionLine> currentTransactionLines = new List<TransactionLine>();
            //currentTransactionLines = allTransactionLines.FindAll(c =>c.TransactionID == currentTranstactionID).ToList();
            Transaction curremtTransaction = carServiceCenter.Transactions.Find(c => c.Id == currentTranstactionID);
            

            BindingList<TransactionLine> transactionLines = new BindingList<TransactionLine>(curremtTransaction.TransactionLines);
            grdTransactionLines.DataSource = new BindingSource() { DataSource = transactionLines };



            BindingList<ServiceTask> serviceTasks = new BindingList<ServiceTask>(carServiceCenter.ServiceTasks);
            BindingList<Engineer> engineers = new BindingList<Engineer>(carServiceCenter.Engineers);


            repTransactionLinesTasks.DataSource = new BindingSource() { DataSource = serviceTasks };
            repTransactionLinesTasks.DisplayMember = "Code";
            repTransactionLinesTasks.ValueMember = "ID";


            repTransactionLineEngineers.DataSource = new BindingSource() { DataSource = engineers };
            repTransactionLineEngineers.DisplayMember = "Surname";
            repTransactionLineEngineers.ValueMember = "ID";



        }

        private void btnLoad_Click(object sender, EventArgs e) {
            string fileName = "carServiceCenter.json";

            Serializer serializer = new Serializer();

            if (File.Exists(fileName)) {
                carServiceCenter = serializer.Deserialize<CarServiceCenter>("carServiceCenter.json");
                if (carServiceCenter != null) {
                    LoadToGrids();
                }
                else {
                    MessageBox.Show("File is empty");
                }
            }
            else {
                MessageBox.Show("File not Found");
            }
        }

        private void btnSave_Click(object sender, EventArgs e) {
            Serializer serializer = new Serializer();
            serializer.SerializeToFile(carServiceCenter, "carServiceCenter.json");

            MessageBox.Show("Data Saved!");
        }

        private void btnPopulate_Click(object sender, EventArgs e) {
            PopulateCarCenter();
            LoadToGrids();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e) {
            DateTime date = dateTimePicker1.Value;
            MonthlyLedger monthlyLedger = new MonthlyLedger(date);

            decimal monthIncome = carServiceCenter.CalculateMonthlyIncome(date);
            decimal monthExpenses = carServiceCenter.CalculateMonthlyExpenses();
            monthlyLedger.UpdateLedger(monthIncome, monthExpenses);
            List<MonthlyLedger>  monthlyLedgerList = new List<MonthlyLedger>();
            monthlyLedgerList.Add(monthlyLedger);

            grdMonthlyLedger.DataSource = monthlyLedgerList;

        }

        private void btnAddTransaction_Click(object sender, EventArgs e) {
            if(carServiceCenter == null) {
                MessageBox.Show("No data");
                return;
            }
            
            if (carServiceCenter.DailyTasksAvailability()) {
                grvTransactions.AddNewRow();
            }
            else {
                MessageBox.Show("No engineer available today");
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e) {
            int year = 2016;
            int month = 1;

            int monthNow = DateTime.Now.Month;
            int yearNow = DateTime.Now.Year;

            decimal monthIncome;
            decimal monthExpenses;

            List<MonthlyLedger> monthlyLedgerList = new List<MonthlyLedger>();

            for (int i = year; i <= yearNow; i++) {

                for (int j = 1; j <= 12; j++) {
                    if(i == yearNow && j > monthNow) {
                        break; 
                    }
                    DateTime date = new DateTime(i, j, 1);
                    MonthlyLedger monthlyLedger = new MonthlyLedger(date);
                    monthIncome = carServiceCenter.CalculateMonthlyIncome(date);
                    monthExpenses = carServiceCenter.CalculateMonthlyExpenses();
                    monthlyLedger.UpdateLedger(monthIncome, monthExpenses);
                    monthlyLedgerList.Add(monthlyLedger);
                }
            }

            grdMonthlyLedger.DataSource = monthlyLedgerList;

        }

        private void btnAddLine_Click(object sender, EventArgs e) {
            //GridColumn column = grvTransactionLines.Columns[0] as GridColumn;
            //column.OptionsColumn.ReadOnly = false;

            grvTransactionLines.AddNewRow();
        }

        private void grvManagers_RowUpdated(object sender, RowObjectEventArgs e) {
            if (grvManagers.IsNewItemRow(e.RowHandle)) {
                int rowHandle = grvManagers.DataRowCount - 1;

                AddUserTypeEntityToDB(UserTypeEnum.Customer, rowHandle);
            }
        }

        private void AddUserTypeEntityToDB(UserTypeEnum enumVal, int rowHandle) {

            Guid newUserId = Guid.NewGuid();
            _userRepo.Add(new User() {
                Id = newUserId,
            });

            switch (enumVal) {
                case UserTypeEnum.Manager:
                    break;
                case UserTypeEnum.Engineer:
                    break;
                case UserTypeEnum.Customer:
                    var newCustomer = new Customer() {
                        Name = grvCustomers.GetRowCellValue(rowHandle, "Name").ToString(),
                        Surname = grvCustomers.GetRowCellValue(rowHandle, "Surname").ToString(),
                        Phone = grvCustomers.GetRowCellValue(rowHandle, "Phone").ToString(),
                        TIN = grvCustomers.GetRowCellValue(rowHandle, "TIN").ToString(),
                        UserId = newUserId
                    };

                    _customerRepo.Add(newCustomer);
                    break;
                default:
                    break;
            }

        }

        private void btnLoadFromSQL_Click(object sender, EventArgs e) {
            carServiceCenter.Customers.Clear();
            carServiceCenter.Customers.AddRange(_customerRepo.GetAll());
            LoadToGrids();
        }

        private void grvCustomers_RowDeleting(object sender, DevExpress.Data.RowDeletingEventArgs e) {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete the selected customer;", "Customer Deletion", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes) {
                try {
                    Guid deletingCustomerID = (Guid)grvCustomers.GetRowCellValue(e.RowHandle, "Id");
                    _customerRepo.Delete(deletingCustomerID);

                    e.Cancel = false;
                }
                catch (Exception ex) {
                    e.Cancel = true;
                    MessageBox.Show("An internal error occured. Unsuccesful record delete");
                }
            }
            else if (dialogResult == DialogResult.No) {
                e.Cancel = true;
            }   
        }

        private void grvCustomers_RowDeleted(object sender, DevExpress.Data.RowDeletedEventArgs e) {
            MessageBox.Show("Customer Removed Succesfully");
        }
    }
}
