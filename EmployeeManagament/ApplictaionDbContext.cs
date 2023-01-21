using EmployeeManagment.Shared;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagament
{
    public class ApplictaionDbContext : DbContext
    {


        public ApplictaionDbContext(DbContextOptions<ApplictaionDbContext> options) : base(options)

        {


        }

        //Employee

        public virtual DbSet<Employee> Employee { get; set; }

        //Department

        public virtual DbSet<Department> Department { get; set; }


    }
}
