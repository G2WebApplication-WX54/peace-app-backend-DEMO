using System.Net.Mime;
using Microsoft.AspNetCore.Mvc;
using PeaceApp.API.Communication.Domain.Model.Queries;
using PeaceApp.API.Communication.Domain.Services;
using PeaceApp.API.Communication.Interfaces.REST.Resources;
using PeaceApp.API.Communication.Interfaces.REST.Transform;
using System.Linq;
using System.Threading.Tasks;

namespace PeaceApp.API.Communication.Interfaces.REST
{
    [ApiController]
    [Route("api/v1/[controller]")]
    [Produces(MediaTypeNames.Application.Json)]
    public class NotificationsController(INotificationCommandService notificationCommandService, INotificationQueryService notificationQueryService)
        : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> CreateNotification(CreateNotificationResource resource)
        {
            var createNotificationCommand = CreateNotificationCommandFromResourceAssembler.ToCommandFromResource(resource);
            var notification = await notificationCommandService.Handle(createNotificationCommand);
            if (notification is null) return BadRequest();
            var notificationResource = NotificationResourceAssembler.ToResource(notification);
            return CreatedAtAction(nameof(GetNotificationById), new { notificationId = notificationResource.Id }, notificationResource);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllNotifications()
        {
            var getAllNotificationsQuery = new GetAllNotificationsQuery();
            var notifications = await notificationQueryService.Handle(getAllNotificationsQuery);
            var notificationResources = notifications.Select(NotificationResourceAssembler.ToResource);
            return Ok(notificationResources);
        }

        [HttpGet("{notificationId:int}")]
        public async Task<IActionResult> GetNotificationById(int notificationId)
        {
            var getNotificationByIdQuery = new GetNotificationByIdQuery(notificationId);
            var notification = await notificationQueryService.Handle(getNotificationByIdQuery);
            if (notification == null) return NotFound();
            var notificationResource = NotificationResourceAssembler.ToResource(notification);
            return Ok(notificationResource);
        }
    }
}
