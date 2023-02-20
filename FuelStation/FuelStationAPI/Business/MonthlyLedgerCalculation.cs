using FuelStation.Model;
using System;

namespace FuelStationAPI.Business {
    public class MonthlyLedgerCalculation {
        public decimal CalculateMonthlySalaries(IList<Employee> employees, int month, int year) {
            decimal expensesSum = 0;
            foreach (var employee in employees) {
                

                if(WorkedInMonth(employee, year, month)) {
                    if(WorkedWholeMonth(employee, year, month)) {
                        expensesSum += employee.SalaryPerMonth;
                    }
                    else {
                        expensesSum += PartOfMonthWorked(employee, year, month) * employee.SalaryPerMonth;
                    }
                }
                else {
                    expensesSum += 0;
                }
            }

            return expensesSum;

        }

        // method: calc incomes
        //public decimal CalculateMonthlyIncome(DateTime date, IList<Transaction> transactions) {
        //    int month = date.Month;
        //    int year = date.Year;
        //    decimal incomeSum = 0;

        //    List<Transaction> transactionsList = transactions as List<Transaction>;

        //    List<Transaction> transactionsThisMonth = transactionsList.FindAll(c => c.Date.Month == month).FindAll(c => c.Date.Year == year).ToList();

        //    foreach (Transaction transaction in transactionsThisMonth) {
        //        incomeSum += transaction.TotalPrice;
        //    }

        //    return incomeSum;
        //}


        //public List<MonthlyLedger> GetAllMonthlyLedgers(IList<Engineer> engineers, IList<Manager> managers, IList<Transaction> transactions) {
        //    int year = 2016;
        //    int month = 1;

        //    int monthNow = DateTime.Now.Month;
        //    int yearNow = DateTime.Now.Year;

        //    decimal monthIncome;
        //    decimal monthExpenses;

        //    List<MonthlyLedger> monthlyLedgerList = new List<MonthlyLedger>();

        //    for (int i = year; i <= yearNow; i++) {

        //        for (int j = 1; j <= 12; j++) {
        //            if (i == yearNow && j > monthNow) {
        //                break;
        //            }
        //            DateTime date = new DateTime(i, j, 1);
        //            MonthlyLedger monthlyLedger = new MonthlyLedger(date);
        //            monthIncome = CalculateMonthlyIncome(date, transactions);
        //            monthExpenses = CalculateMonthlySalaries(engineers, managers);
        //            monthlyLedger.UpdateLedger(monthIncome, monthExpenses);
        //            monthlyLedgerList.Add(monthlyLedger);
        //        }
        //    }

        //    return monthlyLedgerList;
        //}


        public bool WorkedInMonth(Employee employee, int year, int month) {
            if (DateTime.Compare(new DateTime(year, month, 1), employee.HireDateStart) < 0) {
                return false;
            }

            return true;
        }

        public bool WorkedWholeMonth(Employee employee, int year, int month) {
            int monthDaysCount = DateTime.DaysInMonth(month, year);
            DateTime monthLastDayDate = new DateTime(year, month, monthDaysCount);

            if (employee.HireDateEnd == null) {
                return true;
            }
            else {
                if (DateTime.Compare(monthLastDayDate, (DateTime)employee.HireDateEnd) < 0) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }

        public decimal PartOfMonthWorked(Employee employee, int year, int month) {
            int monthDaysCount = DateTime.DaysInMonth(month, year);
            DateTime monthLastDayDate = new DateTime(year, month, monthDaysCount);

            TimeSpan hireEndToEndOfMonth = monthLastDayDate - (DateTime)employee.HireDateEnd;
            decimal daysOfMonthWorked = (decimal)(monthDaysCount - hireEndToEndOfMonth.Days);
            
            return Math.Round(daysOfMonthWorked/monthDaysCount, 2);
        }
    }
}
