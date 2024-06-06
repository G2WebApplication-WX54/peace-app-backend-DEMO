using PeaceApp.API.Communication.Domain.Model.Aggregate;
using PeaceApp.API.Communication.Domain.Model.Commands;
using PeaceApp.API.Communication.Domain.Repositories;
using PeaceApp.API.Communication.Domain.Services;
using PeaceApp.API.Shared.Domain.Repositories;

namespace PeaceApp.API.Communication.Application.Internal.CommandServices
{
    public class NotificationCommandService(INotificationRepository notificationRepository, IUnitOfWork unitOfWork) : INotificationCommandService
    {
        public async Task<Notification?> Handle(CreateNotificationCommand command)
        {
            var notification = new Notification(command);
            try
            {
                await notificationRepository.AddAsync(notification);
                await unitOfWork.CompleteAsync();
                return notification;
            } 
            catch (Exception e)
            {
                Console.WriteLine($"An error occurred while creating the notification: {e.Message}");
                return null;
            }
        }
    }
}