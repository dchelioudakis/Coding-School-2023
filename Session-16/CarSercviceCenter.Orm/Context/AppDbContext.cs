using CarSercviceCenter.Orm.Configurations;
using LibCarService;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace CarSercviceCenter.Orm.Context {
    public class AppDbContext : DbContext {
        //public DbSet<User> Users { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Engineer> Engineers { get; set; }
        public DbSet<Manager> Managers { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<ServiceTask> ServiceTasks { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<TransactionLine> TransactionLines { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {

            //modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new CarConfiguration());
            modelBuilder.ApplyConfiguration(new CustomerConfiguration());
            modelBuilder.ApplyConfiguration(new ManagerConfiguration());
            modelBuilder.ApplyConfiguration(new EngineerConfiguration());
            modelBuilder.ApplyConfiguration(new ServiceTaskConfiguration());
            modelBuilder.ApplyConfiguration(new TransactionConfiguration());
            modelBuilder.ApplyConfiguration(new TransactionLineConfiguration());

            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=CarServiceCenter;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
