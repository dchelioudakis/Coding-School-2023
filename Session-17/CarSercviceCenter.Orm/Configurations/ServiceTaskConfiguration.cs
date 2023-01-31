using LibCarService;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSercviceCenter.Orm.Configurations {
    public class ServiceTaskConfiguration : IEntityTypeConfiguration<ServiceTask> {

        public void Configure(EntityTypeBuilder<ServiceTask> builder) {
            builder.ToTable("ServiceTask");

            builder.HasKey(task => task.Id);

            builder.Property(task => task.Id).ValueGeneratedOnAdd();
            builder.Property(task => task.Code).HasMaxLength(20).IsRequired(true);
            builder.Property(task => task.Description).HasMaxLength(50).IsRequired(true);
            builder.Property(task => task.Hours).HasMaxLength(5).IsRequired(true);



        }


    }
}
