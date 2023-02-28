using FuelStation.Blazor.Shared.DTO.Employee;
using FuelStation.Blazor.Shared.Validator;
using FuelStation.EF.Repositories;
using FuelStation.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FuelStation.Blazor.Server.Controllers {
    [Route("[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase {

        // Properties
        private readonly IEntityRepo<Employee> _employeeRepo;
        private readonly IValidator _validator;
        private string _errorMessage;

        // Constructors
        public EmployeeController(IEntityRepo<Employee> employeeRepo, IValidator validator) {
            _employeeRepo = employeeRepo;
            _validator = validator;
            _errorMessage = string.Empty;
        }

        // GET: /<CustomersController>
        [HttpGet]
        public async Task<IEnumerable<EmployeeListDto>> Get() {
            var result = await Task.Run(() => { return _employeeRepo.GetAll(); });
            var selectEmployeeList = result.Select(employee => new EmployeeListDto {
                Id = employee.Id,
                Name = employee.Name,
                Surname = employee.Surname,
                HireDateStart = employee.HireDateStart,
                HireDateEnd = employee.HireDateEnd,
                SalaryPerMonth = employee.SalaryPerMonth,
                Type = employee.Type,
            });
            return selectEmployeeList;
        }

        // GET: /<CustomersController>/5
        [HttpGet("{id}")]
        public async Task<EmployeeEditDto?> GetById(int id) {
            var result = await Task.Run(() => { return _employeeRepo.GetById(id); });
            if (result == null) {
                return null;
            }
            EmployeeEditDto employee = new EmployeeEditDto {
                Id = id,
                Name = result.Name,
                Surname = result.Surname,
                HireDateStart = result.HireDateStart,
                HireDateEnd = result.HireDateEnd,
                SalaryPerMonth = result.SalaryPerMonth,
                Type = result.Type,
                Username = result.Username,
                Password = result.Password,
            };
            return employee;
        }

        // POST /<CustomersController>
        [HttpPost]
        public async Task<ActionResult> Post(EmployeeEditDto employee) {
            var newEmployee = new Employee(employee.Name, employee.Surname, employee.Type) {
                HireDateStart = employee.HireDateStart,
                HireDateEnd = employee.HireDateEnd,
                SalaryPerMonth = employee.SalaryPerMonth,
                Username = employee.Username,
                Password = employee.Password,
            };
            if (_validator.ValidateAddEmployee(newEmployee.Type, _employeeRepo.GetAll().ToList(), out _errorMessage)) {
                try {
                    await Task.Run(() => { _employeeRepo.Add(newEmployee); });
                    return Ok();
                }
                catch (DbUpdateException exception)
                    when (exception?.InnerException?.Message.Contains("Cannot insert duplicate key row in object") ?? false) {
                    return BadRequest("Username already in use");
                }
            }
            else {
                return BadRequest(_errorMessage);
            }
        }

        // PUT /<CustomersController>/5
        [HttpPut]
        public async Task<ActionResult> Put(EmployeeEditDto employee) {
            var dbEmployee = await Task.Run(() => { return _employeeRepo.GetById(employee.Id); });
            if (dbEmployee == null) {
                return BadRequest("Error retrieving customer from DB");
            }
            else if (_validator.ValidateUpdateEmployee(employee.Type, dbEmployee, _employeeRepo.GetAll().ToList(), out _errorMessage)) {
                dbEmployee.Name = employee.Name;
                dbEmployee.Surname = employee.Surname;
                dbEmployee.HireDateStart = employee.HireDateStart;
                dbEmployee.HireDateEnd = employee.HireDateEnd;
                dbEmployee.SalaryPerMonth = employee.SalaryPerMonth;
                dbEmployee.Type = employee.Type;
                dbEmployee.Username = employee.Username;
                dbEmployee.Password = employee.Password;
                try {
                    await Task.Run(() => { _employeeRepo.Update(employee.Id, dbEmployee); });
                    return Ok();
                }
                catch (DbUpdateException exception)
                    when (exception?.InnerException?.Message.Contains("Cannot insert duplicate key row in object") ?? false) {
                    return BadRequest("Username already in use");
                }
            }
            else {
                return BadRequest(_errorMessage);
            }

        }

        // DELETE /<CustomersController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id) {
            var employees = _employeeRepo.GetAll().ToList();
            if (_validator.ValidateDeleteEmployee(employees.Where(e => e.Id == id).Single().Type, employees, out _errorMessage)) {
                try {
                    await Task.Run(() => { _employeeRepo.Delete(id); });
                }
                catch (DbUpdateException) {
                    return BadRequest($"Could not delete this employee because it has transactions");
                }
                catch (KeyNotFoundException) {
                    return BadRequest($"Employee not found");
                }
                return Ok();
            }
            return BadRequest(_errorMessage);
            
        }
    }
}
