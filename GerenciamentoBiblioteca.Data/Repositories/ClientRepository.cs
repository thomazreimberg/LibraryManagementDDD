using AutoMapper;
using GerenciamentoBiblioteca.Data.Context;
using GerenciamentoBiblioteca.Data.Entities;
using LibraryManagement.Domain.Interfaces.Entities;
using LibraryManagement.Domain.Interfaces.Repositories;

namespace LibraryManagement.Data.Repositories
{
    public class ClientRepository : IClientRepository
    {
        public readonly LibraryManagementContext _libraryManagementContext;
        private readonly IMapper _mapper;

        public ClientRepository(LibraryManagementContext libraryManagementContext, IMapper mapper)
        {
            _libraryManagementContext = libraryManagementContext;
            _mapper = mapper;
        }
        public int Add(IClient entity)
        {
            var client = _mapper.Map<Client>(entity);

            _libraryManagementContext.Add(client);
            _libraryManagementContext.SaveChanges();

            return client.Id;
        }

        public IQueryable<IClient> GetAll() => _libraryManagementContext.Client;

        public IClient GetById(int id)
        {
            var client = _libraryManagementContext.Client.FirstOrDefault(x => x.Id == id);
            return client ?? throw new Exception("Client was not found."); ;
        }

        public void Update(int id, IClient entity)
        {
            var clientUpdate = _mapper.Map<Client>(entity);
            var client = GetById(id);

            client.Phone = clientUpdate.Phone;
            client.Email = clientUpdate.Email;
            client.RegistrationDate = clientUpdate.RegistrationDate;
            client.Name = clientUpdate.Name;

            _libraryManagementContext.SaveChanges();
        }
    }
}
