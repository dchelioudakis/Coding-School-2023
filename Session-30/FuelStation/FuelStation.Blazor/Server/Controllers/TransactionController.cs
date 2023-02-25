using FuelStation.EF.Repositories;
using FuelStation.Model;
using FuelStation.Model.Enums;
using FuelStation.Blazor.Shared.DTO.Customer;
using FuelStation.Blazor.Shared.DTO.Employee;
using FuelStation.Blazor.Shared.DTO.Item;
using FuelStation.Blazor.Shared.DTO.Transaction;
using FuelStation.Blazor.Shared.DTO.TransactionLine;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using System.Data.Common;

namespace FuelStation.Blazor.Server.Controllers {
    [Route("[controller]")]
    [ApiController]
    public class TransactionController : ControllerBase {

        // Properties
        private readonly IEntityRepo<Transaction> _transactionRepo;
        //private readonly IValidator _validator;
        private string _errorMessage;

        // Constructors
        public TransactionController(IEntityRepo<Transaction> transactionRepo) {
            _transactionRepo = transactionRepo;
            //_validator = validator;
            _errorMessage = string.Empty;
        }

        // GET: /<CustomersController>
        [HttpGet]
        public async Task<IEnumerable<TransactionListDto>> Get() {
            var result = await Task.Run(() => { return _transactionRepo.GetAll(); });
            var selectTransactionList = result.Select(transaction => new TransactionListDto {
                Id = transaction.Id,
                Date = transaction.Date,
                PaymentMethod = transaction.PaymentMethod,
                TotalValue = transaction.TotalValue,
                EmployeeId = transaction.EmployeeId,
                CustomerId = transaction.CustomerId,
            });
            return selectTransactionList;
        }

        // GET: /<CustomersController>/5
        [HttpGet("{id}")]
        public async Task<TransactionEditDto?> GetById(int id) {
            var dbTransaction = await Task.Run(() => { return _transactionRepo.GetById(id); });
            if (dbTransaction == null) {
                return null;
            }
            TransactionEditDto transaction = new TransactionEditDto {
                Id = id,
                Date = dbTransaction.Date,
                PaymentMethod = dbTransaction.PaymentMethod,
                TotalValue = dbTransaction.TotalValue,
                EmployeeId = dbTransaction.EmployeeId,
                CustomerId = dbTransaction.CustomerId,
                Customer = new CustomerEditDto() {
                    Name = dbTransaction.Customer.Name,
                    Surname = dbTransaction.Customer.Surname,
                    CardNumber = dbTransaction.Customer.CardNumber,
                },
                TransactionLines = dbTransaction.TransactionLines.Select(transactionLine => new TransactionLineEditDto {
                    Id = transactionLine.Id,
                    Quantity = transactionLine.Quantity,
                    ItemPrice = transactionLine.ItemPrice,
                    NetValue = transactionLine.NetValue,
                    DiscountPercent = transactionLine.DiscountPercent,
                    DiscountValue = transactionLine.DiscountValue,
                    TotalValue = transactionLine.TotalValue,
                    TransactionId = transactionLine.TransactionId,
                    ItemId = transactionLine.ItemId,
                }).ToList()
            };
            return transaction;
        }

        // POST /<CustomersController>
        [HttpPost]
        public async Task<ActionResult> Post(TransactionEditDto transaction) {
            var newTransaction = new Transaction(transaction.Date, transaction.EmployeeId, transaction.CustomerId, transaction.PaymentMethod, transaction.TotalValue) {
                TransactionLines = transaction.TransactionLines.Select(transactionLine => new TransactionLine(transactionLine.TransactionId, transactionLine.ItemId) {
                    Id = transactionLine.Id,
                    Quantity = transactionLine.Quantity,
                    ItemPrice = transactionLine.ItemPrice,
                    NetValue = transactionLine.NetValue,
                    DiscountPercent = transactionLine.DiscountPercent,
                    DiscountValue = transactionLine.DiscountValue,
                    TotalValue = transactionLine.TotalValue,
                }).ToList()
            };
            await Task.Run(() => { _transactionRepo.Add(newTransaction); });
            return Ok();
            //if (_validator.ValidateAddCustomer(_customerRepo.GetAll().ToList(), out _errorMessage)) {
            //    try {
            //        await Task.Run(() => { _customerRepo.Add(newCustomer); });
            //        return Ok();
            //    }
            //    catch (DbException ex) {
            //        return BadRequest(ex.Message);
            //    }
            //}
            //else {
            //    return BadRequest(_errorMessage);
            //}
        }

        // PUT /<CustomersController>/5
        [HttpPut]
        public async Task Put(TransactionEditDto transaction) {
            var dbTransaction = await Task.Run(() => { return _transactionRepo.GetById(transaction.Id); });
            if (dbTransaction == null) {
                // TODO if customer is null
                return;
            }
            dbTransaction.Date = transaction.Date;
            dbTransaction.PaymentMethod = transaction.PaymentMethod;
            dbTransaction.TotalValue = transaction.TotalValue;
            dbTransaction.CustomerId = transaction.CustomerId;
            dbTransaction.EmployeeId = transaction.EmployeeId;
            dbTransaction.TransactionLines = transaction.TransactionLines
                .Select(transactionLine => new TransactionLine(
                    transactionLine.TransactionId,
                    transactionLine.ItemId) {
                    Id = transactionLine.Id,
                    Quantity = transactionLine.Quantity,
                    ItemPrice = transactionLine.ItemPrice,
                    NetValue = transactionLine.NetValue,
                    DiscountPercent = transactionLine.DiscountPercent,
                    DiscountValue = transactionLine.DiscountValue,
                    TotalValue = transactionLine.TotalValue,
                }).ToList();

            _transactionRepo.Update(transaction.Id, dbTransaction);
        }

        // DELETE /<CustomersController>/5
        [HttpDelete("{id}")]
        public async Task Delete(int id) {
            await Task.Run(() => {
                _transactionRepo.Delete(id);
            });
        }
    }
}
