using PeaceApp.API.Communication.Domain.Model.Aggregate;
using PeaceApp.API.Communication.Domain.Model.Commands;
using System.Threading.Tasks;

namespace PeaceApp.API.Communication.Domain.Services
{
    public interface INotificationCommandService
    {
        Task<Notification?> Handle(CreateNotificationCommand command);
    }
}