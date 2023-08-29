using webApiCrud.Models;
using webApiCrud.Infrastructure; 
namespace webApiCrud.Infrastructure
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly ConnectionContextcs _connectionContext = new ConnectionContextcs();
        public void add(Employee employee)
        {
            _connectionContext.Add(employee);
            _connectionContext.SaveChanges(); 
        }

        public List<Employee> Get()
        {
            return _connectionContext.Employees.ToList();   
        }
    }
}
