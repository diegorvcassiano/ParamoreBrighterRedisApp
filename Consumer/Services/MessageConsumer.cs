using Paramore.Brighter;
using Paramore.Brighter.Redis;
using System;
using System.Threading.Tasks;

namespace ParamoreBrighterRedisApp.Consumer.Services
{
    public class MessageConsumer
    {
        private readonly IAmACommandProcessor _commandProcessor;

        public MessageConsumer(IAmACommandProcessor commandProcessor)
        {
            _commandProcessor = commandProcessor;
        }

        public async Task ReceiveMessage()
        {
            var subscriber = new RedisSubscriber("localhost", 6379, null);
            var message = await subscriber.ReceiveAsync();

            if (message != null)
            {
                // Process the message
                Console.WriteLine($"Received message: {message.Body}");
                // Acknowledge the message
                await subscriber.AcknowledgeAsync(message);
            }
        }
    }
}