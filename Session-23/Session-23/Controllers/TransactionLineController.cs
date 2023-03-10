using CarSercviceCenter.Orm.Repositories;
using CarServiceCenter.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Session_23.Models.TransactionLineModel;
using Session_23.Models.TransactionModel;
using System.Data.Common;

namespace Session_23.Controllers {
    public class TransactionLineController : Controller {

        private readonly IEntityRepo<TransactionLine> _transactionLineRepo;
        private readonly IEntityRepo<Engineer> _engineerRepo;
        private readonly IEntityRepo<ServiceTask> _serviceTaskRepo;
        private readonly IEntityRepo<Transaction> _transactionRepo;

        public TransactionLineController(IEntityRepo<TransactionLine> transactionLineRepo, IEntityRepo<Engineer> engineerRepo, IEntityRepo<ServiceTask> serviceTaskRepo, IEntityRepo<Transaction> transactionRepo) {
            _transactionLineRepo = transactionLineRepo;
            _engineerRepo = engineerRepo;
            _serviceTaskRepo = serviceTaskRepo;
            _transactionRepo = transactionRepo;
        }


        // GET: TransactionLineController
        public ActionResult Index() {
            return View();
        }

        // GET: TransactionLineController/Details/5
        public ActionResult Details(int id) {
            if (id == null) {
                return NotFound();
            }

            var dbTransactionLine = _transactionLineRepo.GetById(id);
            if (dbTransactionLine == null) {
                return NotFound();
            }


            var viewTransactionLine = new TransactionLineDetailsDto {
                Id = dbTransactionLine.Id,
                Hours = dbTransactionLine.Hours,
                PricePerHour = dbTransactionLine.PricePerHour,
                Price = dbTransactionLine.Price,
                Transaction = dbTransactionLine.Transaction,
                TransactionId = dbTransactionLine.TransactionId,
                Engineer = dbTransactionLine.Engineer,
                EngineerId = dbTransactionLine.EngineerId,
                ServiceTask = dbTransactionLine.ServiceTask,
                ServiceTaskId = dbTransactionLine.ServiceTaskId,
            };



            return View(model: viewTransactionLine);
        }

        // GET: TransactionLineController/Create
        public ActionResult Create(int id) {
            var transactionLineCreateDto = new TransactionLineCreateDto();
            var engineers = _engineerRepo.GetAll();
            var serviceTasks = _serviceTaskRepo.GetAll();

            transactionLineCreateDto.TransactionId = id;

            foreach (var engineer in engineers) {
                transactionLineCreateDto.Engineers.Add(new SelectListItem(engineer.Surname + " " + engineer.Name, engineer.Id.ToString()));
            }
            foreach (var serviceTask in serviceTasks) {
                transactionLineCreateDto.ServiceTasks.Add(new SelectListItem(serviceTask.Code, serviceTask.Id.ToString()));
            }

            return View(model: transactionLineCreateDto);
        }

        // POST: TransactionLineController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(int id, TransactionLineCreateDto transactionLineCreateDto) {
            try {
                if (!ModelState.IsValid) {
                    return View();
                }

                var selectedServiceTask = _serviceTaskRepo.GetById(transactionLineCreateDto.ServiceTaskId);
                decimal pricePerHour = 45.0M; //Normally should come from settings object... not implemented yet

                var dbTransactionLine = new TransactionLine(selectedServiceTask.Hours, pricePerHour, selectedServiceTask.Hours * pricePerHour) {
                    EngineerId = transactionLineCreateDto.EngineerId,
                    ServiceTaskId = transactionLineCreateDto.ServiceTaskId,
                    TransactionId = transactionLineCreateDto.TransactionId,
                };

                _transactionLineRepo.Add(dbTransactionLine);

                var currentTransaction = _transactionRepo.GetById(transactionLineCreateDto.TransactionId);
                currentTransaction.TotalPrice += dbTransactionLine.Price;
                _transactionRepo.Update(transactionLineCreateDto.TransactionId, currentTransaction);

                return RedirectToAction("Details", "Transaction", new {id = transactionLineCreateDto.TransactionId });
            }
            catch {
                return View();
            }
        }

