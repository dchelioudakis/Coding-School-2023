using CarServiceCenter.Model;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Session_23.Models.TransactionModel {
    public class TransactionEditDto {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public decimal TotalPrice { get; set; }

        // Relations
        public int CustomerId { get; set; }
        public List<SelectListItem> Customers { get; } = new List<SelectListItem>();

        public int ManagerId { get; set; }
        public List<SelectListItem> Managers { get; } = new List<SelectListItem>();

        public int CarId { get; set; }
        public List<SelectListItem> Cars { get; } = new List<SelectListItem>();

        //public List<TransactionLine> TransactionLines { get; set; }
    }
}
