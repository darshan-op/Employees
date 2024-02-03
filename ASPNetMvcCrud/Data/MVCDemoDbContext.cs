using ASPNetMvcCrud.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace ASPNetMvcCrud.Data
{
    public class MVCDemoDbContext: DbContext
    {
        public MVCDemoDbContext(DbContextOptions options) : base(options)
        {

        }
        //use the employee as a dbcontext and name the property as employees which
        //will be the table name which gets created ultimately from the EF Core migration
        public DbSet<Employee> Employees { get; set; }
    }
}
