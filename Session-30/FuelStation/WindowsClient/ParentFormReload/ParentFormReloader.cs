using FuelStation.Model.Enums;

namespace WindowsClient.ParentFormReload {
    public class ParentFormReloader {
        public async Task ReloadParentForm(EmployeeType employeeType) {
            if (employeeType == EmployeeType.Manager) {
                if (Application.OpenForms["managerForm"] != null) {
                    await (Application.OpenForms["managerForm"] as ManagerForm).FormInit();
                }
            }
            else if (employeeType == EmployeeType.Cashier) {
                if (Application.OpenForms["cashierForm"] != null) {
                    await (Application.OpenForms["cashierForm"] as CashierForm).FormInit();
                }
            }
            else if (employeeType == EmployeeType.Staff) {
                if (Application.OpenForms["staffForm"] != null) {
                    await (Application.OpenForms["staffForm"] as StaffForm).FormInit();
                }
            }
        }
    }
}
