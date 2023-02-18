using FuelStation.Model.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.Model {
    public class Item {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public ItemType Type { get; set; }
        public decimal Price { get; set; }
        public decimal Cost { get; set;}

        public Item(string code, string description, ItemType type) {
            Code = code;
            Description = description;
            Type = type;
        }
    }
}
