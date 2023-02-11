using CarSercviceCenter.Orm.Repositories;
using CarServiceCenter.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Session_23.Models.EngineerModel;
using Session_23.Models.ManagerModel;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Text;

namespace Session_23.Controllers {
    public class EngineerController : Controller {

        private readonly IEntityRepo<Engineer> _engineerRepo;
        private readonly IEntityRepo<Manager> _managerRepo;
        // GET: EngineerController

        public EngineerController(IEntityRepo<Engineer> engineerRepo, IEntityRepo<Manager> managerRepo) {
            _engineerRepo = engineerRepo;
            _managerRepo = managerRepo;
        }

        public ActionResult Index() {
            var engineers = _engineerRepo.GetAll();


            return View(model: engineers);
        }

        // GET: EngineerController/Details/5
        public ActionResult Details(int id) {
            if (id == null) {
                return NotFound();
            }

            var dbEngineers = _engineerRepo.GetById(id);
            if (dbEngineers == null) {
                return NotFound();
            }

            var viewEngineer = new EngineerDetailsDto {
                Id = dbEngineers.Id,
                Name = dbEngineers.Name,
                Surname = dbEngineers.Surname,
                SalaryPerMonth = dbEngineers.SalaryPerMonth,
                Manager = dbEngineers.Manager,
                TransactionLines = dbEngineers.TransactionLines,
            };



            return View(model: viewEngineer);
        }

        // GET: EngineerController/Create
        public ActionResult Create() {
            var newEngineer = new EngineerCreateDto();

            var managers = _managerRepo.GetAll();
            
            foreach (var manager in managers) {
                newEngineer.Managers.Add(new SelectListItem(manager.Surname + " " + manager.Name, manager.Id.ToString()));
            }
            
            return View(model: newEngineer);
        }

        // POST: EngineerController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(EngineerCreateDto engineerDto) {
            try {
                if (!ModelState.IsValid) {
                    return View();
                }

                var dbEngineer = new Engineer(engineerDto.Name, engineerDto.Surname, engineerDto.SalaryPerMonth) {
                    ManagerId = engineerDto.ManagerId,
                };


                _engineerRepo.Add(dbEngineer);
                return RedirectToAction(nameof(Index));
            }
            catch {
                return View();
            }
        }

        // GET: EngineerController/Edit/5
        public ActionResult Edit(int id) {
            var dbEngineer = _engineerRepo.GetById(id);
            if (dbEngineer == null) {
                return NotFound();
            }

            var viewEngineer = new EngineerEditDto {
                Id = dbEngineer.Id,
                Name = dbEngineer.Name,
                Surname = dbEngineer.Surname,
                SalaryPerMonth = dbEngineer.SalaryPerMonth,
                ManagerId = dbEngineer.ManagerId,
            };

            var managers = _managerRepo.GetAll();

            foreach (var manager in managers) {
                viewEngineer.Managers.Add(new SelectListItem(manager.Surname + " " + manager.Name, manager.Id.ToString()));
            }

            return View(model: viewEngineer);
        }

        // POST: EngineerController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, EngineerEditDto engineerDto) {
            try {
                if (!ModelState.IsValid) {
                    return View();
                }

                var dbEngineer = _engineerRepo.GetById(id);
                if (dbEngineer == null) {
                    return NotFound();
                }


                dbEngineer.Name = engineerDto.Name;
                dbEngineer.Surname = engineerDto.Surname;
                dbEngineer.SalaryPerMonth = engineerDto.SalaryPerMonth;
                dbEngineer.ManagerId = engineerDto.ManagerId;

                _engineerRepo.Update(id, dbEngineer);

                return RedirectToAction(nameof(Index));

            }
            catch {
                return View();
            }


        }

        // GET: EngineerController/Delete/5
        public ActionResult Delete(int id) {
            var dbEngineer = _engineerRepo.GetById(id);
            if (dbEngineer == null) {
                return NotFound();
            }

            var viewEngineer = new EngineerDeleteDto {
                Id = dbEngineer.Id,
                Name = dbEngineer.Name,
                Surname = dbEngineer.Surname,
                SalaryPerMonth = dbEngineer.SalaryPerMonth,
                Manager = dbEngineer.Manager,
                ManagerId = dbEngineer.ManagerId,
            };



            return View(model: viewEngineer);
        }

        // POST: EngineerController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection) {
            try {
                _engineerRepo.Delete(id);
                return RedirectToAction(nameof(Index));
            }
            catch {
                return View();
            }
        }
    }
}
