using FuelStation.EF.Repositories;
using FuelStation.Model;
using FuelStation.Model.Enums;
using FuelStationAPI.DTO.Customer;
using FuelStationAPI.DTO.Employee;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using System.Data.Common;

//namespace FuelStationAPI.Controllers {
//    [Route("[controller]")]
//    [ApiController]
//    public class EmployeeController : ControllerBase {

//        // Properties
//        private readonly IEntityRepo<Employee> _employeeRepo;
//        //private readonly IValidator _validator;
//        private String _errorMessage;

//        // Constructors
//        public EmployeeController(IEntityRepo<Employee> employeeRepo) {
//            _employeeRepo = employeeRepo;
//            //_validator = validator;
//            _errorMessage = String.Empty;
//        }

//        // GET: /<CustomersController>
//        [HttpGet]
//        public async Task<IEnumerable<EmployeeListDto>> Get() {
//            var result = await Task.Run(() => { return _employeeRepo.GetAll(); });
//            var selectEmployeeList = result.Select(employee => new EmployeeListDto {
//                Id = employee.Id,
//                Name = employee.Name,
//                Surname = employee.Surname,
//                HireDateStart = employee.HireDateStart,
//                HireDateEnd = employee.HireDateEnd,
//                SalaryPerMonth = employee.SalaryPerMonth,
//                Type = employee.Type,
//            });
//            return selectEmployeeList;
//        }

//        // GET: /<CustomersController>/5
//        [HttpGet("{id}")]
//        public async Task<EmployeeEditDto?> GetById(int id) {
//            var result = await Task.Run(() => { return _employeeRepo.GetById(id); });
//            if (result == null) {
//                return null;
//            }
//            EmployeeEditDto employee = new EmployeeEditDto {
//                Id = id,
//                Name = result.Name,
//                Surname = result.Surname,
//                HireDateStart = result.HireDateStart,
//                HireDateEnd = result.HireDateEnd,
//                SalaryPerMonth = result.SalaryPerMonth,
//                Type = result.Type,
//            };
//            return employee;
//        }

//        // POST /<CustomersController>
//        [HttpPost]
//        public async Task<ActionResult> Post(EmployeeEditDto employee) {
//            var newEmployee = new Employee(employee.Name, employee.Surname, employee.Type) {
//                HireDateStart = employee.HireDateStart,
//                HireDateEnd = employee.HireDateEnd,
//                SalaryPerMonth = employee.SalaryPerMonth,
//            };
//            await Task.Run(() => { _employeeRepo.Add(newEmployee); });
//            return Ok();
//            //if (_validator.ValidateAddCustomer(_customerRepo.GetAll().ToList(), out _errorMessage)) {
//            //    try {
//            //        await Task.Run(() => { _customerRepo.Add(newCustomer); });
//            //        return Ok();
//            //    }
//            //    catch (DbException ex) {
//            //        return BadRequest(ex.Message);
//            //    }
//            //}
//            //else {
//            //    return BadRequest(_errorMessage);
//            //}
//        }

//        // PUT /<CustomersController>/5
//        [HttpPut]
//        public async Task Put(EmployeeEditDto employee) {
//            var dbEmployee = await Task.Run(() => { return _employeeRepo.GetById(employee.Id); });
//            if (dbEmployee == null) {
//                // TODO if customer is null
//                return;
//            }
//            dbEmployee.Name = employee.Name;
//            dbEmployee.Surname = employee.Surname;
//            dbEmployee.HireDateStart = employee.HireDateStart;
//            dbEmployee.HireDateEnd = employee.HireDateEnd;
//            dbEmployee.SalaryPerMonth = employee.SalaryPerMonth;
//            dbEmployee.Type = employee.Type;
//            _employeeRepo.Update(employee.Id, dbEmployee);
//        }

//        // DELETE /<CustomersController>/5
//        [HttpDelete("{id}")]
//        public async Task Delete(int id) {
//            await Task.Run(() => {
//                _employeeRepo.Delete(id);
//            });
//        }
//    }
//}
