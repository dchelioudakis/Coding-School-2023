using System.ComponentModel.DataAnnotations;

namespace Session_23.Models.Manager {
    public class ManagerEditDto {
        public int Id { get; set; }
        [MaxLength(20, ErrorMessage = "Too long value")]
        public string Name { get; set; }
        [MaxLength(20, ErrorMessage = "Too long value")]
        public string Surname { get; set; }

        public int SalaryPerMonth { get; set; }
    }
}
