using CarSercviceCenter.Orm.Repositories;
using CarServiceCenter.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Session_23.Models.CustomerModel;
using Session_23.Models.ManagerModel;

namespace Session_23.Controllers {
    public class CustomerController : Controller {

        private readonly IEntityRepo<Customer> _customerRepo;

        public CustomerController(IEntityRepo<Customer> customerRepo) {
            _customerRepo = customerRepo;
        }


        // GET: CustomerController
        public ActionResult Index() {
            var customers = _customerRepo.GetAll();

            return View(model : customers);
        }

        // GET: CustomerController/Details/5
        public ActionResult Details(int id) {
            if (id == null) {
                return NotFound();
            }

            var dbCustomer = _customerRepo.GetById(id);
            if (dbCustomer == null) {
                return NotFound();
            }

            var viewCustomer = new CustomerDetailsDto {
                Id = dbCustomer.Id,
                Name = dbCustomer.Name,
                Surname = dbCustomer.Surname,
                Tin = dbCustomer.Tin,
                Phone = dbCustomer.Phone,
                Transactions = dbCustomer.Transactions,
            };



            return View(model: viewCustomer);
        }

        // GET: CustomerController/Create
        public ActionResult Create() {
            return View();
        }

        // POST: CustomerController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CustomerCreateDto customerCreateDto) {
            try {
                if (!ModelState.IsValid) {
                    return View();
                }

                var dbCustomer = new Customer(customerCreateDto.Name, customerCreateDto.Surname, customerCreateDto.Phone, customerCreateDto.Tin);
                _customerRepo.Add(dbCustomer);
                return RedirectToAction(nameof(Index));
            }
            catch {
                return View();
            }
        }

        // GET: CustomerController/Edit/5
        public ActionResult Edit(int id) {
            var dbCustomer = _customerRepo.GetById(id);
            if (dbCustomer == null) {
                return NotFound();
            }

            var viewCustomer = new CustomerEditDto {
                Id = dbCustomer.Id,
                Name = dbCustomer.Name,
                Surname = dbCustomer.Surname,
                Phone = dbCustomer.Phone,
                Tin = dbCustomer.Tin,
            };

            return View(model: viewCustomer);
        }

        // POST: CustomerController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, CustomerEditDto customerEditDto) {
            try {
                if (!ModelState.IsValid) {
                    return View();
                }

                var dbCustomer = _customerRepo.GetById(id);
                if (dbCustomer == null) {
                    return NotFound();
                }

                dbCustomer.Name = customerEditDto.Name;
                dbCustomer.Surname = customerEditDto.Surname;
                dbCustomer.Phone = customerEditDto.Phone;
                dbCustomer.Tin = customerEditDto.Tin;

                _customerRepo.Update(id, dbCustomer);

                return RedirectToAction(nameof(Index));
            }
            catch {
                return View();
            }
        }

        // GET: CustomerController/Delete/5
        public ActionResult Delete(int id) {

            var dbCustomer = _customerRepo.GetById(id);
            if (dbCustomer == null) {
                return NotFound();
            }

            var viewCustomer = new CustomerDeleteDto {
                Id = dbCustomer.Id,
                Name = dbCustomer.Name,
                Surname = dbCustomer.Surname,
                Phone = dbCustomer.Phone,
                Tin = dbCustomer.Tin,
            };

            return View(model: viewCustomer);
        }

        // POST: CustomerController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection) {
            try {
                _customerRepo.Delete(id);
                return RedirectToAction(nameof(Index));
            }
            catch {
                return View();
            }
        }
    }
}
