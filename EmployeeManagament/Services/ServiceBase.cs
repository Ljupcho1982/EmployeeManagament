using EmployeeManagament.Interfaces;

namespace EmployeeManagament.Services
{
    public class ServiceBase<T> : ICrud<T> where T : class
    {

        readonly ApplictaionDbContext context;

        protected IQueryable<T> Entities { get => context.Set<T>(); }

        public ServiceBase(ApplictaionDbContext context)
        {

            this.context = context;
        }

        public bool Add(T entity)
        {
            context.Set<T>().Add(entity);
            return context.SaveChanges() != 0;
        }

        public bool Delete(T entity)
        {
            context.Set<T>().Remove(entity);
            return context.SaveChanges() != 0;
        }

        public bool Update(T entity)
        {
            context.Set<T>().Update(entity);
            return context.SaveChanges() != 0;
        }

        public T GetbyId(int id)
        {
            return context.Set<T>().Find(id);
        }

        public List<T> GetAll()
        {
            return context.Set<T>().ToList();
        }
    }
}
