using FuelStation.Blazor.Shared.DTO.Item;
using FuelStation.Blazor.Shared.DTO.Settings;
using FuelStation.EF.Repositories;
using FuelStation.Model;
using FuelStation.Model.OptionsModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FuelStation.Blazor.Server.Controllers {
    [Route("[controller]")]
    [ApiController]
    public class StationSettingsController : ControllerBase {

        // Properties
        private readonly IEntityRepo<StationSettings> _settingsRepo;
        private string _errorMessage;

        // Constructors
        public StationSettingsController(IEntityRepo<StationSettings> settingsRepo) {
            _settingsRepo = settingsRepo;
        }


        // GET: /<CustomersController>/5
        [HttpGet("{id}")]
        public async Task<StationSettingsDto?> GetById(int id) {
            var result = await Task.Run(() => { return _settingsRepo.GetById(id); });
            if (result == null) {
                return null;
            }
            StationSettingsDto item = new StationSettingsDto {
                Id = id,
                RentingCost = result.RentingCost,
                ManagerMinCount = result.ManagerMinCount,
                ManagerMaxCount = result.ManagerMaxCount,
                StaffMinCount = result.StaffMinCount,
                StaffMaxCount = result.StaffMaxCount,
                CashierMaxCount = result.CashierMaxCount,
                CashierMinCount = result.CashierMinCount,
            };
            return item;
        }

        // PUT /<CustomersController>/5
        [HttpPut]
        public async Task<ActionResult> Put(StationSettingsDto item) {
            var dbItem = await Task.Run(() => { return _settingsRepo.GetById(item.Id); });
            if (dbItem == null) {
                // TODO if customer is null
                return BadRequest("Error retrieving item from DB");
            }
            dbItem.RentingCost = item.RentingCost;
            dbItem.ManagerMinCount = item.ManagerMinCount;
            dbItem.ManagerMaxCount = item.ManagerMaxCount;
            dbItem.StaffMinCount = item.StaffMinCount;
            dbItem.StaffMaxCount = item.StaffMaxCount;
            dbItem.CashierMaxCount = item.CashierMaxCount;
            dbItem.CashierMinCount = item.CashierMinCount;
            await Task.Run(() => { _settingsRepo.Update(item.Id, dbItem); });
            return Ok();

        }

        // DELETE /<CustomersController>/5
        //[HttpDelete("{id}")]
        //public async Task Delete(int id) {
        //    await Task.Run(() => {
        //        _itemRepo.Delete(id);
        //    });
        //}
    }
}
