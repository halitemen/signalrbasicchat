using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace SignalRChat
{
    public class MessageHub : Hub
    {
        public Task SendMessageToAll(string message)
        {
            return Clients.All.SendAsync("ReceivedMessage", message);
        }
    }
}
