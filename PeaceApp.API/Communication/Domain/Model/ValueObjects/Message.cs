namespace PeaceApp.API.Communication.Domain.Model.ValueObjects
{
    public record Message
    {
        private string Content { get; }

        public Message() : this(string.Empty)
        {
        }

        public Message(string Content)
        {
            if (string.IsNullOrWhiteSpace(Content))
            {
                throw new ArgumentException("Message cannot be null or blank");
            }

            this.Content = Content;
        }

        public string GetMessage() => Content;
    }
}