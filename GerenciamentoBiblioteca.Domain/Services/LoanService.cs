using FluentValidation;
using LibraryManagement.Domain.Interfaces.Entities;
using LibraryManagement.Domain.Interfaces.Repositories;

namespace LibraryManagement.Domain.Services
{
    public class LoanService
    {
        private LoanValidator _loanValitor;
        public readonly ILoanRepository _loanRepository;
        public LoanService(ILoanRepository loanRepository)
        {
            _loanValitor = new LoanValidator();
            _loanRepository = loanRepository;
        }

        public int Add(ILoan entity)
        {
            Handler.Handler.Handle(_loanValitor.Validate(entity));
            return _loanRepository.Add(entity);
        }

        public IQueryable<ILoan> GetAll() =>
            _loanRepository.GetAll();

        public ILoan GetById(int id) =>
            _loanRepository.GetById(id);

        public void Update(int id, ILoan entity)
        {
            Handler.Handler.Handle(_loanValitor.Validate(entity));
            _loanRepository.Update(id, entity);
        }
    }

    public class LoanValidator : AbstractValidator<ILoan>
    {
        public LoanValidator()
        {
            RuleFor(loan => loan.Status).NotEmpty().NotNull();
        }
    }
}
