using CarSercviceCenter.Orm.Context;
using LibCarService;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSercviceCenter.Orm.Repositories {
    public class EngineerRepo : IEntityRepo<Engineer> {
        public void Add(Engineer entity) {
            using var context = new AppDbContext();
            context.Add(entity);
            context.SaveChanges();
        }

        public void Delete(Guid id) {
            using var context = new AppDbContext();
            var dbEngineer = context.Engineers.Where(engineer => engineer.Id == id).SingleOrDefault();
            if (dbEngineer is null)
                return;
            context.Remove(dbEngineer);
            context.SaveChanges();
        }


        public IList<Engineer> GetAll() {
            using var context = new AppDbContext();
            return context.Engineers
                .Include(engineer => engineer.TransactionLines).ToList();
        }

        public Engineer? GetById(Guid id) {
            using var context = new AppDbContext();
            return context.Engineers.Where(user => user.Id == id)
                .Include(engineer => engineer.TransactionLines).SingleOrDefault();
        }

        public void Update(Guid id, Engineer entity) {
            using var context = new AppDbContext();
            var dbEngineer = context.Engineers.Where(engineer => engineer.Id == id).SingleOrDefault();
            if (dbEngineer is null)
                return;
            dbEngineer.Name = entity.Name;
            dbEngineer.Surname = entity.Surname;
            dbEngineer.TransactionLines = entity.TransactionLines;
            dbEngineer.SalaryPerMonth = entity.SalaryPerMonth;
            //dbEngineer.UserId = entity.UserId;
            //dbEngineer.User = entity.User;
            //dbEngineer.ManagerId = entity.ManagerId;
            dbEngineer.Manager = entity.Manager;

            context.SaveChanges();
        }

    }
}
