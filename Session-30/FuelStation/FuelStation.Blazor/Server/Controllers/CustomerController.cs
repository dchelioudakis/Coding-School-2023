using FuelStation.EF.Repositories;
using FuelStation.Model;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data.Common;
using FuelStation.Blazor.Shared.DTO.Customer;

namespace FuelStation.Blazor.Server.Controllers {
    [Route("[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase {

        // Properties
        private readonly IEntityRepo<Customer> _customerRepo;
        //private readonly IValidator _validator;
        private string _errorMessage;

        // Constructors
        public CustomerController(IEntityRepo<Customer> cutomerRepo) {
            _customerRepo = cutomerRepo;
            //_validator = validator;
            _errorMessage = string.Empty;
        }

        // GET: /<EmployeeController>
        [HttpGet]
        public async Task<IEnumerable<CustomerListDto>> Get() {
            var result = await Task.Run(() => { return _customerRepo.GetAll(); });
            var selectCustomerList = result.Select(customer => new CustomerListDto {
                Id = customer.Id,
                Name = customer.Name,
                Surname = customer.Surname,
                CardNumber = customer.CardNumber,
            });
            return selectCustomerList;
        }

        // GET: /<EmployeeController>/5
        [HttpGet("{id}")]
        public async Task<CustomerEditDto?> GetById(int id) {
            var result = await Task.Run(() => { return _customerRepo.GetById(id); });
            if (result == null) {
                return null;
            }
            CustomerEditDto customer = new CustomerEditDto {
                Id = id,
                Name = result.Name,
                Surname = result.Surname,
                CardNumber = result.CardNumber,
            };
            return customer;
        }

        // POST /<EmployeeController>
        [HttpPost]
        public async Task<ActionResult> Post(CustomerEditDto customer) {
            var newCustomer = new Customer(customer.Name, customer.Surname, customer.CardNumber);
            await Task.Run(() => { _customerRepo.Add(newCustomer); });
            return Ok();
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

        // PUT /<EmployeeController>
        [HttpPut]
        public async Task Put(CustomerEditDto customer) {
            var dbCustomer = await Task.Run(() => { return _customerRepo.GetById(customer.Id); });
            if (dbCustomer == null) {
                // TODO if customer is null
                return;
            }
            dbCustomer.Name = customer.Name;
            dbCustomer.Surname = customer.Surname;
            dbCustomer.CardNumber = customer.CardNumber;
            _customerRepo.Update(customer.Id, dbCustomer);
        }

        // DELETE /<EmployeeController>/5
        [HttpDelete("{id}")]
        public async Task Delete(int id) {
            await Task.Run(() => {
                _customerRepo.Delete(id);
            });
        }
    }
}
