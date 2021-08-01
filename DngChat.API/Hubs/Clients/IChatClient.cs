using System.Threading.Tasks;
using DngChat.API.Models;

namespace DngChat.API.Hubs.Clients
{
    public interface IChatClient
    {
        Task ReceiveMessage(ChatMessage message);
    }
}