        // GET: TransactionLineController/Edit/5
        public ActionResult Edit(int id) {
            var dbTransactionLine = _transactionLineRepo.GetById(id);
            if (dbTransactionLine == null) {
                return NotFound();
            }

            var viewTransactionLine = new TransactionLineEditDto {
                Id = dbTransactionLine.Id,
                Hours = dbTransactionLine.Hours,
                PricePerHour = dbTransactionLine.PricePerHour,
                Price = dbTransactionLine.Price,
                TransactionId = dbTransactionLine.TransactionId,
                ServiceTaskId = dbTransactionLine.ServiceTaskId,
                EngineerId = dbTransactionLine.EngineerId,
                
            };

            var engineers = _engineerRepo.GetAll();
            var serviceTasks = _serviceTaskRepo.GetAll();

            foreach (var engineer in engineers) {
                viewTransactionLine.Engineers.Add(new SelectListItem(engineer.Surname + " " + engineer.Name, engineer.Id.ToString()));
            }
            foreach (var serviceTask in serviceTasks) {
                viewTransactionLine.ServiceTasks.Add(new SelectListItem(serviceTask.Code + " " + serviceTask.Hours, serviceTask.Id.ToString()));
            }

            return View(model: viewTransactionLine);
        }

        // POST: TransactionLineController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, TransactionLineEditDto transactionLineEditDto) {
            try {
                if (!ModelState.IsValid) {
                    return View();
                }

                var dbTransactionLine = _transactionLineRepo.GetById(id);
                if (dbTransactionLine == null) {
                    return NotFound();
                }

                dbTransactionLine.Hours = transactionLineEditDto.Hours;
                dbTransactionLine.PricePerHour = transactionLineEditDto.PricePerHour;
                dbTransactionLine.Price = transactionLineEditDto.Price;
                dbTransactionLine.TransactionId = transactionLineEditDto.TransactionId;
                dbTransactionLine.EngineerId = transactionLineEditDto.EngineerId;
                dbTransactionLine.ServiceTaskId = transactionLineEditDto.ServiceTaskId;

                _transactionLineRepo.Update(id, dbTransactionLine);

                return RedirectToAction("Details", "Transaction", new { id = transactionLineEditDto.TransactionId });
            }
            catch {
                return View();
            }
        }

        // GET: TransactionLineController/Delete/5
        public ActionResult Delete(int id) {
            var dbTransactionLine = _transactionLineRepo.GetById(id);
            if (dbTransactionLine == null) {
                return NotFound();
            }

            var viewTransactionLine = new TransactionLineDeleteDto {
                Id = dbTransactionLine.Id,
                Hours = dbTransactionLine.Hours,
                PricePerHour = dbTransactionLine.PricePerHour,
                Price = dbTransactionLine.Price,
                Transaction = dbTransactionLine.Transaction,
                TransactionId = dbTransactionLine.TransactionId,
                Engineer = dbTransactionLine.Engineer,
                ServiceTask = dbTransactionLine.ServiceTask,
            };

            return View(model: viewTransactionLine);
        }

        // POST: TransactionLineController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, int transactionId) {
            //try {
                var currentTransaction = _transactionRepo.GetById(transactionId);
                var dbTransactionLine = _transactionLineRepo.GetById(id);

                currentTransaction.TotalPrice -= dbTransactionLine.Price;

                _transactionRepo.Update(transactionId, currentTransaction);

                _transactionLineRepo.Delete(id);

                
                
   
                return RedirectToAction("Details", "Transaction", new { id = transactionId });
            //}
            //catch {
            //    return View();
            //}
        }
    }
}
