using Microsoft.EntityFrameworkCore;
using System;

namespace FuelStation.Model {
    [Index(nameof(CardNumber), IsUnique = true)]
    public class Customer {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string CardNumber { get; set; }

        //Relations
        public List<Transaction> Transactions { get; set; }

        public Customer(string name, string surname) {
            Name = name;
            Surname = surname;
        }
    }
}