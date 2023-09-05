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

        //[HttpPost]
        //public IActionResult Add(EmployeeViewModel employeeView)
        //{
        //    var employeeConstructor = new Employee(
        //         employeeView.BusinessEntityId,
        //         employeeView.NationalIdnumber,
        //         employeeView.LoginId,
        //         employeeView.OrganizationLevel,
        //         employeeView.JobTitle,
        //         employeeView.BirthDate,
        //         employeeView.MaritalStatus,
        //         employeeView.Gender,
        //         employeeView.HireDate,
        //         employeeView.SalariedFlag,
        //         employeeView.VacationHours,
        //         employeeView.SickLeaveHours,
        //         employeeView.CurrentFlag
        //     );
        //
        //    _employeeRepository.add(employeeConstructor);
        //
        //    return Ok();
        //
        //}

        [HttpGet]
        public IActionResult Get()
        {
            var employees = _employeeRepository.Get(); 

            return Ok(employees);

        }
    }
}
