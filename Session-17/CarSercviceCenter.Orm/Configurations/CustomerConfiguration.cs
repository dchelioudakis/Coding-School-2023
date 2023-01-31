using LibCarService;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSercviceCenter.Orm.Configurations {
    public class CustomerConfiguration : IEntityTypeConfiguration<Customer> {

        public void Configure(EntityTypeBuilder<Customer> builder) {
            builder.ToTable("Customer");

            builder.HasKey(customer => customer.Id);

            builder.Property(customer => customer.Id).ValueGeneratedOnAdd();
            builder.Property(customer => customer.Name).HasMaxLength(50).IsRequired(true);
            builder.Property(customer => customer.Surname).HasMaxLength(50).IsRequired(true);
            builder.Property(customer => customer.Phone).HasMaxLength(50).IsRequired(true);
            builder.Property(customer => customer.TIN).HasMaxLength(9).IsRequired(true);

            builder.HasOne(customer => customer.User)
                 .WithMany(user => user.Customers)
                 .HasForeignKey(customer => customer.UserId);

        }


    }
}
