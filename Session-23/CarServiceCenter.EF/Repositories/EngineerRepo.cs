using CarServiceCenter.EF.Context;
using CarServiceCenter.Model;
using Microsoft.EntityFrameworkCore;


namespace CarSercviceCenter.Orm.Repositories {
    public class EngineerRepo : IEntityRepo<Engineer> {
        public void Add(Engineer entity) {
            using var context = new CarServiceCenterDbContext();
            context.Add(entity);
            context.SaveChanges();
        }

        public void Delete(int id) {
            using var context = new CarServiceCenterDbContext();
            var dbEngineer = context.Engineers.Where(engineer => engineer.Id == id).SingleOrDefault();
            if (dbEngineer is null)
                return;
            context.Remove(dbEngineer);
            context.SaveChanges();
        }


        public IList<Engineer> GetAll() {
            using var context = new CarServiceCenterDbContext();
            return context.Engineers
                .Include(engineer => engineer.TransactionLines)
                .Include(engineer => engineer.Manager).ToList();
        }

        public Engineer? GetById(int id) {
            using var context = new CarServiceCenterDbContext();
            return context.Engineers.Where(user => user.Id == id)
                .Include(engineer => engineer.TransactionLines)
                .Include(engineer => engineer.Manager).SingleOrDefault();
        }

        public void Update(int id, Engineer entity) {
            using var context = new CarServiceCenterDbContext();
            var dbEngineer = context.Engineers.Where(engineer => engineer.Id == id).SingleOrDefault();
            if (dbEngineer is null)
                return;
            dbEngineer.Name = entity.Name;
            dbEngineer.Surname = entity.Surname;
            dbEngineer.TransactionLines = entity.TransactionLines;
            dbEngineer.SalaryPerMonth = entity.SalaryPerMonth;
            dbEngineer.ManagerId = entity.ManagerId;

            context.SaveChanges();
        }

    }
}
