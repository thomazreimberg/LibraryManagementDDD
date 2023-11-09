namespace LibraryManagement.Application.Interfaces
{
    public interface IBaseAppService<TEntity, TKey, TEntityGet, TEntityGetId> where TEntity : class
    {
        int Add(TEntity entity);
        void Update(TKey id, TEntity entity);
        TEntityGetId GetById(TKey id);
        List<TEntityGet> GetAll();
    }
}