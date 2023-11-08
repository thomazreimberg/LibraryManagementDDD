using LibraryManagement.Domain.Interfaces.Entities;

namespace LibraryManagement.Domain.Interfaces.Repositories
{
    public interface IBookRepository : IBaseRepository<IBook, int>
    {
    }
}
