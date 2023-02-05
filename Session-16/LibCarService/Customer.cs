using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibCarService
{
    public class Customer : User{
        
        public string Phone { get; set; }
        public string TIN { get; set; }
        //Relations
        

        public List<Transaction> Transactions { get; set; }

        public Customer() : base(){

        }
    }
}
