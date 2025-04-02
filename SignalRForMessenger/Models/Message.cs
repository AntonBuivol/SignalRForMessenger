namespace SecureMessaging.Api.Models;

public class Message
{
    public string ChatId { get; set; }
    public string SenderId { get; set; }
    public string Content { get; set; }
    public DateTime CreatedAt { get; set; }
}