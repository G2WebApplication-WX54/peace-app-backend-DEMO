using PeaceApp.API.Communication.Domain.Model.Aggregate;
using PeaceApp.API.Communication.Domain.Model.Queries;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PeaceApp.API.Communication.Domain.Services
{
    public interface INotificationQueryService
    {
        Task<IEnumerable<Notification>> Handle(GetAllNotificationsQuery query);
        Task<Notification?> Handle(GetNotificationByIdQuery query);
    }
}