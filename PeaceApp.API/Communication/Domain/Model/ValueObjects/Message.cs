namespace PeaceApp.API.Communication.Domain.Model.ValueObjects
{
    public record Message
    {
        public string message { get; }

        public Message() : this(string.Empty)
        {
        }

        public Message(string message)
        {
            if (string.IsNullOrWhiteSpace(message))
            {
                throw new ArgumentException("Message cannot be null or blank");
            }

            this.message = message;
        }

        public string GetMessage() => message;
    }
}