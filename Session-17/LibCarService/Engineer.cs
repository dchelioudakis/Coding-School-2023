using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibCarService 
{
    public class Engineer : EntityBase {


        public string Name { get; set; }
        public string Surname { get; set; }

        public decimal SalaryPerMonth { get; set; }

        public Guid ManagerId { get; set; }
        public Manager Manager { get; set; } = null!;
        public Guid UserId { get; set; }
        public User User { get; set; } = null!;
        public Engineer() : base()
        {
            Id = Guid.NewGuid();
        }
    }
}
