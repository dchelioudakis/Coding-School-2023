using FuelStation.Model.Enums;

namespace FuelStationAPI.DTO.Item {
    public class ItemEditDto {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public ItemType Type { get; set; }
        public decimal Price { get; set; }
        public decimal Cost { get; set; }
    }
}
