using PeaceApp.API.Communication.Domain.Model.ValueObjects;
using PeaceApp.API.Communication.Domain.Model.Commands;

namespace PeaceApp.API.Communication.Domain.Model.Aggregate
{
    public class Notification
    {
        public int Id { get; private set; }
        public Message Message { get; private set; }
        public Priority Priority { get; private set; }

        public Notification()
        {
            Message = new Message();
            Priority = Priority.Medium;
        }

        public Notification(string message, Priority priority = Priority.Medium)
        {
            Message = new Message(message);
            Priority = priority;
        }

        public Notification(CreateNotificationCommand command)
        {
            Message = new Message(command.Message);
            Priority = command.Priority;
        }

        public void SetId(int id)
        {
            Id = id;
        }

        public string GetMessage() => Message.Content;
        public int GetId() => Id;
        public Priority GetPriority() => Priority;
        
        public string GetPriorityAsString() => Priority.ToString();
    }
}