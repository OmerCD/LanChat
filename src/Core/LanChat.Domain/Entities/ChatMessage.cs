namespace LanChat.Domain.Entities
{
    public class ChatMessage : UserEntity
    {
        public string Content { get; set; } = "";
        public ChatMessageType MessageType { get; set; }
        public User Sender { get; set; }
    }
    public enum ChatMessageType
    {
        Text,
        Image,
        File
    }
}
namespace System.Runtime.CompilerServices
{
    internal static class IsExternalInit {}
}