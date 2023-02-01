using CarSercviceCenter.Orm.Context;
using LibCarService;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSercviceCenter.Orm.Repositories {
    public class TransactionRepo : IEntityRepo<Transaction> {
        public void Add(Transaction entity) {
            using var context = new AppDbContext();
            context.Add(entity);
            context.SaveChanges();
        }

        public void Delete(Guid id) {
            using var context = new AppDbContext();
            var dbTransaction = context.Transactions.Where(transaction => transaction.Id == id).SingleOrDefault();
            if (dbTransaction is null)
                return;
            context.Remove(dbTransaction);
            context.SaveChanges();
        }


        public IList<Transaction> GetAll() {
            using var context = new AppDbContext();
            return context.Transactions
                .Include(transaction => transaction.TransactionLines)
                .Include(transaction => transaction.Manager)
                .Include(transaction => transaction.Customer)
                .Include(transaction => transaction.Car).ToList();
        }

        public Transaction? GetById(Guid id) {
            using var context = new AppDbContext();
            return context.Transactions.Where(user => user.Id == id)
                .Include(transaction => transaction.TransactionLines)
                .Include(transaction => transaction.Manager)
                .Include(transaction => transaction.Customer)
                .Include(transaction => transaction.Car).SingleOrDefault();
        }

        public void Update(Guid id, Transaction entity) {
            using var context = new AppDbContext();
            var dbTransaction = context.Transactions.Where(transaction => transaction.Id == id).SingleOrDefault();
            if (dbTransaction is null)
                return;
            dbTransaction.Date = entity.Date;
            dbTransaction.ManagerId = entity.ManagerId;
            dbTransaction.CustomerId = entity.CustomerId;
            dbTransaction.CarId = entity.CarId;
            dbTransaction.TransactionLines = entity.TransactionLines;
            dbTransaction.Manager = entity.Manager;
            dbTransaction.Customer = entity.Customer;
            dbTransaction.Car = entity.Car;

            context.SaveChanges();
        }

    }
}
