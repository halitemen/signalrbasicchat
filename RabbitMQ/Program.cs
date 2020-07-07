using Microsoft.AspNetCore.SignalR.Client;
using Microsoft.Extensions.Logging;
using RabbitMQ.Consumer;
using RabbitMQ.Producer;
using SignalRChat;
using System;
using System.Collections.Generic;
using System.Threading;

namespace RabbitMQ
{
    class Program
    {
        static void Main(string[] args)
        {
            var counter = 0;
            while (true)
            {
                var message = Console.ReadLine();
                RabbitMQProducer.Instance.Publish("SignalRTest", message);
                counter++;
                if (counter == 5)
                {
                    break;
                }
            }

            RabbitMQConsumer.Instance.RabbitConsumer("SignalRTest");
            Console.ReadLine();
        }
    }
}
