using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibCarService
{
    public class Transaction : EntityBase
    {
        public DateTime Date { get; set; }

        public Customer Customer { get; set; }
        public Guid CustomerId { get; set; }
        public Car Car { get; set; }
        public Guid CarId { get; set; }
        public Manager Manager { get; set; }
        public Guid ManagerId { get; set; }
        public decimal TotalPrice { get; set; }
        public List<TransactionLine> TransactionLines { get; set; } = new List<TransactionLine>();


        public Transaction()
        {
            Id = Guid.NewGuid();
        }


        public void AddTransactionLine(ServiceTask serviceTask, Engineer engineer, decimal pricePerHr) {
            TransactionLine newLine = new TransactionLine();
            newLine.TransactionId = Id;
            newLine.ServiceTaskId = serviceTask.Id;
            newLine.EngineerId = engineer.Id;
            newLine.Hours = serviceTask.Hours;
            newLine.PricePerHour = pricePerHr;
            newLine.Price = newLine.Hours * newLine.PricePerHour;

            TransactionLines.Add(newLine);
            UpdateTotalPrice();
        }

        public void UpdateTotalPrice() {
            TotalPrice = 0;
            foreach(TransactionLine line in TransactionLines) {
                TotalPrice += line.Price;
            }
        }


    }
}
