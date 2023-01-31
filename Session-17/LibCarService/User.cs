using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibCarService 
{
    public class User : EntityBase
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public List<Manager> Managers { get; set; }
        public List<Engineer> Engineers { get; set; }
        public List<Customer> Customers { get; set; }

        //public string Username { get; set; }
        //public string Password { get; set; }

        public User(){
            Id = Guid.NewGuid();
        }
    }
}
