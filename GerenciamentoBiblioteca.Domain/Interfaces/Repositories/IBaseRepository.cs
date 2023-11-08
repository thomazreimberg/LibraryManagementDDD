namespace LibraryManagement.Domain.Interfaces.Repositories
{
    public interface IBaseRepository<TEntity, TKeyType> where TEntity : class
    {
        IQueryable<TEntity> GetAll();
        TEntity GetById(TKeyType id);
        TKeyType Add(TEntity entity);
        void Update(TKeyType id, TEntity entity);
    }
}
