using CarServiceCenter.Model;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Session_23.Models.EngineerModel {
    public class EngineerCreateDto {

        public string Name { get; set; } = null!;
        public string Surname { get; set; } = null!;
        public int SalaryPerMonth { get; set; }
        public int ManagerId { get; set; }
        public List<SelectListItem> Managers { get; } = new List<SelectListItem>();
    }
}
