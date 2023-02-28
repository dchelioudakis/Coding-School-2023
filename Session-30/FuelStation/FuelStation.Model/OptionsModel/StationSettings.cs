using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.Model.OptionsModel {
    public class StationSettings {
        public int Id { get; set; }
        public decimal RentingCost { get; set; }
        public int ManagerMaxCount { get; set; }
        public int ManagerMinCount { get; set;}
        public int CashierMaxCount { get; set; }
        public int CashierMinCount { get;set; }
        public int StaffMaxCount { get; set; }
        public int StaffMinCount { get; set; }

        public StationSettings() {

        }
    }
}
