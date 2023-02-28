using FuelStation.EF.Repositories;
using FuelStation.Model;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data.Common;
using FuelStation.Blazor.Shared.DTO.Customer;
using FuelStation.Blazor.Server.Business;
using FuelStation.Model.OptionsModel;
using FuelStation.Blazor.Shared.DTO.Settings;

namespace FuelStation.Blazor.Server.Controllers {
    [Route("[controller]")]
    [ApiController]
    public class MonthlyLedgerController : ControllerBase {

        // Properties
        private readonly IEntityRepo<Employee> _employeeRepo;
        private readonly IEntityRepo<Transaction> _transactionRepo;
        private readonly IEntityRepo<StationSettings> _settingsRepo;

        private string _errorMessage;

        // Constructors
        public MonthlyLedgerController(IEntityRepo<Employee> employeeRepo, IEntityRepo<Transaction> transactionRepo, IEntityRepo<StationSettings> settingsRepo) {
            _employeeRepo = employeeRepo;
            _transactionRepo = transactionRepo;
            _settingsRepo = settingsRepo;
        }

        // GET: /<EmployeeController>
        [HttpGet]
        public async Task<IEnumerable<MonthlyLedger>> Get() {
            var employees = await Task.Run(() => { return _employeeRepo.GetAll(); });
            var transactions = await Task.Run(() => { return _transactionRepo.GetAll(); });
            var settings = await Task.Run(() => { return _settingsRepo.GetById(1); });

            var monthlyLedgerList = new MonthlyLedgerCalculator(settings).GetAllMonthlyLedgers(employees, transactions);

            return monthlyLedgerList;
        }
    }
}
