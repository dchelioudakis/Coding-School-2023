using CarSercviceCenter.Orm.Repositories;
using CarServiceCenter.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Session_23.Models.ManagerModel;
using Session_23.Models.TransactionModel;

namespace Session_23.Controllers {
    public class TransactionController : Controller {

        private readonly IEntityRepo<Transaction> _transactionRepo;
        private readonly IEntityRepo<ServiceTask> _serviceTaskRepo;
        private readonly IEntityRepo<Customer> _customerRepo;
        private readonly IEntityRepo<Car> _carRepo;
        private readonly IEntityRepo<Manager> _managerRepo;
        private readonly IEntityRepo<Engineer> _engineerRepo;

        public TransactionController(IEntityRepo<Transaction> transactionRepo, IEntityRepo<Customer> customerRepo, IEntityRepo<Car> carRepo, IEntityRepo<Manager> managerRepo, IEntityRepo<ServiceTask> serviceTaskRepo, IEntityRepo<Engineer> engineerRepo) {
            _transactionRepo = transactionRepo;
            _customerRepo = customerRepo;
            _carRepo = carRepo;
            _managerRepo = managerRepo;
            _serviceTaskRepo = serviceTaskRepo;
            _engineerRepo = engineerRepo;
        }



        // GET: TransactionController
        public ActionResult Index() {
            var transactions = _transactionRepo.GetAll();
            return View(model : transactions);
        }

        // GET: TransactionController/Details/5
        public ActionResult Details(int id) {
            if (id == null) {
                return NotFound();
            }

            var dbTransaction = _transactionRepo.GetById(id);
            if (dbTransaction == null) {
                return NotFound();
            }

            //Bring related to transaction engineers and ServiceTasks to view
            foreach (var line in dbTransaction.TransactionLines) {
                line.ServiceTask = _serviceTaskRepo.GetById(line.ServiceTaskId);
                line.Engineer = _engineerRepo.GetById(line.EngineerId);
            }


            var viewTransaction = new TransactionDetailsDto {
                Id = dbTransaction.Id,
                Date = dbTransaction.Date,
                TotalPrice = dbTransaction.TotalPrice,
                Manager = dbTransaction.Manager,
                Customer = dbTransaction.Customer,
                Car = dbTransaction.Car,
                TransactionLines = dbTransaction.TransactionLines,
            };



            return View(model: viewTransaction);
        }

        // GET: TransactionController/Create
        public ActionResult Create() {
            var transactionCreateDto = new TransactionCreateDto();
            var managers = _managerRepo.GetAll();
            var customers = _customerRepo.GetAll();
            var cars = _carRepo.GetAll();


            foreach (var manager in managers) {
                transactionCreateDto.Managers.Add(new SelectListItem(manager.Surname + " " + manager.Name, manager.Id.ToString()));
            }
            foreach (var customer in customers) {
                transactionCreateDto.Customers.Add(new SelectListItem(customer.Surname + " " + customer.Name, customer.Id.ToString()));
            }
            foreach (var car in cars) {
                transactionCreateDto.Cars.Add(new SelectListItem(car.CarRegistrationNumber + " " + car.Brand + " " + car.Model, car.Id.ToString()));
            }

            //transactionCreateDto.TransactionLines;


            return View(model : transactionCreateDto);
        }

        // POST: TransactionController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(TransactionCreateDto transactionCreateDto) {
            try {
                if (!ModelState.IsValid) {
                    return View();
                }

                var dbTransaction = new Transaction(transactionCreateDto.Date, transactionCreateDto.TotalPrice) {
                    ManagerId = transactionCreateDto.ManagerId,
                    CustomerId = transactionCreateDto.CustomerId,
                    CarId = transactionCreateDto.CarId,
                };

                _transactionRepo.Add(dbTransaction);
                return RedirectToAction(nameof(Index));
            }
            catch {
                return View();
            }
        }

        // GET: TransactionController/Edit/5
        public ActionResult Edit(int id) {
            var dbTransaction = _transactionRepo.GetById(id);
            if (dbTransaction == null) {
                return NotFound();
            }

            var viewTransaction = new TransactionEditDto {
                Id = dbTransaction.Id,
                Date = dbTransaction.Date,
                TotalPrice = dbTransaction.TotalPrice,
                ManagerId = dbTransaction.ManagerId,
                CustomerId = dbTransaction.CustomerId,
                CarId = dbTransaction.CarId,
                //TransactionLines = dbTransaction.TransactionLines,
            };

            var managers = _managerRepo.GetAll();
            var customers = _customerRepo.GetAll();
            var cars = _carRepo.GetAll();


            foreach (var manager in managers) {
                viewTransaction.Managers.Add(new SelectListItem(manager.Surname + " " + manager.Name, manager.Id.ToString()));
            }
            foreach (var customer in customers) {
                viewTransaction.Customers.Add(new SelectListItem(customer.Surname + " " + customer.Name, customer.Id.ToString()));
            }
            foreach (var car in cars) {
                viewTransaction.Cars.Add(new SelectListItem(car.CarRegistrationNumber + " " + car.Brand + " " + car.Model, car.Id.ToString()));
            }


            return View(model: viewTransaction);
        }

        // POST: TransactionController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, TransactionEditDto transactionEditDto) {
            try {
                if (!ModelState.IsValid) {
                    return View();
                }

                var dbTransaction = _transactionRepo.GetById(id);
                if (dbTransaction == null) {
                    return NotFound();
                }

                dbTransaction.Date = transactionEditDto.Date;
                dbTransaction.TotalPrice = transactionEditDto.TotalPrice;
                dbTransaction.ManagerId = transactionEditDto.ManagerId;
                dbTransaction.CarId = transactionEditDto.CarId;
                dbTransaction.CustomerId = transactionEditDto.CustomerId;

                _transactionRepo.Update(id, dbTransaction);

                return RedirectToAction(nameof(Index));
            }
            catch {
                return View();
            }

        }

        // GET: TransactionController/Delete/5
        public ActionResult Delete(int id) {
            var dbTransaction = _transactionRepo.GetById(id);
            if (dbTransaction == null) {
                return NotFound();
            }

            var viewTransaction = new TransactionDeleteDto {
                Id = dbTransaction.Id,
                Date = dbTransaction.Date,
                TotalPrice = dbTransaction.TotalPrice,
                Manager = dbTransaction.Manager,
                Customer = dbTransaction.Customer,
                Car = dbTransaction.Car,
                TransactionLines = dbTransaction.TransactionLines,
            };



            return View(model: viewTransaction);
        }

        // POST: TransactionController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection) {
            try {
                _transactionRepo.Delete(id);
                return RedirectToAction(nameof(Index));
            }
            catch {
                return View();
            }
        }
    }
}
