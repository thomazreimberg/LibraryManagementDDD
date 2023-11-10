using AutoMapper;
using GerenciamentoBiblioteca.Data.Context;
using GerenciamentoBiblioteca.Data.Entities;
using LibraryManagement.Domain.Interfaces.Entities;
using LibraryManagement.Domain.Interfaces.Repositories;

namespace LibraryManagement.Data.Repositories
{
    public class LoanRepository : ILoanRepository
    {
        public readonly LibraryManagementContext _libraryManagementContext;
        private readonly IMapper _mapper;

        public LoanRepository(LibraryManagementContext libraryManagementContext, IMapper mapper)
        {
            _libraryManagementContext = libraryManagementContext;
            _mapper = mapper;
        }
        public int Add(ILoan entity)
        {
            var loan = _mapper.Map<Loan>(entity);

            _libraryManagementContext.Add(loan);
            _libraryManagementContext.SaveChanges();

            return loan.Id;
        }

        public IQueryable<ILoan> GetAll() => _libraryManagementContext.Loan;

        public ILoan GetById(int id)
        {
            var loan = _libraryManagementContext.Loan.FirstOrDefault(x => x.Id == id);
            return loan ?? throw new Exception("Loan was not found."); ;
        }

        public void Update(int id, ILoan entity)
        {
            var loanUpdate = _mapper.Map<Loan>(entity);
            var loan = GetById(id);

            loan.LoanDate = loanUpdate.LoanDate;
            loan.DevolutionDate = entity.LoanDate;
            loan.Status = loanUpdate.Status;
            loan.BookId = entity.BookId;
            loan.ClientId = entity.ClientId;
            loan.Status = entity.Status;

            _libraryManagementContext.SaveChanges();
        }
    }
}
