using System;

namespace GitActions
{
    class Program
    {
        static void Main(string[] args)
        {
            var message = "Hello World!";
            var isHelloMess =  IsHelloWorldMessage(message);
            Console.WriteLine($"{message} - {isHelloMess}");
        }

        private static bool IsHelloWorldMessage(string message)
        {
            if (message == "Hello World!")
                return true;
            return false;
        }
    }
}
