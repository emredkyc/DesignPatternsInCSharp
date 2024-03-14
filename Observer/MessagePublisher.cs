public class MessagePublisher : IMessagePublisher
{
    private List<IObserver> _observers = new List<IObserver>();
    private string? _latestMessage;

    public void Subscribe(IObserver observer)
    {
        if (!_observers.Contains(observer))
        {
            _observers.Add(observer);
        }
    }

    public void Unsubscribe(IObserver observer)
    {
        if (_observers.Contains(observer))
        {
            _observers.Remove(observer);
        }
    }

    public void NotifySubscribers()
    {
        foreach (IObserver observer in _observers)
        {
            observer.Update(_latestMessage);
        }
    }

    public void PostMessage(string message)
    {
        _latestMessage = message;
        Console.WriteLine($"MessagePublisher: Posting message - {message}");
        NotifySubscribers();
    }
}
