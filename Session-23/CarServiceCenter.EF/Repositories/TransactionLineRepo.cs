using CarServiceCenter.EF.Context;
using CarServiceCenter.Model;
using Microsoft.EntityFrameworkCore;

namespace CarSercviceCenter.Orm.Repositories {
    public class TransactionLineRepo : IEntityRepo<TransactionLine> {
        public void Add(TransactionLine entity) {
            using var context = new CarServiceCenterDbContext();
            context.Add(entity);
            context.SaveChanges();
        }

        public void Delete(int id) {
            using var context = new CarServiceCenterDbContext();
            var dbTransactionLine = context.TransactionLines.Where(transactionLine => transactionLine.Id == id).SingleOrDefault();
            if (dbTransactionLine is null)
                return;
            context.Remove(dbTransactionLine);
            context.SaveChanges();
        }


        public IList<TransactionLine> GetAll() {
            using var context = new CarServiceCenterDbContext();
            return context.TransactionLines
                .Include(transactionLine => transactionLine.Engineer)
                .Include(transactionLine => transactionLine.ServiceTask)
                .Include(transactionLine => transactionLine.Transaction)
                .ToList();
        }

        public TransactionLine? GetById(int id) {
            using var context = new CarServiceCenterDbContext();
            return context.TransactionLines.Where(transactionLine => transactionLine.Id == id)
                .Include(transactionLine => transactionLine.Engineer)
                .Include(transactionLine => transactionLine.ServiceTask)
                .Include(transactionLine => transactionLine.Transaction)
                .SingleOrDefault();
        }

        public void Update(int id, TransactionLine entity) {
            using var context = new CarServiceCenterDbContext();
            var dbTransactionLine = context.TransactionLines.Where(transactionLine => transactionLine.Id == id).SingleOrDefault();
            if (dbTransactionLine is null)
                return;
            dbTransactionLine.Hours = entity.Hours;
            dbTransactionLine.PricePerHour = entity.PricePerHour;
            dbTransactionLine.Price = entity.Price;
            dbTransactionLine.TransactionId = entity.TransactionId;
            dbTransactionLine.ServiceTaskId = entity.ServiceTaskId;
            dbTransactionLine.EngineerId = entity.EngineerId;

            context.SaveChanges();
        }

    }
}
