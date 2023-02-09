using CarServiceCenter.EF.Context;
using CarServiceCenter.Model;
using Microsoft.EntityFrameworkCore;


namespace CarSercviceCenter.Orm.Repositories {
    public class ManagerRepo : IEntityRepo<Manager> {
        public void Add(Manager entity) {
            using var context = new CarServiceCenterDbContext();
            context.Add(entity);
            context.SaveChanges();
        }

        public void Delete(int id) {
            using var context = new CarServiceCenterDbContext();
            var dbManager = context.Managers.Where(manager => manager.Id == id).SingleOrDefault();
            if (dbManager is null)
                return;
            context.Remove(dbManager);
            context.SaveChanges();
        }

        public IList<Manager> GetAll() {
            using var context = new CarServiceCenterDbContext();
            return context.Managers
                .Include(manager => manager.Engineers)
                .Include(manager => manager.Transactions).ToList();
        }

        public Manager? GetById(int id) {
            using var context = new CarServiceCenterDbContext();
            return context.Managers.Where(manager => manager.Id == id)
                .Include(manager => manager.Engineers)
                .Include(manager => manager.Transactions).SingleOrDefault();
        }

        public void Update(int id, Manager entity) {
            using var context = new CarServiceCenterDbContext();
            var dbManager = context.Managers.Where(manager => manager.Id == id).SingleOrDefault();
            if (dbManager is null)
                return;
            dbManager.Name = entity.Name;
            dbManager.Surname = entity.Surname;
            dbManager.Transactions = entity.Transactions;
            dbManager.Engineers = entity.Engineers;
            dbManager.SalaryPerMonth = entity.SalaryPerMonth;
            //dbManager.UserId = entity.UserId;
            //dbManager.User = entity.User;
            context.SaveChanges();
        }

    }
}
