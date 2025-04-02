using Microsoft.AspNetCore.SignalR;
using SecureMessaging.Api.Models;

namespace SecureMessaging.Api.Hubs;

public class ChatHub : Hub
{
    public async Task SendMessage(string chatId, string content)
    {
        var message = new Message
        {
            ChatId = chatId,
            SenderId = Context.ConnectionId,
            Content = content,
            CreatedAt = DateTime.UtcNow
        };

        await Clients.Group(chatId).SendAsync("ReceiveMessage", message);
    }

    public async Task JoinChat(string chatId)
    {
        await Groups.AddToGroupAsync(Context.ConnectionId, chatId);
    }
}