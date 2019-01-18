using MASGlobal.Domain.Base;
using System.Collections.Generic;

namespace MASGlobal.Domain.Interface
{
    public interface IEmployeeDALRepository
    {
        List<Employee> GetEmployees();
    }
}
