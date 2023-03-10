using FuelStation.EF.Repositories;
using FuelStation.Model;
using FuelStation.Model.OptionsModel;
using System;
using System.Collections.Generic;

namespace FuelStation.Blazor.Server.Business {
    public class MonthlyLedgerCalculator {

        private StationSettings _stationSettings;
        public MonthlyLedgerCalculator(StationSettings stationSettings) {
            _stationSettings = stationSettings;
        }

        public List<MonthlyLedger> GetAllMonthlyLedgers(IList<Employee> employees, IList<Transaction> dbTransactions) {
            List<Transaction> transactions = dbTransactions as List<Transaction>;
            //TODO: settings
            int businessStartYear = 2016;
            int businessStartMonth = 1;

            int monthNow = DateTime.Now.Month;
            int yearNow = DateTime.Now.Year;

            decimal monthIncome, monthExpenses;

            List<MonthlyLedger> monthlyLedgerList = new List<MonthlyLedger>();

            for (int culcYear = businessStartYear; culcYear <= yearNow; culcYear++) {

                for (int culcMonth = 1; culcMonth <= 12; culcMonth++) {

                    if(culcYear == businessStartYear && businessStartMonth > 1) {
                        culcMonth = businessStartMonth;
                    }

                    if (culcYear == yearNow && culcMonth > monthNow) {
                        break;
                    }


                    monthIncome = CalculateMonthlyGrossSales(culcYear, culcMonth, transactions);
                    monthExpenses = CalculateMonthlySalaries(culcYear, culcMonth, employees) +
                        CalculateMonthlyItemsCost(culcYear, culcMonth, transactions) +
                        CalculateOtherExpenses();

                    MonthlyLedger monthlyLedger = new MonthlyLedger(culcYear, culcMonth, Math.Round(monthIncome,2), Math.Round(monthExpenses, 2));
                    monthlyLedgerList.Add(monthlyLedger);
                }
            }

            return monthlyLedgerList;
        }

        public decimal CalculateMonthlySalaries(int year, int month, IList<Employee> employees) {
            decimal expensesSum = 0;
            foreach (var employee in employees) {


                if (WorkedInMonth(year, month, employee)) {
                    if (WorkedWholeMonth(year, month, employee)) {
                        expensesSum += employee.SalaryPerMonth;
                    }
                    else {
                        expensesSum += PartOfMonthWorked(year, month, employee) * employee.SalaryPerMonth;
                    }
                }
                else {
                    expensesSum += 0;
                }
            }

            return expensesSum;

        }

        // method: calc incomes
        public decimal CalculateMonthlyGrossSales(int year, int month, List<Transaction> transactions) {
            decimal grossSales = 0;

            List<Transaction> transactionsThisMonth = transactions.FindAll(c => c.Date.Month == month).FindAll(c => c.Date.Year == year).ToList();

            foreach (var transaction in transactionsThisMonth) {
                grossSales += transaction.TotalValue;
            }

            return grossSales;
        }


        public decimal CalculateMonthlyItemsCost(int year, int month, List<Transaction> transactions) {
            decimal itemsCost = 0;

            List<Transaction> transactionsThisMonth = transactions.FindAll(c => c.Date.Month == month).FindAll(c => c.Date.Year == year).ToList();

            foreach (var transaction in transactionsThisMonth) {
                foreach (var line in transaction.TransactionLines) {
                    itemsCost += line.Quantity * line.Item.Cost;
                }
            }

            return itemsCost;
        }


        public decimal CalculateOtherExpenses() {
            decimal total = 0;

            //TODO: settings
            total += _stationSettings.RentingCost; //Rental

            return total;
        }


        public bool WorkedInMonth(int year, int month, Employee employee) {
            if (DateTime.Compare(new DateTime(year, month, 1), employee.HireDateStart) < 0) {
                return false;
            }

            return true;
        }

        public bool WorkedWholeMonth(int year, int month, Employee employee) {
            int monthDaysCount = DateTime.DaysInMonth(year, month);
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

        public decimal PartOfMonthWorked(int year, int month, Employee employee) {
            int monthDaysCount = DateTime.DaysInMonth(month, year);
            DateTime monthLastDayDate = new DateTime(year, month, monthDaysCount);

            TimeSpan hireEndToEndOfMonth = monthLastDayDate - (DateTime)employee.HireDateEnd;
            decimal daysOfMonthWorked = monthDaysCount - hireEndToEndOfMonth.Days;

            return Math.Round(daysOfMonthWorked / monthDaysCount, 2);
        }
    }
}
