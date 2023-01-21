using EmployeeManagment.Shared;

namespace EmployeeManagament.Services
{
    public class DepartmentService : ServiceBase<Department>
    {

        public DepartmentService(ApplictaionDbContext context) : base(context)
        {

        }
    }
}
