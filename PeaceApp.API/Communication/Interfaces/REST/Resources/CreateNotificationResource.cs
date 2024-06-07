using PeaceApp.API.Communication.Domain.Model.ValueObjects;

namespace PeaceApp.API.Communication.Interfaces.REST.Resources
{
    public record CreateNotificationResource(string Content, Priority Priority);
}