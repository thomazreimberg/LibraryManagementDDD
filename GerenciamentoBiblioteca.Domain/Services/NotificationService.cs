using FluentValidation;
using LibraryManagement.Domain.Interfaces.Entities;
using LibraryManagement.Domain.Interfaces.Repositories;

namespace LibraryManagement.Domain.Services
{
    internal class NotificationService
    {
        private NotificationValidator _notificationValitor;
        public readonly INotificationRepository _notificationRepository;
        public NotificationService(INotificationRepository notificationRepository)
        {
            _notificationValitor = new NotificationValidator();
            _notificationRepository = notificationRepository;
        }

        public int Add(INotification entity)
        {
            Handler.Handler.Handle(_notificationValitor.Validate(entity));
            return _notificationRepository.Add(entity);
        }

        public IQueryable<INotification> GetAll() =>
            _notificationRepository.GetAll();

        public INotification GetById(int id) =>
            _notificationRepository.GetById(id);

        public void Update(int id, INotification entity)
        {
            Handler.Handler.Handle(_notificationValitor.Validate(entity));
            _notificationRepository.Update(id, entity);
        }
    }

    public class NotificationValidator : AbstractValidator<INotification>
    {
        public NotificationValidator()
        {
            RuleFor(notification => notification.Name).NotEmpty().NotNull();
        }
    }
}
