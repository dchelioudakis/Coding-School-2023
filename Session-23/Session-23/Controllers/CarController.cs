using CarSercviceCenter.Orm.Repositories;
using CarServiceCenter.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Session_23.Models.CarModel;
using Session_23.Models.ManagerModel;

namespace Session_23.Controllers {
    public class CarController : Controller {

        private readonly IEntityRepo<Car> _carRepo;

        public CarController(IEntityRepo<Car> carRepo) {
            _carRepo = carRepo;
        }


        // GET: CarController
        public ActionResult Index() {
            var cars = _carRepo.GetAll();

            return View(model: cars);
        }

        // GET: CarController/Details/5
        public ActionResult Details(int id) {
            if (id == null) {
                return NotFound();
            }

            var dbCar = _carRepo.GetById(id);
            if (dbCar == null) {
                return NotFound();
            }

            var viewCar = new CarDetailsDto {
                Id = dbCar.Id,
                Brand = dbCar.Brand,
                Model = dbCar.Model,
                CarRegistrationNumber = dbCar.CarRegistrationNumber,
                Transactions = dbCar.Transactions,
            };



            return View(model: viewCar);
        }

        // GET: CarController/Create
        public ActionResult Create() {
            return View();
        }

        // POST: CarController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CarCreateDto carCreateDto) {
            try {
                if (!ModelState.IsValid) {
                    return View();
                }

                var dbCar = new Car(carCreateDto.Brand, carCreateDto.Model, carCreateDto.CarRegistrationNumber);
                _carRepo.Add(dbCar);
                return RedirectToAction(nameof(Index));
            }
            catch {
                return View();
            }
        }

        // GET: CarController/Edit/5
        public ActionResult Edit(int id) {
            var dbCar = _carRepo.GetById(id);
            if (dbCar == null) {
                return NotFound();
            }

            var viewCar = new CarEditDto {
                Id = dbCar.Id,
                Brand = dbCar.Brand,
                Model = dbCar.Model,
                CarRegistrationNumber = dbCar.CarRegistrationNumber,
            };

            return View(model: viewCar);
        }

        // POST: CarController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, CarEditDto carEditDto) {
            try {
                if (!ModelState.IsValid) {
                    return View();
                }

                var dbCar = _carRepo.GetById(id);
                if (dbCar == null) {
                    return NotFound();
                }

                dbCar.Brand = carEditDto.Brand;
                dbCar.Model = carEditDto.Model;
                dbCar.CarRegistrationNumber = carEditDto.CarRegistrationNumber;

                _carRepo.Update(id, dbCar);

                return RedirectToAction(nameof(Index));
            }
            catch {
                return View();
            }
        }

        // GET: CarController/Delete/5
        public ActionResult Delete(int id) {
            var dbCar = _carRepo.GetById(id);
            if (dbCar == null) {
                return NotFound();
            }

            var viewCar = new CarDeleteDto {
                Id = dbCar.Id,
                Brand = dbCar.Brand,
                Model = dbCar.Model,
                CarRegistrationNumber = dbCar.CarRegistrationNumber,
            };

            return View(model: viewCar);
        }

        // POST: CarController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection) {
            try {
                _carRepo.Delete(id);
                return RedirectToAction(nameof(Index));
            }
            catch {
                return View();
            }
        }
    }
}
