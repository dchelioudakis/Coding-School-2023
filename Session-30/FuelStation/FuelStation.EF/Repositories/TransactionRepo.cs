using FuelStation.EF.Context;
using FuelStation.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.EF.Repositories {
    public class TransactionRepo : IEntityRepo<Transaction> {
        public void Add(Transaction entity) {
            using var context = new FuelStationDbContext();
            context.Add(entity);
            context.SaveChanges();
        }

        public void Delete(int id) {
            using var context = new FuelStationDbContext();
            var dbCoffeShop = context.Transactions.Where(transaction => transaction.Id == id).SingleOrDefault();
            if (dbCoffeShop is null)
                return;
            context.Remove(dbCoffeShop);
            context.SaveChanges();
        }

        public IList<Transaction> GetAll() {
            using var context = new FuelStationDbContext();

            var transactions = context.Transactions
               .Include(transaction => transaction.Customer)
               .Include(transaction => transaction.Employee)
               .Include(Transaction => Transaction.TransactionLines)
               .ThenInclude(transactionLine => transactionLine.Item)
               .ToList();

            return transactions;
        }

        public Transaction? GetById(int id) {
            using var context = new FuelStationDbContext();
            return context.Transactions
                .Where(transaction => transaction.Id == id)
                .Include(Transaction => Transaction.TransactionLines)
                .Include(transaction => transaction.Customer)
                .Include(transaction => transaction.Employee)
                .SingleOrDefault();
        }

        public void Update(int id, Transaction entity) {
            using var context = new FuelStationDbContext();
            var dbCoffeShop = context.Transactions.Where(transaction => transaction.Id == id)
                .Include(Transaction => Transaction.TransactionLines).SingleOrDefault();
            if (dbCoffeShop is null)
                return;
            dbCoffeShop.Date = entity.Date;
            dbCoffeShop.TotalValue = entity.TotalValue;
            dbCoffeShop.PaymentMethod = entity.PaymentMethod;
            dbCoffeShop.CustomerId = entity.CustomerId;
            dbCoffeShop.EmployeeId = entity.EmployeeId;
            dbCoffeShop.TransactionLines = entity.TransactionLines;
            context.SaveChanges();
        }
    }
}
