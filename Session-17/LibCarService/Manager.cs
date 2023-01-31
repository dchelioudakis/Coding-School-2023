using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibCarService 
{
    public class Manager : EntityBase{
        // Since the Expenses and the Total in the Monthly Ledger are decimal... It`s better to have decimal SalaryPerMonth
        public string Name { get; set; }
        public string Surname { get; set; }
        public decimal SalaryPerMonth { get; set; }

        //Relations
        public Guid UserId { get; set; }
        public User User { get; set; } = null!;
        public List<Engineer> Engineers { get; set; }

        public Manager() : base()
        {
            Id = Guid.NewGuid();
        }
    }
}
