using PeaceApp.API.Communication.Domain.Model.ValueObjects;
using PeaceApp.API.Communication.Domain.Model.Commands;

namespace PeaceApp.API.Communication.Domain.Model.Aggregate
{
    public class Notification
    {
        public int Id { get; private set; }
        public Message Message { get; private set; }

        public Notification()
        {
            Message = new Message();
        }
        public Notification(string message)
        {
            Message = new Message(message);
        }

        public Notification(CreateNotificationCommand command)
        {
            Message = new Message(command.Message);
        }

        public void SetId(int id)
        {
            Id = id;
        }

        public string GetMessage() => Message.Content;
        public int GetId() => Id;
    }
}