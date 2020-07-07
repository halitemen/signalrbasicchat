using Microsoft.AspNetCore.SignalR.Client;
using System;
using System.Collections.Generic;
using System.Text;

namespace RabbitMQ
{
    public class SignalRConnection
    {
        public HubConnection ConnectionHub()
        {
            var connection = new HubConnectionBuilder()
              .WithUrl("http://localhost:10001/messages").Build();
            connection.StartAsync();
            return connection;
        }

    }
}
