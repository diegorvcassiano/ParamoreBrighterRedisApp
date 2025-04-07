using Paramore.Brighter;
using Paramore.Brighter.Redis;
using System;
using System.Text;
using System.Threading.Tasks;

namespace ParamoreBrighterRedisApp.Producer.Services
{
    public class MessageProducer
    {
        private readonly IAmACommandProcessor _commandProcessor;

        public MessageProducer(IAmACommandProcessor commandProcessor)
        {
            _commandProcessor = commandProcessor;
        }

        public async Task SendMessage(string messageContent)
        {
            var message = new MessageModel
            {
                Id = Guid.NewGuid(),
                Content = messageContent,
                Timestamp = DateTime.UtcNow
            };

            var command = new SendMessageCommand(message);
            await _commandProcessor.SendAsync(command);
        }
    }
}