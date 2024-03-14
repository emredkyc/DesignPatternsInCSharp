public class UserSubscriber : IObserver
{
    private string _name;

    public UserSubscriber(string name)
    {
        _name = name;
    }

    public void Update(string? message)
    {
        Console.WriteLine($"{_name} received message: {message}");
    }
}
