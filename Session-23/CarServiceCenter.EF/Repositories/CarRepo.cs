using CarServiceCenter.EF.Context;
using CarServiceCenter.Model;

namespace CarSercviceCenter.Orm.Repositories {
    public class CarRepo : IEntityRepo<Car> {
        public void Add(Car entity) {
            using var context = new CarServiceCenterDbContext();
            context.Add(entity);
            context.SaveChanges();
        }

        public void Delete(int id) {
            using var context = new CarServiceCenterDbContext();
            var dbCar = context.Cars.Where(car => car.Id == id).SingleOrDefault();
            if (dbCar is null)
                return;
            context.Remove(dbCar);
            context.SaveChanges();
        }

        public IList<Car> GetAll() {
            using var context = new CarServiceCenterDbContext();
            return context.Cars.ToList();
        }

        public Car? GetById(int id) {
            using var context = new CarServiceCenterDbContext();
            return context.Cars.Where(car => car.Id == id).SingleOrDefault();
        }

        public void Update(int id, Car entity) {
            using var context = new CarServiceCenterDbContext();
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
