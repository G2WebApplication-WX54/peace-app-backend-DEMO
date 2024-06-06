using PeaceApp.API.Communication.Domain.Model.Aggregate;
using PeaceApp.API.Communication.Domain.Model.Queries;
using PeaceApp.API.Communication.Domain.Services;
using PeaceApp.API.Communication.Domain.Repositories;

namespace PeaceApp.API.Communication.Application.Internal.QueryServices
{
    public class NotificationQueryService(INotificationRepository notificationRepository) : INotificationQueryService
    {
        public async Task<IEnumerable<Notification>> Handle(GetAllNotificationsQuery query)
        {
            return await notificationRepository.GetAllAsync();
        }

        public async Task<Notification?> Handle(GetNotificationByIdQuery query)
        {
            return await notificationRepository.GetByIdAsync(query.Id);
        }
    }
}