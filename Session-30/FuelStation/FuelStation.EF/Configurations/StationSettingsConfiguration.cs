using FuelStation.Model;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FuelStation.Model.OptionsModel;

namespace FuelStation.EF.Configurations {
    public class StationSettingsConfiguration : IEntityTypeConfiguration<StationSettings> {
        public void Configure(EntityTypeBuilder<StationSettings> builder) {
            // Table Name
            builder.ToTable("Settings");

            // Primary Key
            builder.HasKey(t => t.Id);
            builder.Property(t => t.Id).ValueGeneratedOnAdd();

            // Properties
            builder.Property(t => t.RentingCost).HasPrecision(10, 2).IsRequired();
            builder.Property(t => t.ManagerMinCount).IsRequired();
            builder.Property(t => t.ManagerMaxCount).IsRequired();
            builder.Property(t => t.CashierMinCount).IsRequired();
            builder.Property(t => t.CashierMaxCount).IsRequired();
            builder.Property(t => t.StaffMinCount).IsRequired();
            builder.Property(t => t.StaffMaxCount).IsRequired();

            // Relations
        }
    }
}

