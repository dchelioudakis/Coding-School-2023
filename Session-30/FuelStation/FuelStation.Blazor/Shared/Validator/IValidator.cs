using FuelStation.Model;
using FuelStation.Model.Enums;

namespace FuelStation.Blazor.Shared.Validator {
    public interface IValidator {
        bool ValidateAddEmployee(EmployeeType type, List<Employee> employees, out string errorMessage);
        bool ValidateDeleteEmployee(EmployeeType type, List<Employee> employees, out string errorMessage);
        bool ValidateUpdateEmployee(EmployeeType NewType, Employee dbEmployee, List<Employee> employees, out string errorMessage);
        bool ValidateTransaction(Transaction transaction, List<Item> products, out string errorMessage);
    }
}
