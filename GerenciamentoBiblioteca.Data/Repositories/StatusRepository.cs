using AutoMapper;
using GerenciamentoBiblioteca.Data.Context;
using GerenciamentoBiblioteca.Data.Entities;
using LibraryManagement.Domain.Interfaces.Entities;

namespace LibraryManagement.Data.Repositories
{
    internal class StatusRepository
    {
        public readonly LibraryManagementContext _libraryManagementContext;
        private readonly IMapper _mapper;

        public StatusRepository(LibraryManagementContext libraryManagementContext, IMapper mapper)
        {
            _libraryManagementContext = libraryManagementContext;
            _mapper = mapper;
        }
        public int Add(IStatus entity)
        {
            var status = _mapper.Map<Status>(entity);

            _libraryManagementContext.Add(status);
            _libraryManagementContext.SaveChanges();

            return status.Id;
        }

        public IQueryable<IStatus> GetAll() => _libraryManagementContext.Status;

        public IStatus GetById(int id)
        {
            var status = _libraryManagementContext.Status.FirstOrDefault(x => x.Id == id);
            return status ?? throw new Exception("Status was not found."); ;
        }

        public void Update(int id, IStatus entity)
        {
            var statusUpdate = _mapper.Map<Status>(entity);
            var status = GetById(id);

            status.Name = statusUpdate.Name;

            _libraryManagementContext.SaveChanges();
        }
    }
}
