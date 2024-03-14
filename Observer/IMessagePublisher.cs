public interface IMessagePublisher
{
    void Subscribe(IObserver observer);
    void Unsubscribe(IObserver observer);
    void NotifySubscribers();
}
