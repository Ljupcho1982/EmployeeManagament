using EmployeeManagment.Shared;

namespace EmployeeManagament.Services
{
    public class EmployeeService : ServiceBase<Employee>
    {

        public EmployeeService(ApplictaionDbContext context) : base(context)
        {

        }
    }
}
