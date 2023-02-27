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
            var dbTransaction = context.Transactions.Where(transaction => transaction.Id == id).SingleOrDefault();
            if (dbTransaction is null)
                return;
            context.Remove(dbTransaction);
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
            var dbTransaction = context.Transactions.Where(transaction => transaction.Id == id)
                .Include(Transaction => Transaction.TransactionLines).SingleOrDefault();
            if (dbTransaction is null)
                return;
            dbTransaction.Date = entity.Date;
            dbTransaction.TotalValue = entity.TotalValue;
            dbTransaction.PaymentMethod = entity.PaymentMethod;
            dbTransaction.CustomerId = entity.CustomerId;
            dbTransaction.EmployeeId = entity.EmployeeId;
            dbTransaction.TransactionLines = entity.TransactionLines;
            context.SaveChanges();
        }
    }
}
