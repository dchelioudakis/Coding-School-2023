using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibCarService
{
    public class Customer : EntityBase{
        public string Name { get; set; }
        public string Surname { get; set; }

        public string Phone { get; set; }
        public string TIN { get; set; }
        //Relations
        public Guid UserId { get; set; }
        public User User { get; set; } = null!;
        public Customer()
        {
            Id = Guid.NewGuid();
        }
    }
}
