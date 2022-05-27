namespace Series.src.Interfaces
{
    public interface IRepository<T>
    {
         List<T> SeriesList();
         T ReturnId(int id);
         void Insert(T entity);
         void Delete(int id);
         void Update(int id, T entity);
         int NextId();
    }
}