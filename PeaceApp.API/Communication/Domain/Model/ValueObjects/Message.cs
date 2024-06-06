namespace PeaceApp.API.Communication.Domain.Model.ValueObjects
{
    public record Message(string Content)
    {
        public Message() : this(string.Empty)
        {
        }
    }
}