using LibraryManagement.Domain.Interfaces.Entities;

namespace LibraryManagement.Domain.Interfaces.Repositories
{
    public interface ILoanRepository : IBaseRepository<ILoan, int>
    {
    }
}
