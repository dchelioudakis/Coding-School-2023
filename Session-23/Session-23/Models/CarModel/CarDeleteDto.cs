using System.ComponentModel.DataAnnotations;

namespace Session_23.Models.CarModel {
    public class CarDeleteDto {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        [Display(Name = "Registration Number")]
        public string CarRegistrationNumber { get; set; }
    }
}
