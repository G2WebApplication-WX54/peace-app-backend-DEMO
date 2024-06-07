using PeaceApp.API.Communication.Domain.Model.ValueObjects;

namespace PeaceApp.API.Communication.Domain.Model.Commands
{
    public record CreateNotificationCommand
    {
        public string Message { get; }
        public Priority Priority { get; set; }

        public CreateNotificationCommand(string message, Priority priority)
        {
            Message = message;
            Priority = priority;
        }
    }
}