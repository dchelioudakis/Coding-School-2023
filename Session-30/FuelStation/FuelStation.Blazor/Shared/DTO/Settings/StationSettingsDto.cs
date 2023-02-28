namespace FuelStation.Blazor.Shared.DTO.Settings {
    public class StationSettingsDto {
        public int Id { get; set; }
        public decimal RentingCost { get; set; }
        public int ManagerMaxCount { get; set; }
        public int ManagerMinCount { get; set; }
        public int CashierMaxCount { get; set; }
        public int CashierMinCount { get; set; }
        public int StaffMaxCount { get; set; }
        public int StaffMinCount { get; set; }
    }
}
