using MASGlobal.Services;
using System.Web.Mvc;

namespace MASGlobal.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        [HttpGet]
        public ActionResult Index(int id = 0)
        {
            EmployeeRepository repository = new EmployeeRepository();
            if (id == 0)
            {
                var employees = repository.GetEmployees();
                return View(employees);
            }

            var employee = repository.GetEmployees(id);

            return View(employee);
        }
    }
}