using CoffeeShop.EF.Context;
using FuelStation.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.EF.Repositories {
    public class ItemRepo : IEntityRepo<Item> {
        public void Add(Item entity) {
            using var context = new FuelStationDbContext();
            context.Add(entity);
            context.SaveChanges();
        }

        public void Delete(int id) {
            using var context = new FuelStationDbContext();
            var dbItem = context.Items.Where(Item => Item.Id == id).SingleOrDefault();
            if (dbItem is null)
                return;
            context.Remove(dbItem);
            context.SaveChanges();
        }

        public IList<Item> GetAll() {
            using var context = new FuelStationDbContext();
            return context.Items
                .Include(Item => Item.TransactionLines)
                .ToList();
        }

        public Item? GetById(int id) {
            using var context = new FuelStationDbContext();
            return context.Items.Where(customer => customer.Id == id)
                .Include(Item => Item.TransactionLines)
                .SingleOrDefault();
        }

        public void Update(int id, Item entity) {
            using var context = new FuelStationDbContext();
            var dbItem = context.Items.Where(Item => Item.Id == id).SingleOrDefault();
            if (dbItem is null)
                return;
            dbItem.Code = entity.Code;
            dbItem.Description = entity.Description;
            dbItem.Price = entity.Price;
            dbItem.Cost = entity.Cost;
            dbItem.Type = entity.Type;
            context.SaveChanges();
        }
    }
}
