using CarSercviceCenter.Orm.Context;
using LibCarService;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSercviceCenter.Orm.Repositories {
    public class ManagerRepo : IEntityRepo<Manager> {
        public void Add(Manager entity) {
            using var context = new AppDbContext();
            context.Add(entity);
            context.SaveChanges();
        }

        public void Delete(Guid id) {
            using var context = new AppDbContext();
            var dbManager = context.Managers.Where(manager => manager.Id == id).SingleOrDefault();
            if (dbManager is null)
                return;
            context.Remove(dbManager);
            context.SaveChanges();
        }

        public void Delete(int id) {
            throw new NotImplementedException();
        }

        public IList<Manager> GetAll() {
            using var context = new AppDbContext();
            return context.Managers
                .Include(manager => manager.Engineers)
                .Include(manager => manager.Transactions).ToList();
        }

        public Manager? GetById(Guid id) {
            using var context = new AppDbContext();
            return context.Managers.Where(user => user.Id == id)
                .Include(manager => manager.Engineers)
                .Include(manager => manager.Transactions).SingleOrDefault();
        }

        public Manager? GetById(int id) {
            throw new NotImplementedException();
        }

        public void Update(Guid id, Manager entity) {
            using var context = new AppDbContext();
            var dbManager = context.Managers.Where(user => user.Id == id).SingleOrDefault();
            if (dbManager is null)
                return;
            dbManager.Name = entity.Name;
            dbManager.Surname = entity.Surname;
            dbManager.Transactions = entity.Transactions;
            dbManager.Engineers = entity.Engineers;
            dbManager.SalaryPerMonth = entity.SalaryPerMonth;
            context.SaveChanges();
        }

    }
}
