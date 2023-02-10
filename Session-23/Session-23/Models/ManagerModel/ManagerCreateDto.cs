using System.ComponentModel.DataAnnotations;

namespace Session_23.Models.ManagerModel {
    public class ManagerCreateDto {

        [MaxLength(20, ErrorMessage = "Too long value")]
        public string Name { get; set; } = null!;
        [MaxLength(20, ErrorMessage = "Too long value")]
        public string Surname { get; set; } = null!;

        public int SalaryPerMonth { get; set; }
    }
}
