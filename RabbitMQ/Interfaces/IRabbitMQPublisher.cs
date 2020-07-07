using System;
using System.Collections.Generic;
using System.Text;

namespace RabbitMQ.Interfaces
{
    public interface IRabbitMQPublisher
    {
        void Publish(string queueName, object message);
    }
}
