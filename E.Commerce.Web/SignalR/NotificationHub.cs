using Microsoft.AspNetCore.SignalR;

namespace E.Commerce.Web.SignalR
{
    public class NotificationHub : Hub
    {
        public async Task sendMessage(string message)
        {
            Clients.All.SendAsync("display",message);
        }
    }
}
