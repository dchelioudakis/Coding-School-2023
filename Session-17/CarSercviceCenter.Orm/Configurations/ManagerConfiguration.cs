using LibCarService;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection.Emit;

namespace CarSercviceCenter.Orm.Configurations
{
    public class ManagerConfiguration : IEntityTypeConfiguration<Manager> {

        public void Configure(EntityTypeBuilder<Manager> builder) {
            builder.ToTable("Manager");

            builder.HasKey(manager => manager.Id);

            builder.Property(manager => manager.Id).ValueGeneratedOnAdd();
            builder.Property(manager => manager.Name).HasMaxLength(50).IsRequired(true);
            builder.Property(manager => manager.Surname).HasMaxLength(50).IsRequired(true);
            builder.Property(manager => manager.SalaryPerMonth).HasMaxLength(50).IsRequired(true);

            builder.HasOne(manager => manager.User)
                 .WithMany(user => user.Managers)
                 .HasForeignKey(manager => manager.UserId)
                 .OnDelete(DeleteBehavior.Restrict);
        }


    }
}
