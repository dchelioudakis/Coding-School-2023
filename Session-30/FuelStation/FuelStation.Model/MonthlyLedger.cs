using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.Model {
    public class MonthlyLedger {
        public DateTime Year { get; set; }
        public DateTime Month { get; set; }
        public decimal Income { get; set; }
        public decimal Expenses { get; set; }
        public decimal Total { get; set; }
        public MonthlyLedger(DateTime year, DateTime month, decimal income, decimal expenses) {
            Year = year;
            Month = month;
            Income = income;
            Expenses = expenses;
            Total = income - expenses;
        }
    }
}
