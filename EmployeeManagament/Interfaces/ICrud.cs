namespace EmployeeManagament.Interfaces
{
    public interface ICrud<T> where T : class
    {
        bool Add(T entity);
        bool Delete(T entity);
        bool Update(T entity);
        T GetbyId(int id);

        List<T> GetAll();


    }
}
