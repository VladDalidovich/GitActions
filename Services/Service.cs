namespace GitActions.Services
{
    public class Service
    {
        public bool IsHelloWorldMessage(string message)
        {
            if (message == "Hello World!")
                return true;
            return false;
        }
    }
}