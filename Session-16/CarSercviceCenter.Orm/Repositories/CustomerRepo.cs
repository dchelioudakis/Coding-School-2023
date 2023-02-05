using CarSercviceCenter.Orm.Context;
using LibCarService;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSercviceCenter.Orm.Repositories {
    public class CustomerRepo : IEntityRepo<Customer> {
        public void Add(Customer entity) {
            using var context = new AppDbContext();
            context.Add(entity);
            context.SaveChanges();
        }

        public void Delete(Guid id) {
            using var context = new AppDbContext();
            var dbCustomer = context.Customers.Where(customer => customer.Id == id).SingleOrDefault();
            if (dbCustomer is null)
                return;
            context.Remove(dbCustomer);
            context.SaveChanges();
        }

        public IList<Customer> GetAll() {
            using var context = new AppDbContext();
            return context.Customers
                .Include(customer => customer.Transactions).ToList();
        }

        public Customer? GetById(Guid id) {
            using var context = new AppDbContext();
            return context.Customers.Where(customer => customer.Id == id)
                .Include(customer => customer.Transactions).SingleOrDefault();
        }

        public void Update(Guid id, Customer entity) {
            using var context = new AppDbContext();
            var dbCustomer = context.Customers.Where(customer => customer.Id == id).SingleOrDefault();
            if (dbCustomer is null)
                return;
            dbCustomer.Name = entity.Name;
            dbCustomer.Surname = entity.Surname;
            dbCustomer.Transactions = entity.Transactions;
            //dbCustomer.UserId = entity.UserId;
            //dbCustomer.User = entity.User;
            context.SaveChanges();
        }

    }
}
