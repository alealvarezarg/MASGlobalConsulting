using MASGlobal.Domain.Base;
using MASGlobal.Domain.DTO;
using MASGlobal.Domain.Interface;

namespace MASGlobal.BLL.Classes
{
    public class EmployeeFactory : IEmployeeFactory
    {
        public EmployeeDTO CreateEmployeeDTO(Employee employee)
        {
            var employeeDTO = new EmployeeDTO
            {
                Id = employee.Id,
                Name = employee.Name,
                ContractTypeName = employee.ContractTypeName,
                RoleId = employee.RoleId,
                RoleDescription = employee.RoleDescription
            };

            switch (employee.ContractTypeName)
            {
                case "HourlySalaryEmployee":
                    employeeDTO.AnnualSalary = 120 * employee.HourlySalary * 12;
                    break;
                case "MonthlySalaryEmployee":
                    employeeDTO.AnnualSalary = employee.MonthlySalary * 12;
                    break;
                default:
                    break;
            }

            return employeeDTO;
        }
    }
}
