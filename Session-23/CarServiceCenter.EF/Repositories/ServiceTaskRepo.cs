using CarServiceCenter.EF.Context;
using CarServiceCenter.Model;


namespace CarSercviceCenter.Orm.Repositories {
    public class ServiceTaskRepo : IEntityRepo<ServiceTask> {
        public void Add(ServiceTask entity) {
            using var context = new CarServiceCenterDbContext();
            context.Add(entity);
            context.SaveChanges();
        }

        public void Delete(int id) {
            using var context = new CarServiceCenterDbContext();
            var dbTask = context.ServiceTasks.Where(task => task.Id == id).SingleOrDefault();
            if (dbTask is null)
                return;
            context.Remove(dbTask);
            context.SaveChanges();
        }

        public IList<ServiceTask> GetAll() {
            using var context = new CarServiceCenterDbContext();
            return context.ServiceTasks.ToList();
        }

        public ServiceTask? GetById(int id) {
            using var context = new CarServiceCenterDbContext();
            return context.ServiceTasks.Where(task => task.Id == id).SingleOrDefault();
        }

        public void Update(int id, ServiceTask entity) {
            using var context = new CarServiceCenterDbContext();
            var dbTask = context.ServiceTasks.Where(task => task.Id == id).SingleOrDefault();
            if (dbTask is null)
                return;
            dbTask.Code = entity.Code;
            dbTask.Description = entity.Description;
            dbTask.Hours = entity.Hours;

            context.SaveChanges();
        }

    }
}
