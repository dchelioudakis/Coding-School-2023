using FuelStation.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.Model {
    public class Employee {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime HireDateStart { get; set; }
        public DateTime HireDateEnd { get;set; }
        public decimal SalaryPerMonth { get; set; }
        public EmployeeType Type { get; set; }

        //Relations
        public List<Transaction> Transactions { get; set; }

        public Employee(string name, string surname, EmployeeType type) {
            Name = name;
            Surname = surname;
            Type = type;
        }
    }
}
