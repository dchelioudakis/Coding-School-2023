using CarServiceCenter.Model;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Session_23.Models.TransactionLineModel {
    public class TransactionLineDetailsDto {
        public int Id { get; set; }
        public decimal Hours { get; set; }
        public decimal PricePerHour { get; set; }
        public decimal Price { get; set; }

        public int TransactionId { get; set; }
        public Transaction Transaction { get; set; }

        public int ServiceTaskId { get; set; }
        public ServiceTask ServiceTask { get; set; }

        public int EngineerId { get; set; }
        public Engineer Engineer { get; set; }
    }
}
