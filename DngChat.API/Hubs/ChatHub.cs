namespace DngChat.API.Hubs
{
    public class ChatHub:Hub<IChatClient>
    {
        public async Task SendMessage(ChatMessage message)
        {
            //await Clients.All.SendAsync("ReceiveMessage", message);
            await Clients.All.ReceiveMessage(message);
        }
    }
}