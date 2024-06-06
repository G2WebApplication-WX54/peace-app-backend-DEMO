using PeaceApp.API.Communication.Domain.Model.ValueObjects;
using PeaceApp.API.Communication.Domain.Model.Commands;

namespace PeaceApp.API.Communication.Domain.Model.Aggregate
{
    public class Notification
    {
        private Message Message { get; set; }

        public Notification(string content)
        {
            Message = new Message(content);
        }

        public Notification(CreateNotificationCommand command)
        {
            Message = new Message(command.Content);
        }

        public Notification()
        {
        }

        public void UpdateMessage(string content)
        {
            Message = new Message(content);
        }

        public string GetMessage()
        {
            return Message.GetMessage();
        }
    }
}