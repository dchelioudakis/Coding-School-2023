using CarServiceCenter.EF.Context;
using CarServiceCenter.Model;
using Microsoft.EntityFrameworkCore;

namespace CarSercviceCenter.Orm.Repositories {
    public class TransactionRepo : IEntityRepo<Transaction> {
        public void Add(Transaction entity) {
            using var context = new CarServiceCenterDbContext();
            context.Add(entity);
            context.SaveChanges();
        }

        public void Delete(int id) {
            using var context = new CarServiceCenterDbContext();
            var dbTransaction = context.Transactions.Where(transaction => transaction.Id == id).SingleOrDefault();
            if (dbTransaction is null)
                return;
            context.Remove(dbTransaction);
            context.SaveChanges();
        }


        public IList<Transaction> GetAll() {
            using var context = new CarServiceCenterDbContext();
            return context.Transactions
                .Include(transaction => transaction.TransactionLines)
                .Include(transaction => transaction.Manager)
                .Include(transaction => transaction.Customer)
                .Include(transaction => transaction.Car).ToList();
        }

        public Transaction? GetById(int id) {
            using var context = new CarServiceCenterDbContext();
            return context.Transactions.Where(transaction => transaction.Id == id)
                .Include(transaction => transaction.TransactionLines)
                .Include(transaction => transaction.Manager)
                .Include(transaction => transaction.Customer)
                .Include(transaction => transaction.Car).SingleOrDefault();
        }

        public void Update(int id, Transaction entity) {
            using var context = new CarServiceCenterDbContext();
            var dbTransaction = context.Transactions.Where(transaction => transaction.Id == id).SingleOrDefault();
            if (dbTransaction is null)
                return;
            dbTransaction.Date = entity.Date;
            dbTransaction.ManagerId = entity.ManagerId;
            dbTransaction.CustomerId = entity.CustomerId;
            dbTransaction.CarId = entity.CarId;
            dbTransaction.TransactionLines = entity.TransactionLines;

            context.SaveChanges();
        }

    }
}
