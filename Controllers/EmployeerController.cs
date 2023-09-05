using Microsoft.AspNetCore.Mvc;
using webApiCrud.Models;
using webApiCrud.ViewModel; 

namespace webApiCrud.Controllers
{
    [ApiController]
    [Route("api/v1/employee")]
    public class EmployeerController : ControllerBase
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeerController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository ?? throw new ArgumentNullException(nameof(employeeRepository));
        }

      
        [HttpGet]
        public IActionResult Get()
        {
            var employees = _employeeRepository.Get(); 

            return Ok(employees);

        }
    }
}
