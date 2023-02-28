using FuelStation.Model.Enums;
using Microsoft.EntityFrameworkCore;

namespace FuelStation.Model {
    [Index(nameof(Code), IsUnique = true)]
    public class Item {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public ItemType Type { get; set; }
        public decimal Price { get; set; }
        public decimal Cost { get; set;}

        //Relations
        public List<TransactionLine> TransactionLines { get; set; }

        public Item(string code, string description, ItemType type) {
            Code = code;
            Description = description;
            Type = type;
        }
    }
}
