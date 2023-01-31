using CarSercviceCenter.Orm.Context;
using LibCarService;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSercviceCenter.Orm.Repositories {
    public class UserRepo : IEntityRepo<User> {
        public void Add(User entity) {
            using var context = new AppDbContext();
            context.Add(entity);
            context.SaveChanges();
        }

        public void Delete(Guid id) {
            using var context = new AppDbContext();
            var dbTodo = context.Users.Where(user => user.Id == id).SingleOrDefault();
            if (dbTodo is null)
                return;
            context.Remove(dbTodo);
            context.SaveChanges();
        }

        public void Delete(int id) {
            throw new NotImplementedException();
        }

        public IList<User> GetAll() {
            using var context = new AppDbContext();
            return context.Users
                .Include(user => user.Customers)
                .Include(user => user.Engineers)
                .Include(user => user.Managers).ToList();
        }

        public User? GetById(Guid id) {
            using var context = new AppDbContext();
            return context.Users.Where(user => user.Id == id)
                .Include(user => user.Customers)
                .Include(user => user.Engineers)
                .Include(user => user.Managers).SingleOrDefault();
        }

        public User? GetById(int id) {
            throw new NotImplementedException();
        }

        public void Update(Guid id, User entity) {
            using var context = new AppDbContext();
            var dbUser = context.Users.Where(user => user.Id == id).SingleOrDefault();
            if (dbUser is null)
                return;
            dbUser.Name = entity.Name;
            dbUser.Surname = entity.Surname;
            dbUser.Managers = entity.Managers;
            dbUser.Engineers = entity.Engineers;
            dbUser.Customers = entity.Customers;
            context.SaveChanges();
        }

        public void Update(int id, User entity) {
            throw new NotImplementedException();
        }
    }
}
