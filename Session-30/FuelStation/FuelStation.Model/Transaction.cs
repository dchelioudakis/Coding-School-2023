using FuelStation.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.Model {
    public class Transaction {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public decimal TotalValue { get; set; }

        //Relations
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        
        public List<TransactionLine> TransactionLines { get; set; }

        public Transaction(DateTime date, int employeeId, int customerId, PaymentMethod paymentMethod, decimal totalValue) {
            Date = date;
            EmployeeId = employeeId;
            CustomerId = customerId;
            PaymentMethod = paymentMethod;
            TotalValue = totalValue;
        }
    }
}
