using System;
using System.Collections.Generic;
using System.Text;

namespace RabbitMQ.Interfaces
{
    public interface IRabbitMQConsumer
    {
        void RabbitConsumer(string queue);
    }
}
