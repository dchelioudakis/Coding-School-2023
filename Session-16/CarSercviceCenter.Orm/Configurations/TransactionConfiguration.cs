using LibCarService;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSercviceCenter.Orm.Configurations {
    public class TransactionConfiguration : IEntityTypeConfiguration<Transaction> {

        public void Configure(EntityTypeBuilder<Transaction> builder) {
            builder.ToTable("Transaction");

            builder.HasKey(transaction => transaction.Id);

            builder.Property(transaction => transaction.Id).ValueGeneratedOnAdd();
            builder.Property(transaction => transaction.Date).IsRequired(true);
            builder.Property(transaction => transaction.TotalPrice).IsRequired(true);

            

            builder.HasOne(transaction => transaction.Customer)
                 .WithMany(customer => customer.Transactions)
                 .HasForeignKey(transaction => transaction.CustomerId);


            builder.HasOne(transaction => transaction.Manager)
                 .WithMany(manager => manager.Transactions)
                 .HasForeignKey(transaction => transaction.ManagerId);


            builder.HasOne(transaction => transaction.Car)
                 .WithMany(car => car.Transactions)
                 .HasForeignKey(transaction => transaction.CarId);
        }


    }
}
