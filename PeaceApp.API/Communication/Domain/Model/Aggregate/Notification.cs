using PeaceApp.API.Communication.Domain.Model.ValueObjects;

namespace PeaceApp.API.Communication.Domain.Model.Aggregate
{
    public class Notification
    {
        public Message message { get; private set; }

        public Notification(string message)
        {
            this.message = new Message(message);
        }

        public Notification()
        {
        }

        public void UpdateMessage(string message)
        {
            this.message = new Message(message);
        }

        public string GetMessage()
        {
            return message.GetMessage();
        }
    }
}