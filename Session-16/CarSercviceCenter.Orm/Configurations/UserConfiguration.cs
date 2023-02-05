using LibCarService;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection.Emit;
using System.Reflection.Metadata;

namespace CarSercviceCenter.Orm.Configurations {
    public class UserConfiguration : IEntityTypeConfiguration<User> {

        public void Configure(EntityTypeBuilder<User> builder) {
            //builder.ToTable("User");

            //builder.HasKey(user => user.Id);

            //builder.Property(user => user.Id).ValueGeneratedOnAdd();
            //builder.Property(user => user.Name).HasMaxLength(50).IsRequired(true);
            //builder.Property(user => user.Surname).HasMaxLength(50).IsRequired(true);
            
            //builder.Property("Discriminator").HasMaxLength(200);
            
           

            //builder.HasDiscriminator<string>("UserType")
            //.HasValue<Manager>("Manager")
            //.HasValue<Engineer>("Engineer")
            //.HasValue<Customer>("Customer");

            

            

            //builder.HasOne(customer => customer.User)
            //    .WithMany(user => user.Customers)
            //    .HasForeignKey(customer => customer.UserId)
            //    .OnDelete(DeleteBehavior.Restrict);

        }


    }
}
