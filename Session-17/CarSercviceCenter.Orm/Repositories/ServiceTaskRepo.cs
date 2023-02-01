using CarSercviceCenter.Orm.Context;
using LibCarService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSercviceCenter.Orm.Repositories {
    public class ServiceTaskRepo : IEntityRepo<ServiceTask> {
        public void Add(ServiceTask entity) {
            using var context = new AppDbContext();
            context.Add(entity);
            context.SaveChanges();
        }

        public void Delete(Guid id) {
            using var context = new AppDbContext();
            var dbTask = context.ServiceTasks.Where(task => task.Id == id).SingleOrDefault();
            if (dbTask is null)
                return;
            context.Remove(dbTask);
            context.SaveChanges();
        }

        public IList<ServiceTask> GetAll() {
            using var context = new AppDbContext();
            return context.ServiceTasks.ToList();
        }

        public ServiceTask? GetById(Guid id) {
            using var context = new AppDbContext();
            return context.ServiceTasks.Where(task => task.Id == id).SingleOrDefault();
        }

        public void Update(Guid id, ServiceTask entity) {
            using var context = new AppDbContext();
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
