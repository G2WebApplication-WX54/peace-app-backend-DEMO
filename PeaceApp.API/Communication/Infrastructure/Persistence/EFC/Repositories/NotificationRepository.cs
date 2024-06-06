using PeaceApp.API.Communication.Domain.Model.Aggregate;
using PeaceApp.API.Shared.Infrastructure.Persistence.EFC.Configuration;
using PeaceApp.API.Shared.Infrastructure.Persistence.EFC.Repositories;
using Microsoft.EntityFrameworkCore;
using PeaceApp.API.Communication.Domain.Repositories;
namespace PeaceApp.API.Communication.Infrastructure.Persistence.EFC.Repositories;

    public class NotificationRepository(AppDbContext context) : BaseRepository<Notification>(context), INotificationRepository
    {
        public Task<IEnumerable<Notification>> GetAllAsync()
        {
            return Task.FromResult<IEnumerable<Notification>>(Context.Set<Notification>().ToList());
        }

        public Task<Notification?> GetByIdAsync(int id)
        {
            return Context.Set<Notification>().FirstOrDefaultAsync(n => n.Id == id);
        }
    }