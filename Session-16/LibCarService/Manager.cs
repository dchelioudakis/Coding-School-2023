using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibCarService 
{
    public class Manager : User{
        
        public decimal SalaryPerMonth { get; set; }

        //Relations
        
        public List<Engineer> Engineers { get; set; }
        public List<Transaction> Transactions { get; set; }
        
        

        public Manager() : base() {
            //Id = Guid.NewGuid();
        }
    }
}
