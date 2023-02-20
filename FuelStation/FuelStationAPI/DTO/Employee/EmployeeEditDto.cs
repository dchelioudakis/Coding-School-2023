﻿using FuelStation.Model.Enums;

namespace FuelStationAPI.DTO.Employee {
    public class EmployeeEditDto {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime HireDateStart { get; set; }
        public DateTime? HireDateEnd { get; set; }
        public decimal SalaryPerMonth { get; set; }
        public EmployeeType Type { get; set; }
    }
}
