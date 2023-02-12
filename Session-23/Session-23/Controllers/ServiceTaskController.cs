using CarSercviceCenter.Orm.Repositories;
using CarServiceCenter.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Session_23.Models.ManagerModel;
using Session_23.Models.ServiceTaskModel;

namespace Session_23.Controllers {
    public class ServiceTaskController : Controller {

        private readonly IEntityRepo<ServiceTask> _serviceTaskRepo;

        public ServiceTaskController(IEntityRepo<ServiceTask> serviceTaskRepo) {
            _serviceTaskRepo = serviceTaskRepo;
        }


        // GET: ServiceTaskController
        public ActionResult Index() {
            var serviceTasks = _serviceTaskRepo.GetAll();

            return View(model : serviceTasks);
        }

        // GET: ServiceTaskController/Details/5
        public ActionResult Details(int id) {
            if (id == null) {
                return NotFound();
            }

            var dbSeviceTask = _serviceTaskRepo.GetById(id);
            if (dbSeviceTask == null) {
                return NotFound();
            }

            var viewServiceTask = new ServiceTaskDetailsDto {
                Id = dbSeviceTask.Id,
                Description = dbSeviceTask.Description,
                Code = dbSeviceTask.Code,
                Hours = dbSeviceTask.Hours,
            };



            return View(model: viewServiceTask);
        }

        // GET: ServiceTaskController/Create
        public ActionResult Create() {
            return View();
        }

        // POST: ServiceTaskController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ServiceTaskCreateDto serviceTaskCreateDto) {
            try {
                if (!ModelState.IsValid) {
                    return View();
                }

                var dbSeviceTask = new ServiceTask(serviceTaskCreateDto.Code, serviceTaskCreateDto.Description, serviceTaskCreateDto.Hours);
                _serviceTaskRepo.Add(dbSeviceTask);
                return RedirectToAction(nameof(Index));
            }
            catch {
                return View();
            }
        }

        // GET: ServiceTaskController/Edit/5
        public ActionResult Edit(int id) {
            var dbSeviceTask = _serviceTaskRepo.GetById(id);
            if (dbSeviceTask == null) {
                return NotFound();
            }

            var viewServiceTask = new ServiceTaskEditDto {
                Id = dbSeviceTask.Id,
                Description = dbSeviceTask.Description,
                Code = dbSeviceTask.Code,
                Hours = dbSeviceTask.Hours,
            };

            return View(model: viewServiceTask);
        }

        // POST: ServiceTaskController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, ServiceTaskEditDto serviceTaskEditDto) {
            try {
                if (!ModelState.IsValid) {
                    return View();
                }

                var dbSeviceTask = _serviceTaskRepo.GetById(id);
                if (dbSeviceTask == null) {
                    return NotFound();
                }

                dbSeviceTask.Description = serviceTaskEditDto.Description;
                dbSeviceTask.Code = serviceTaskEditDto.Code;
                dbSeviceTask.Hours = serviceTaskEditDto.Hours;

                _serviceTaskRepo.Update(id, dbSeviceTask);

                return RedirectToAction(nameof(Index));
            }
            catch {
                return View();
            }
        }

        // GET: ServiceTaskController/Delete/5
        public ActionResult Delete(int id) {
            var dbSeviceTask = _serviceTaskRepo.GetById(id);
            if (dbSeviceTask == null) {
                return NotFound();
            }

            var viewServiceTask = new ServiceTaskDeleteDto {
                Id = dbSeviceTask.Id,
                Description = dbSeviceTask.Description,
                Code = dbSeviceTask.Code,
                Hours = dbSeviceTask.Hours,
            };



            return View(model: viewServiceTask);
        }

        // POST: ServiceTaskController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection) {
            try {
                _serviceTaskRepo.Delete(id);
                return RedirectToAction(nameof(Index));
            }
            catch {
                return View();
            }
        }
    }
}
