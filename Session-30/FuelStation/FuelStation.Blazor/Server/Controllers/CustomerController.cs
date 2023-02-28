using CustomerCardGeneration;
using FuelStation.Blazor.Shared.DTO.Customer;
using FuelStation.Blazor.Shared.DTO.Transaction;
using FuelStation.EF.Repositories;
using FuelStation.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FuelStation.Blazor.Server.Controllers {
    [Route("[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase {

        // Properties
        private readonly IEntityRepo<Customer> _customerRepo;

        // Constructors
        public CustomerController(IEntityRepo<Customer> cutomerRepo) {
            _customerRepo = cutomerRepo;
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

        [Route("/customerlist/details/{id}")]
        [HttpGet]
        public async Task<CustomerDetailsDto?> GetDetailsById(int id) {
            var dbCustomer = await Task.Run(() => { return _customerRepo.GetById(id); });
            if (dbCustomer == null) {
                return null;
            }
            CustomerDetailsDto customer = new CustomerDetailsDto {
                Id = id,
                Name = dbCustomer.Name,
                Surname = dbCustomer.Surname,
                CardNumber = dbCustomer.CardNumber,
                Transactions = dbCustomer.Transactions.Select(transaction => new TransactionListDto {
                    Id = transaction.Id,
                    Date = transaction.Date,
                    PaymentMethod = transaction.PaymentMethod,
                    TotalValue = transaction.TotalValue,
                    Employee = new Shared.DTO.Employee.EmployeeEditDto {
                        Name = transaction.Employee.Name,
                        Surname = transaction.Employee.Surname,
                    },
                }).ToList()
            };
            return customer;
        }

        // POST /<EmployeeController>
        [HttpPost]
        public async Task<ActionResult> Post(CustomerEditDto customer) {
            CustomerCardGenerator customerCardGenerator = new();

            var newCustomer = new Customer(customer.Name, customer.Surname) {
                CardNumber = customerCardGenerator.GenerateCardNumber()
                //CardNumber = "A123456"
            };
            try {
                await Task.Run(() => { _customerRepo.Add(newCustomer); });
                return Ok(newCustomer.Id);
            }
            catch (DbUpdateException exception) 
            when (exception?.InnerException?.Message.Contains("Cannot insert duplicate key row in object") ?? false) {
                return BadRequest("Duplicated Card Number. Please try again");
            }
        }

        // PUT /<EmployeeController>
        [HttpPut]
        public async Task<ActionResult> Put(CustomerEditDto customer) {
            var dbCustomer = await Task.Run(() => { return _customerRepo.GetById(customer.Id); });
            if (dbCustomer == null) {
                // TODO if customer is null
                return BadRequest("Error retrieving customer");
            }
            dbCustomer.Name = customer.Name;
            dbCustomer.Surname = customer.Surname;

            try {
                await Task.Run(() => { _customerRepo.Update(customer.Id, dbCustomer); });
                return Ok(dbCustomer.Id);
            }
            catch (DbUpdateException exception)
            {
                return BadRequest(exception.Message);
            }
            
        }

        // DELETE /<EmployeeController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id) {
            try {
                await Task.Run(() => { _customerRepo.Delete(id);});
                return Ok();
            }
            catch (DbUpdateException) {
                return BadRequest($"Could not delete this customer because they have transactions");
            }
            catch (KeyNotFoundException) {
                return BadRequest($"Customer not found");
            }
            
            
        }
    }
}
