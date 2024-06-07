using PeaceApp.API.Communication.Domain.Model.Aggregate;
using PeaceApp.API.Communication.Interfaces.REST.Resources;

namespace PeaceApp.API.Communication.Interfaces.REST.Transform
{
    public static class NotificationResourceAssembler
    {
        public static NotificationResource ToResource(Notification notification)
        {
            return new NotificationResource(notification.GetId(), notification.GetMessage(),notification.GetPriorityAsString());
        }
    }
}