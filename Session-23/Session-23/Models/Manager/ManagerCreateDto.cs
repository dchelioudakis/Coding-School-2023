using System.ComponentModel.DataAnnotations;

namespace Session_23.Models.Manager {
    public class ManagerCreateDto {

        //[MaxLength(10, ErrorMessage = "Πολύ μεγάλος Τίτλος")]
        public string Name { get; set; } = null!;
        public string Surname { get; set; } = null!;
        public int SalaryPerMonth { get; set; }
    }
}
