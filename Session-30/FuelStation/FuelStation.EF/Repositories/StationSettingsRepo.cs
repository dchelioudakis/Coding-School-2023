using FuelStation.EF.Context;
using FuelStation.Model;
using FuelStation.Model.OptionsModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.EF.Repositories {
    public class StationSettingsRepo : IEntityRepo<StationSettings> {
        public void Add(StationSettings entity) {
            using var context = new FuelStationDbContext();
            context.Add(entity);
            context.SaveChanges();
        }

        public void Delete(int id) {
            using var context = new FuelStationDbContext();
            var dbItem = context.Settings.Where(Item => Item.Id == id).SingleOrDefault();
            if (dbItem is null)
                return;
            context.Remove(dbItem);
            context.SaveChanges();
        }

        public IList<StationSettings> GetAll() {
            using var context = new FuelStationDbContext();
            return context.Settings.ToList();
        }

        public StationSettings? GetById(int id) {
            using var context = new FuelStationDbContext();
            return context.Settings.Where(settings => settings.Id == id).SingleOrDefault();
        }

        public void Update(int id, StationSettings entity) {
            using var context = new FuelStationDbContext();
            var dbItem = context.Settings.Where(Item => Item.Id == id).SingleOrDefault();
            if (dbItem is null)
                return;
            dbItem.RentingCost = entity.RentingCost;
            dbItem.StaffMaxCount = entity.StaffMaxCount;
            dbItem.StaffMinCount = entity.StaffMinCount;
            dbItem.CashierMinCount = entity.CashierMinCount;
            dbItem.CashierMaxCount = entity.CashierMaxCount;
            dbItem.ManagerMinCount = entity.ManagerMinCount;
            dbItem.ManagerMaxCount = entity.ManagerMaxCount;
            context.SaveChanges();
        }
    }
}
