using BusinessLib;
using CarSercviceCenter.Orm.Repositories;
using CarServiceCenter.Model;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Session_23.Controllers {
    public class MonthlyLedgerController : Controller {

        private readonly IEntityRepo<Manager> _managerRepo;
        private readonly IEntityRepo<Engineer> _engineerRepo;
        private readonly IEntityRepo<Transaction> _transactionRepo;

        public MonthlyLedgerController(IEntityRepo<Manager> managerRepo, IEntityRepo<Engineer> engineerRepo, IEntityRepo<Transaction> transactionRepo) {
            _managerRepo = managerRepo;
            _engineerRepo = engineerRepo;
            _transactionRepo = transactionRepo;
        }

        public IActionResult Index() {
            var monthlyLedgers = new List<MonthlyLedger>();
            var engineers = _engineerRepo.GetAll();
            var managers = _managerRepo.GetAll();
            var transactions = _transactionRepo.GetAll();

            var business = new Business();
            monthlyLedgers = business.GetAllMonthlyLedgers(engineers, managers, transactions);


            return View(model: monthlyLedgers);
        }

    }
}
