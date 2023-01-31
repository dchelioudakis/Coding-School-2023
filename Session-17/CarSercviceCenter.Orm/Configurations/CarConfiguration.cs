using LibCarService;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSercviceCenter.Orm.Configurations {
    public class CarConfiguration : IEntityTypeConfiguration<Car> {

        public void Configure(EntityTypeBuilder<Car> builder) {
            builder.ToTable("Car");

            builder.HasKey(car => car.Id);

            builder.Property(car => car.Id).ValueGeneratedOnAdd();
            builder.Property(car => car.Brand).HasMaxLength(20).IsRequired(true);
            builder.Property(car => car.Model).HasMaxLength(20).IsRequired(true);
            builder.Property(car => car.CarRegistrationNumber).HasMaxLength(7).IsRequired(true);

        }


    }
}
