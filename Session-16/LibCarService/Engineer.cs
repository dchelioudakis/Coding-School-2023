using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibCarService 
{
    public class Engineer : User {

        public decimal SalaryPerMonth { get; set; }

        public Guid ManagerId { get; set; }
        public Manager Manager { get; set; }

        public List<TransactionLine> TransactionLines { get; set; }


        public Engineer() : base(){
            //Id = Guid.NewGuid();
        }
    }
}
