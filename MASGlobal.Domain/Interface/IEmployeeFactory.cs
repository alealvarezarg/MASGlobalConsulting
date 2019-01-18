using MASGlobal.Domain.Base;
using MASGlobal.Domain.DTO;

namespace MASGlobal.Domain.Interface
{
    public interface IEmployeeFactory
    {
        EmployeeDTO CreateEmployeeDTO(Employee employee);
    }
}
