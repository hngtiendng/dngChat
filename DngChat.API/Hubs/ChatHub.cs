namespace DngChat.API.Hubs
{
    public class ChatHub:Hub
    {
        public async Task SendMessage(ChatMessage message)
        {
            await Clients.All.SendAsync("ReceiveMessage", message);
        }
    }
}