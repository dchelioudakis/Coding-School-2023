using CarSercviceCenter.Orm.Repositories;
using CarServiceCenter.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Session_23.Models.Manager;

namespace Session_23.Controllers {
    public class ManagerController : Controller {

        private readonly IEntityRepo<Manager> _managerRepo;
        //private readonly IEntityRepo<Engineer> _engineerRepo;
        //private readonly IEntityRepo<Transaction> _transactionRepo;

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
            return View();
        }

        // GET: ManagerController/Create
        public ActionResult Create() {
            return View();
        }

        // POST: ManagerController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ManagerCreateDto manager) {
            try {
                if (!ModelState.IsValid) {
                    return View();
                }

                var dbManager = new Manager(manager.Name, manager.Surname, manager.SalaryPerMonth);
                _managerRepo.Add(dbManager);
                return RedirectToAction("Index");
            }
            catch {
                return View();
            }
        }

        // GET: ManagerController/Edit/5
        public ActionResult Edit(int id) {
            return View();
        }

        // POST: ManagerController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection) {
            try {
                return RedirectToAction(nameof(Index));
            }
            catch {
                return View();
            }
        }

        // GET: ManagerController/Delete/5
        public ActionResult Delete(int id) {
            return View();
        }

        // POST: ManagerController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection) {
            try {
                return RedirectToAction(nameof(Index));
            }
            catch {
                return View();
            }
        }
    }
}
