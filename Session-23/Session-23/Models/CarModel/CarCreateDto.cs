using System.ComponentModel.DataAnnotations;

namespace Session_23.Models.CarModel {
    public class CarCreateDto {

        public string Brand { get; set; }
        public string Model { get; set; }
        [Display(Name = "Registration Number")]
        public string CarRegistrationNumber { get; set; }
    }
}
