
using CarServiceCenter.Model;
using System.ComponentModel.DataAnnotations;

namespace Session_23.Models.ManagerModel {
    public class ManagerDetailsDto {

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Surname { get; set; } = null!;

        public int SalaryPerMonth { get; set; }

        public List<Engineer> Engineers { get; set; } = new List<Engineer>();
        public List<Transaction> Transactions { get; set; } = new List<Transaction>();
    }
}
