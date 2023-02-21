using FuelStation.EF.Repositories;
using FuelStation.Model;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data.Common;
using FuelStation.Blazor.Shared.DTO.Customer;
using FuelStation.Blazor.Server.Business;

namespace FuelStation.Blazor.Server.Controllers {
    [Route("[controller]")]
    [ApiController]
    public class MonthlyLedgerController : ControllerBase {

        // Properties
        private readonly IEntityRepo<Employee> _employeeRepo;
        private readonly IEntityRepo<Transaction> _transactionRepo;

        private string _errorMessage;

        // Constructors
        public MonthlyLedgerController(IEntityRepo<Employee> employeeRepo, IEntityRepo<Transaction> transactionRepo) {
            _employeeRepo = employeeRepo;
            _transactionRepo = transactionRepo;
        }

        // GET: /<EmployeeController>
        [HttpGet]
        public async Task<IEnumerable<MonthlyLedger>> Get() {
            var employees = await Task.Run(() => { return _employeeRepo.GetAll(); });
            var transactions = await Task.Run(() => { return _transactionRepo.GetAll(); });

            var monthlyLedgerList = new MonthlyLedgerCalculator().GetAllMonthlyLedgers(employees, transactions);

            return monthlyLedgerList;
        }
    }
}
