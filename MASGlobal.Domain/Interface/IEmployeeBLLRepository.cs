using MASGlobal.Domain.DTO;
using System.Collections.Generic;

namespace MASGlobal.Domain.Interface
{
    public interface IEmployeeBLLRepository
    {
        List<EmployeeDTO> GetEmployees();
    }
}
