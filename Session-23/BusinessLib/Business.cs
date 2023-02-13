using CarServiceCenter.Model;

namespace BusinessLib {

    public class Business {

        public decimal CalculateMonthlySalaries(IList<Engineer> engineers, IList<Manager> managers) {
            decimal expensesSum = 0;
            foreach (Engineer engineer in engineers) {
                expensesSum += engineer.SalaryPerMonth;
            }
            foreach (Manager manager in managers) {
                expensesSum += manager.SalaryPerMonth;
            }

            return expensesSum;

        }

        // method: calc incomes
        public decimal CalculateMonthlyIncome(DateTime date, IList<Transaction> transactions) {
            int month = date.Month;
            int year = date.Year;
            decimal incomeSum = 0;

            List<Transaction> transactionsList = transactions as List<Transaction>;

            List<Transaction> transactionsThisMonth = transactionsList.FindAll(c => c.Date.Month == month).FindAll(c => c.Date.Year == year).ToList();

            foreach (Transaction transaction in transactionsThisMonth) {
                incomeSum += transaction.TotalPrice;
            }

            return incomeSum;
        }


        public List<MonthlyLedger> GetAllMonthlyLedgers(IList<Engineer> engineers, IList<Manager> managers, IList<Transaction> transactions) {
            int year = 2016;
            int month = 1;

            int monthNow = DateTime.Now.Month;
            int yearNow = DateTime.Now.Year;

            decimal monthIncome;
            decimal monthExpenses;

            List<MonthlyLedger> monthlyLedgerList = new List<MonthlyLedger>();

            for (int i = year; i <= yearNow; i++) {

                for (int j = 1; j <= 12; j++) {
                    if (i == yearNow && j > monthNow) {
                        break;
                    }
                    DateTime date = new DateTime(i, j, 1);
                    MonthlyLedger monthlyLedger = new MonthlyLedger(date);
                    monthIncome = CalculateMonthlyIncome(date, transactions);
                    monthExpenses = CalculateMonthlySalaries(engineers, managers);
                    monthlyLedger.UpdateLedger(monthIncome, monthExpenses);
                    monthlyLedgerList.Add(monthlyLedger);
                }
            }

            return monthlyLedgerList;
        }

    }
}