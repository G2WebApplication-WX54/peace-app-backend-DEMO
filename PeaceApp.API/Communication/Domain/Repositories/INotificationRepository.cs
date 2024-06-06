using PeaceApp.API.Communication.Domain.Model.Aggregate;
using PeaceApp.API.Shared.Domain.Repositories;
namespace PeaceApp.API.Communication.Domain.Repositories;

public interface INotificationRepository: IBaseRepository<Notification>
    {
        Task<IEnumerable<Notification>> GetAllAsync();
        Task<Notification?> GetByIdAsync(int id);
}