using System.ComponentModel.DataAnnotations;

namespace Session_23.Models.CustomerModel {
    public class CustomerCreateDto {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Tin { get; set; }
        public string Phone { get; set; }
    }
}
