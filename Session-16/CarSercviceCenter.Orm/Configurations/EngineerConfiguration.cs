using LibCarService;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSercviceCenter.Orm.Configurations {
    public class EngineerConfiguration : IEntityTypeConfiguration<Engineer> {

        public void Configure(EntityTypeBuilder<Engineer> builder) {
            builder.ToTable("Engineer");

            builder.HasKey(engineer => engineer.Id);

            builder.Property(engineer => engineer.Id).ValueGeneratedOnAdd();
            builder.Property(engineer => engineer.Name).HasMaxLength(50).IsRequired(true);
            builder.Property(engineer => engineer.Surname).HasMaxLength(50).IsRequired(true);
            builder.Property(engineer => engineer.SalaryPerMonth).HasMaxLength(50).IsRequired(true);

            builder.HasOne(engineer => engineer.User)
                 .WithMany(user => user.Engineers)
                 .HasForeignKey(engineer => engineer.UserId)
                 .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(engineer => engineer.Manager)
                 .WithMany(manager => manager.Engineers)
                 .HasForeignKey(engineer => engineer.ManagerId);
        }


    }
}
