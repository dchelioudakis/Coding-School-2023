namespace FuelStation.Blazor.Shared.DTO.TransactionLine {
    public class TransactionLineEditDto {
        public int Id { get; set; }
        public decimal Quantity { get; set; }
        public decimal ItemPrice { get; set; }
        public decimal NetValue { get; set; }
        public decimal DiscountPercent { get; set; }
        public decimal DiscountValue { get; set; }
        public decimal TotalValue { get; set; }

        //Relations
        public int TransactionId { get; set; }
        public int ItemId { get; set; }
    }
}
