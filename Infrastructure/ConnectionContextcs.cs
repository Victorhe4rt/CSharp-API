using webApiCrud.Models;
using Microsoft.EntityFrameworkCore;
namespace webApiCrud.Infrastructure
{
    public class ConnectionContextcs : AdventureWorks2019Context
    {
        public DbSet<Employee> Employees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
    }
}
