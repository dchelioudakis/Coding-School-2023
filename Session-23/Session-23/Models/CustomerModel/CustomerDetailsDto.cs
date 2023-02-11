using CarServiceCenter.Model;

namespace Session_23.Models.CustomerModel {
    public class CustomerDetailsDto {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Tin { get; set; }
        public string Phone { get; set; }
        public List<Transaction> Transactions { get; set; }
    }
}
