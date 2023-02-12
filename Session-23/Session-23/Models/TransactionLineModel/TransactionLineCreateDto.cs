using CarServiceCenter.Model;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Session_23.Models.TransactionLineModel {
    public class TransactionLineCreateDto {
        public decimal Hours { get; set; }
        public decimal PricePerHour { get; set; }
        public decimal Price { get; set; }



        public int TransactionId { get; set; }

        public int ServiceTaskId { get; set; }
        public List<SelectListItem> ServiceTasks { get; } = new List<SelectListItem>();

        public int EngineerId { get; set; }
        public List<SelectListItem> Engineers { get; } = new List<SelectListItem>();
    }
}
