using AutoMapper;
using GerenciamentoBiblioteca.Data.Context;
using GerenciamentoBiblioteca.Data.Entities;
using LibraryManagement.Domain.Interfaces.Entities;

namespace LibraryManagement.Data.Repositories
{
    internal class NotificationRepository
    {
        public readonly LibraryManagementContext _libraryManagementContext;
        private readonly IMapper _mapper;

        public NotificationRepository(LibraryManagementContext libraryManagementContext, IMapper mapper)
        {
            _libraryManagementContext = libraryManagementContext;
            _mapper = mapper;
        }
        public int Add(INotification entity)
        {
            var client = _mapper.Map<Notification>(entity);

            _libraryManagementContext.Add(client);
            _libraryManagementContext.SaveChanges();

            return client.Id;
        }

        public IQueryable<INotification> GetAll() => _libraryManagementContext.Notification;

        public INotification GetById(int id)
        {
            var notification = _libraryManagementContext.Notification.FirstOrDefault(x => x.Id == id);
            return notification ?? throw new Exception("Notification was not found."); ;
        }

        public void Update(int id, INotification entity)
        {
            var notificationUpdate = _mapper.Map<Notification>(entity);
            var notification = GetById(id);

            notification.LoanId = notificationUpdate.LoanId;
            notification.DataEnvio = notificationUpdate.DataEnvio;
            notification.Mensagem = notificationUpdate.Mensagem;

            _libraryManagementContext.SaveChanges();
        }
    }
}
