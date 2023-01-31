using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibCarService;

namespace CarSercviceCenter.Orm.Configurations {
    public class TransactionLineConfiguration : IEntityTypeConfiguration<TransactionLine> {

        public void Configure(EntityTypeBuilder<TransactionLine> builder) {
            builder.ToTable("TransactionLine");

            builder.HasKey(line => line.Id);

            builder.Property(line => line.Id).ValueGeneratedOnAdd();
            builder.Property(line => line.PricePerHour).IsRequired(true);
            builder.Property(line => line.Price).IsRequired(true);


            builder.HasOne(line => line.Transaction)
                 .WithMany(transaction => transaction.TransactionLines)
                 .HasForeignKey(line => line.TransactionId)
                 .OnDelete(DeleteBehavior.Restrict); 

            builder.HasOne(line => line.Engineer)
                 .WithMany(engineer => engineer.TransactionLines)
                 .HasForeignKey(line => line.EngineerId);


            builder.HasOne(line => line.ServiceTask)
                 .WithMany(task => task.TransactionLines)
                 .HasForeignKey(line => line.ServiceTaskId);

        }


    }
}
