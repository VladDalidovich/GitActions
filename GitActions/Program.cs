using System;
using GitActions.Services;
using Microsoft.Extensions.DependencyInjection;

namespace GitActions
{
    class Program
    {
        static void Main(string[] args)
        {
            var service = GetService();
            
            var message = "Hello World!";
            var isHelloMess =  service.IsHelloWorldMessage(message);
            Console.WriteLine($"{message} - {isHelloMess}");
        }
        
        static Service GetService()
        {
            var serviceProvider = new ServiceCollection()
                .AddScoped<Service>();
            var service = serviceProvider.BuildServiceProvider();
            return service.GetService<Service>();
        }
    }
}