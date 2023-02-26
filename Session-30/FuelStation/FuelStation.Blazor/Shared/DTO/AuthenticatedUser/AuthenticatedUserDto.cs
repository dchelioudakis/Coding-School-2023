using FuelStation.Model.Enums;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.Blazor.Shared.DTO.AuthenticatedUser {
    public class AuthenticatedUserDto {
        public int Id { get; set; }
        public EmployeeType Type { get; set; }
    }
}
