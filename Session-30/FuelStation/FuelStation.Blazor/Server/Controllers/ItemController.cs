using FuelStation.EF.Repositories;
using FuelStation.Model;
using FuelStation.Model.Enums;
using FuelStation.Blazor.Shared.DTO.Customer;
using FuelStation.Blazor.Shared.DTO.Employee;
using FuelStation.Blazor.Shared.DTO.Item;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace FuelStation.Blazor.Server.Controllers {
    [Route("[controller]")]
    [ApiController]
    public class ItemController : ControllerBase {

        // Properties
        private readonly IEntityRepo<Item> _itemRepo;
        //private readonly IValidator _validator;
        private string _errorMessage;

        // Constructors
        public ItemController(IEntityRepo<Item> itemRepo) {
            _itemRepo = itemRepo;
            //_validator = validator;
            _errorMessage = string.Empty;
        }

        // GET: /<CustomersController>
        [HttpGet]
        public async Task<IEnumerable<ItemListDto>> Get() {
            var result = await Task.Run(() => { return _itemRepo.GetAll(); });
            var selectItemList = result.Select(item => new ItemListDto {
                Id = item.Id,
                Code = item.Code,
                Description = item.Description,
                Price = item.Price,
                Cost = item.Cost,
                Type = item.Type,
            });
            return selectItemList;
        }

        // GET: /<CustomersController>/5
        [HttpGet("{id}")]
        public async Task<ItemEditDto?> GetById(int id) {
            var result = await Task.Run(() => { return _itemRepo.GetById(id); });
            if (result == null) {
                return null;
            }
            ItemEditDto item = new ItemEditDto {
                Id = id,
                Code = result.Code,
                Description = result.Description,
                Price = result.Price,
                Cost = result.Cost,
                Type = result.Type,
            };
            return item;
        }

        // POST /<CustomersController>
        [HttpPost]
        public async Task<ActionResult> Post(ItemEditDto item) {
            var newItem = new Item(item.Code, item.Description, item.Type) {
                Price = item.Price,
                Cost = item.Cost,
            };

            try {
                await Task.Run(() => { _itemRepo.Add(newItem); });
                return Ok();
            }
            catch (DbUpdateException exception)
            when (exception?.InnerException?.Message.Contains("Cannot insert duplicate key row in object") ?? false) {
                return BadRequest("Item Code already in use");
            }
            
            //if (_validator.ValidateAddCustomer(_customerRepo.GetAll().ToList(), out _errorMessage)) {
            //    try {
            //        await Task.Run(() => { _customerRepo.Add(newCustomer); });
            //        return Ok();
            //    }
            //    catch (DbException ex) {
            //        return BadRequest(ex.Message);
            //    }
            //}
            //else {
            //    return BadRequest(_errorMessage);
            //}
        }

        // PUT /<CustomersController>/5
        [HttpPut]
        public async Task<ActionResult> Put(ItemEditDto item) {
            var dbItem = await Task.Run(() => { return _itemRepo.GetById(item.Id); });
            if (dbItem == null) {
                // TODO if customer is null
                return BadRequest("Error retrieving item from DB");
            }
            dbItem.Code = item.Code;
            dbItem.Description = item.Description;
            dbItem.Price = item.Price;
            dbItem.Cost = item.Cost;
            dbItem.Type = item.Type;
            try {
                await Task.Run(() => { _itemRepo.Update(item.Id, dbItem); });
                return Ok();
            }
            catch (DbUpdateException exception)
            when (exception?.InnerException?.Message.Contains("Cannot insert duplicate key row in object") ?? false) {
                return BadRequest("Item Code already in use");
            }
            
        }

        // DELETE /<CustomersController>/5
        [HttpDelete("{id}")]
        public async Task Delete(int id) {
            await Task.Run(() => {
                _itemRepo.Delete(id);
            });
        }
    }
}
