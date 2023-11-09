namespace LibraryManagement.Domain.Interfaces.Services
{
    public interface IBaseService<TEntity, TKey> where TEntity : class
    {
        TKey Add(TEntity entity);
        void Update(TKey id, TEntity entity);
        TEntity GetById(TKey id);
        IQueryable<TEntity> GetAll();
    }
}