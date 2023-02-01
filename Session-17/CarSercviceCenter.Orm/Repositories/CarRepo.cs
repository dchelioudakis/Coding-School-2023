using CarSercviceCenter.Orm.Context;
using LibCarService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSercviceCenter.Orm.Repositories {
    public class CqrRepo : IEntityRepo<Car> {
        public void Add(Car entity) {
            using var context = new AppDbContext();
            context.Add(entity);
            context.SaveChanges();
        }

        public void Delete(Guid id) {
            using var context = new AppDbContext();
            var dbCar = context.Cars.Where(car => car.Id == id).SingleOrDefault();
            if (dbCar is null)
                return;
            context.Remove(dbCar);
            context.SaveChanges();
        }

        public IList<Car> GetAll() {
            using var context = new AppDbContext();
            return context.Cars.ToList();
        }

        public Car? GetById(Guid id) {
            using var context = new AppDbContext();
            return context.Cars.Where(car => car.Id == id).SingleOrDefault();
        }

        public void Update(Guid id, Car entity) {
            using var context = new AppDbContext();
            var dbCar = context.Cars.Where(car => car.Id == id).SingleOrDefault();
            if (dbCar is null)
                return;
            dbCar.Brand = entity.Brand;
            dbCar.Model = entity.Model;
            dbCar.CarRegistrationNumber = entity.CarRegistrationNumber;
            
            context.SaveChanges();
        }

    }
}
