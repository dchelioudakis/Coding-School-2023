using CarServiceCenter.Model;

namespace Session_23.Models.EngineerModel {
    public class EngineerDetailsDto {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Surname { get; set; } = null!;
        public int SalaryPerMonth { get; set; }
        public int ManagerId { get; set; }
        public Manager Manager { get; set; }
        public List<TransactionLine> TransactionLines { get; set; }
    }
}
