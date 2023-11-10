using FluentValidation;
using LibraryManagement.Domain.Interfaces.Entities;
using LibraryManagement.Domain.Interfaces.Repositories;

namespace LibraryManagement.Domain.Services
{
    internal class StatusService
    {
        private StatusValidator _statusValitor;
        public readonly IStatusRepository _statusRepository;
        public StatusService(IStatusRepository statusRepository)
        {
            _statusValitor = new StatusValidator();
            _statusRepository = statusRepository;
        }

        public int Add(IStatus entity)
        {
            Handler.Handler.Handle(_statusValitor.Validate(entity));
            return _statusRepository.Add(entity);
        }

        public IQueryable<IStatus> GetAll() =>
            _statusRepository.GetAll();

        public IStatus GetById(int id) =>
            _statusRepository.GetById(id);

        public void Update(int id, IStatus entity)
        {
            Handler.Handler.Handle(_statusValitor.Validate(entity));
            _statusRepository.Update(id, entity);
        }
    }

    public class StatusValidator : AbstractValidator<IStatus>
    {
        public StatusValidator()
        {
            RuleFor(status => status.Name).NotEmpty().NotNull();
        }
    }
}
