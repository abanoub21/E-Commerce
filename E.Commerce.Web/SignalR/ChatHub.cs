using Microsoft.AspNetCore.SignalR;

namespace E.Commerce.Web.SignalR
{
    public class ChatHub : Hub
    {
        public async Task sendMessage(string sender, string message)
        {
            Clients.Others.SendAsync("ReceiveMessage", sender, message);
        }
    }
}
