using CarSercviceCenter.Orm.Repositories;
using CarServiceCenter.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Session_23.Models.ManagerModel;

namespace Session_23.Controllers {
    public class ManagerController : Controller {

        private readonly IEntityRepo<Manager> _managerRepo;
       

        public ManagerController(IEntityRepo<Manager> managerRepo) {
            _managerRepo = managerRepo;
        }




        // GET: ManagerController
        public ActionResult Index() {
            var managers = _managerRepo.GetAll();
            
            
            return View(model: managers);
        }

        // GET: ManagerController/Details/5
        public ActionResult Details(int id) {
            if(id == null) {
                return NotFound();
            }

            var dbManager = _managerRepo.GetById(id);
            if (dbManager == null) {
                return NotFound();
            }

            var viewManager = new ManagerDetailsDto {
                Id = dbManager.Id,
                Name = dbManager.Name,
                Surname = dbManager.Surname,
                SalaryPerMonth = dbManager.SalaryPerMonth,
                Engineers = dbManager.Engineers,
                Transactions = dbManager.Transactions,
            };

            

            return View(model: viewManager);
        }

        // GET: ManagerController/Create
        public ActionResult Create() {
            return View();
        }

        // POST: ManagerController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ManagerCreateDto managerCreateDto) {
            try {
                if (!ModelState.IsValid) {
                    return View();
                }

                var dbManager = new Manager(managerCreateDto.Name, managerCreateDto.Surname, managerCreateDto.SalaryPerMonth);
                _managerRepo.Add(dbManager);
                return RedirectToAction(nameof(Index));
            }
            catch {
                return View();
            }
        }

        // GET: ManagerController/Edit/5
        public ActionResult Edit(int id) {

            var dbManager = _managerRepo.GetById(id);
            if (dbManager == null) {
                return NotFound();
            }

            var viewManager = new ManagerEditDto {
                Id = dbManager.Id,
                Name = dbManager.Name,
                Surname = dbManager.Surname,
                SalaryPerMonth = dbManager.SalaryPerMonth,
            };

            return View(model: viewManager);
        }

        // POST: ManagerController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, ManagerEditDto managerEditDto) {
            try {
                if (!ModelState.IsValid) {
                    return View();
                }

                var dbManager = _managerRepo.GetById(id);
                if (dbManager == null) {
                    return NotFound();
                }

                dbManager.Name = managerEditDto.Name;
                dbManager.Surname = managerEditDto.Surname;
                dbManager.SalaryPerMonth = managerEditDto.SalaryPerMonth;

                _managerRepo.Update(id, dbManager);

                return RedirectToAction(nameof(Index));

            }
            catch {
                return View();
            }
        }

        // GET: ManagerController/Delete/5
        public ActionResult Delete(int id) {
            var dbManager = _managerRepo.GetById(id);
            if (dbManager == null) {
                return NotFound();
            }

            var viewManager = new ManagerDeleteDto {
                Id = dbManager.Id,
                Name = dbManager.Name,
                Surname = dbManager.Surname,
                SalaryPerMonth = dbManager.SalaryPerMonth,
            };



            return View(model: viewManager);
        }

        // POST: ManagerController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection) {
            try {
                _managerRepo.Delete(id);
                return RedirectToAction(nameof(Index));
            }
            catch {
                return View();
            }

        }
    }
}
