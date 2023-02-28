using FuelStation.Blazor.Shared.Validator;
using FuelStation.EF.Repositories;
using FuelStation.Model;
using FuelStation.Model.Enums;

namespace CoffeShop.Web.Blazor.Shared {
    public class Validator : IValidator {
        public readonly MinMax ManagersLimits;
        public readonly MinMax CashiersLimits;
        public readonly MinMax StaffLimits;
        private IEntityRepo<Item> _productRepo;
        
        public Validator() {
            ManagersLimits = new MinMax() { Min = 1, Max = 3 };
            CashiersLimits = new MinMax() { Min = 1, Max = 4 };
            StaffLimits = new MinMax() { Min = 1, Max = 10 };
            

        }
        public bool ValidateAddEmployee(EmployeeType type, List<Employee> employees, out String errorMessage) {
            errorMessage = "Succeed ";
            bool ret = true;
            var cashiers = employees.Where(e => e.Type == EmployeeType.Cashier);
            var staffs = employees.Where(e => e.Type == EmployeeType.Staff);
            var managers = employees.Where(e => e.Type == EmployeeType.Manager)
                .Where(e => e.HireDateEnd >= DateTime.Now || e.HireDateEnd == null)
                .Where(e => e.HireDateStart <= DateTime.Now);
           
            if (type == EmployeeType.Manager && managers.Count() == ManagersLimits.Max) {
                ret = false;
                errorMessage = $"You have already {ManagersLimits.Max} Managers. Max number of managers is {ManagersLimits.Max}";
            }
            else if (type == EmployeeType.Cashier && cashiers.Count() >= CashiersLimits.Max) {
                ret = false;
                errorMessage = $"You have already {CashiersLimits.Max} Cashiers. Max number of Cashiers is {CashiersLimits.Max}";
            }
            else if(type == EmployeeType.Staff && staffs.Count() >= StaffLimits.Max) {
                ret = false;
                errorMessage = $"You have already {StaffLimits.Max} Baristas. Max number of Baristas is {StaffLimits.Max}";
            }
            return ret;
        }

        public bool ValidateUpdateEmployee(EmployeeType NewType, Employee dbEmployee, List<Employee> employees, out String errorMessage) {
            errorMessage = "Succeed ";
            bool ret = true;
            if (dbEmployee == null) {
                ret = false;
            } else if (NewType != dbEmployee.Type) {
                var cashiers = employees.Where(e => e.Type == EmployeeType.Cashier);
                var staffs = employees.Where(e => e.Type == EmployeeType.Staff);
                var managers = employees.Where(e => e.Type == EmployeeType.Manager)
                .Where(e => e.HireDateEnd >= DateTime.Now || e.HireDateEnd == null)
                .Where(e => e.HireDateStart <= DateTime.Now);
                if (NewType == EmployeeType.Manager && managers.Count() >= ManagersLimits.Max) {
                    errorMessage = $"You have already {ManagersLimits.Max} Managers. Max number of managers is {ManagersLimits.Max}";
                    ret = false;
                }
                else if(NewType == EmployeeType.Cashier && cashiers.Count() >= CashiersLimits.Max) {
                    errorMessage = $"You have already {CashiersLimits.Max} cashiers. Max number of cashiers is {CashiersLimits.Max}";
                    ret = false;
                }
                else if(NewType == EmployeeType.Staff && staffs.Count() >= StaffLimits.Max) {
                    errorMessage = $"You have already {StaffLimits.Max} Baristas. Max number of Baristas is {StaffLimits.Max}";
                    ret = false;
                }
            }
            return ret;
        }

        public bool ValidateDeleteEmployee(EmployeeType type, List<Employee> employees, out String errorMessage) {
            bool ret = true;
            errorMessage = "Succeed ";
            var cashiers = employees.Where(e => e.Type == EmployeeType.Cashier);
            var staffs = employees.Where(e => e.Type == EmployeeType.Staff);
            var managers = employees.Where(e => e.Type == EmployeeType.Manager)
                .Where(e => e.HireDateEnd >= DateTime.Now || e.HireDateEnd == null)
                .Where(e => e.HireDateStart <= DateTime.Now);
            if (type == EmployeeType.Manager && managers.Count() <= ManagersLimits.Min) {
                errorMessage = $"You have only {ManagersLimits.Min} Manager. Min number of Managers is {ManagersLimits.Min}";
                ret = false;
            }
            else if(type == EmployeeType.Cashier && cashiers.Count() <= CashiersLimits.Min) {
                errorMessage = $"You have only {CashiersLimits.Min} Cashier. Min number of Cashiers is {CashiersLimits.Min}";
                ret = false;
            }
            else if(type == EmployeeType.Staff && staffs.Count() <= StaffLimits.Min) {
                errorMessage = $"You have only {StaffLimits.Min} Barista. Min number of Baristas is {StaffLimits.Min}";
                ret = false;
            }
          

            return ret;
        }

        public bool ValidateTransaction(Transaction transaction, List<Item> products, out string errorMessage) {
            decimal transactionPreDiscountTotalPrice = 0;
            decimal fuelPreDiscountTotalPrice = 0;
            int totalFuelItems = 0;
            string transactionErrorMessage = "CAUGHT RED HANDED!!!! (for presentation purpose)";
            foreach (var transLine in transaction.TransactionLines) {
                var product = products.Find(product => product.Id == transLine.ItemId);

                if(transLine.ItemPrice != transLine.Item.Price) {
                    errorMessage = transactionErrorMessage;
                    return false;
                }

                if(transLine.NetValue != transLine.ItemPrice * transLine.Quantity) {
                    errorMessage = transactionErrorMessage;
                    return false;
                }

                if (transLine.Item.Type == ItemType.Fuel) {
                    fuelPreDiscountTotalPrice += transLine.NetValue;
                    totalFuelItems += 1;
                    if (totalFuelItems > 1) {
                        errorMessage = transactionErrorMessage;
                        return false;
                    }
                }

                transactionPreDiscountTotalPrice += transLine.NetValue;
            }

            if (fuelPreDiscountTotalPrice > 20) {
                foreach (var transLine in transaction.TransactionLines) {
                    if (transLine.Item.Type == ItemType.Fuel) {
                        if (transLine.DiscountPercent != 10) {
                            errorMessage = transactionErrorMessage;
                            return false;
                        }
                        if (transLine.DiscountValue != transLine.NetValue * 0.1M) {
                            errorMessage = transactionErrorMessage;
                            return false;
                        }
                        if(transLine.TotalValue != transLine.NetValue - transLine.DiscountValue) {
                            errorMessage = transactionErrorMessage;
                            return false;
                        }
                    }
                }
            }
            else {
                if(transaction.TotalValue != transactionPreDiscountTotalPrice) {
                    errorMessage = transactionErrorMessage;
                    return false;
                }

                foreach (var transLine in transaction.TransactionLines) {
                    if (transLine.DiscountPercent != 0) {
                        errorMessage = transactionErrorMessage;
                        return false;
                    }
                    if (transLine.NetValue != transLine.TotalValue ) {
                        errorMessage = transactionErrorMessage;
                        return false;
                    }
                }
            }
            
            errorMessage = "Succeed";
            return true;
        }
    }

    public struct MinMax {
        public int Min;
        public int Max;
    }
}
