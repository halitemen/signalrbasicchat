using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.SignalR;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SignalRChat
{
    public class MessageHub : Hub
    {

        public Task SendMessageToAll(string message)
        {
            // Call the broadcastMessage method to update clients.
            return Clients.All.SendAsync("ReceivedMessage",
                $"{Context.ConnectionId + "- Id li Clientin mesajı =>" + message}");
        }

      
        public override Task OnConnectedAsync()
        {
            System.Console.WriteLine("Yeni bir bağlantı: " + Context.ConnectionId);
            Clients.All.SendAsync("YeniBaglanti", "Yeni bir giriş algılandı.", Context.ConnectionId);
            return base.OnConnectedAsync();
        }


        public override Task OnDisconnectedAsync(System.Exception exception)
        {
            System.Console.WriteLine("Kapatılan bağlantı: " + Context.ConnectionId);
            Clients.All.SendAsync("KapatilanBaglanti", "Bağlantı kapatıldı.", Context.ConnectionId);
            return base.OnDisconnectedAsync(exception);
        }
    }
}
