using FuelStation.Model.Enums;
using FuelStation.Model;
using FuelStation.Blazor.Shared.DTO.TransactionLine;
using FuelStation.Blazor.Shared.DTO.Customer;

namespace FuelStation.Blazor.Shared.DTO.Transaction {
    public class TransactionEditDto {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public decimal TotalValue { get; set; }

        //Relations
        public int EmployeeId { get; set; }
        public int CustomerId { get; set; }
        public CustomerEditDto Customer { get; set; }
        
        public List<TransactionLineEditDto> TransactionLines { get; set; }
    }
}
