namespace webApiCrud.Models
{
    public interface IEmployeeRepository
    {
        void add(Employee employee);

        List<Employee> Get();    
    }
}
