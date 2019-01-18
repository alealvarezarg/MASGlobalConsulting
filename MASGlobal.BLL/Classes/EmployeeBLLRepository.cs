using MASGlobal.Domain.DTO;
using MASGlobal.Domain.Interface;
using System.Collections.Generic;
using System.Linq;

namespace MASGlobal.BLL.Classes
{
    public class EmployeeBLLRepository : IEmployeeBLLRepository
    {
        private IEmployeeDALRepository _repository;
        private IEmployeeFactory _factory;

        public EmployeeBLLRepository(IEmployeeDALRepository repository, IEmployeeFactory factory)
        {
            _repository = repository;
            _factory = factory;
        }

        public List<EmployeeDTO> GetEmployees()
        {
            var employees = _repository.GetEmployees().Select(e => _factory.CreateEmployeeDTO(e)).ToList();

            return employees;
        }
    }
}
