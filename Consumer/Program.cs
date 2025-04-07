using System;
using Paramore.Brighter;
using Paramore.Brighter.Redis;
using Microsoft.Extensions.DependencyInjection;
using System.Threading.Tasks;

namespace ParamoreBrighterRedisApp.Consumer
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var serviceProvider = new ServiceCollection()
                .AddBrighter(options =>
                {
                    options.UseRedis(new RedisSubscriber(Environment.GetEnvironmentVariable("REDIS_HOST") ?? "localhost", 6379));
                })
                .BuildServiceProvider();

            var messageConsumer = serviceProvider.GetService<IAmACommandProcessor>();

            Console.WriteLine("Listening for messages...");
            while (true)
            {
                await messageConsumer.ReceiveAsync();
            }
        }
    }
}