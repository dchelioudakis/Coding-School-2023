using FuelStation.Model.Enums;
using FuelStation.Model;

namespace FuelStationWebClient.DTO.Transaction {
    public class TransactionListDto {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public decimal TotalValue { get; set; }

        //Relations
        public int EmployeeId { get; set; }
        public int CustomerId { get; set; }
        
        
    }
}
