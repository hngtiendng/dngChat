using System.Threading.Tasks;
using DngChat.API.Hubs.Clients;
using DngChat.API.Models;
using Microsoft.AspNetCore.SignalR;

namespace DngChat.API.Hubs
{
    public class ChatHub : Hub<IChatClient>
    {
        // public async Task SendMessage(ChatMessage message)
        // {
        //     //await Clients.All.SendAsync("ReceiveMessage", message);
        //     await Clients.All.ReceiveMessage(message);
        // }
    }
}