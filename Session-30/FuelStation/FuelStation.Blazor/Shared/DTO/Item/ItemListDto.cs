using FuelStation.Model.Enums;

namespace FuelStation.Blazor.Shared.DTO.Item {
    public class ItemListDto {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public ItemType Type { get; set; }
        public decimal Price { get; set; }
        public decimal Cost { get; set; }
    }
}
