using MASGlobal.Domain.DTO;
using MASGlobal.Domain.Interface;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace MASGlobal.Controllers
{
    public class EmployeeWAController : ApiController
    {
        private IEmployeeBLLRepository _repository;

        public EmployeeWAController(IEmployeeBLLRepository repository)
        {
            _repository = repository;
        }

        // GET api/<controller>
        public IEnumerable<EmployeeDTO> GetEmployees()
        {
            var employees = _repository.GetEmployees();

            return employees;
        }

        // GET api/<controller>/5
        public IEnumerable<EmployeeDTO> GetEmployees(int id)
        {
            var employees = _repository.GetEmployees().Where(e => e.Id == id);

            return employees;
        }
    }
}