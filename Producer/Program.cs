using System;
using Paramore.Brighter;
using Paramore.Brighter.Redis;
using System.Threading.Tasks;

namespace ParamoreBrighterRedisApp.Producer
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var redisConfig = new RedisConfig
            {
                Host = Environment.GetEnvironmentVariable("REDIS_HOST") ?? "localhost",
                Port = 6379,
                Password = Environment.GetEnvironmentVariable("REDIS_PSW") // Default to null if not set
            };

            var messageProducer = new MessageProducer(redisConfig);
            await messageProducer.SendMessage("Hello, Redis!");
            Console.WriteLine("Message sent to Redis.");
        }
    }
}