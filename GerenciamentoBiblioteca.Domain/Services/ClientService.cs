using FluentValidation;
using LibraryManagement.Domain.Interfaces.Entities;
using LibraryManagement.Domain.Interfaces.Repositories;

namespace LibraryManagement.Domain.Services
{
    public class ClientService
    {
        private ClientValidator _clientValitor;
        public readonly IClientRepository _clientRepository;
        public ClientService(IClientRepository authorRepository)
        {
            _clientValitor = new ClientValidator();
            _clientRepository = authorRepository;
        }

        public int Add(IClient entity)
        {
            Handler.Handler.Handle(_clientValitor.Validate(entity));
            return _clientRepository.Add(entity);
        }

        public IQueryable<IClient> GetAll() =>
            _clientRepository.GetAll();

        public IClient GetById(int id) =>
            _clientRepository.GetById(id);

        public void Update(int id, IClient entity)
        {
            Handler.Handler.Handle(_clientValitor.Validate(entity));
            _clientRepository.Update(id, entity);
        }
    }

    public class ClientValidator : AbstractValidator<IClient>
    {
        public ClientValidator()
        {
            RuleFor(client => client.Name).NotEmpty().NotNull();
        }
    }
}
