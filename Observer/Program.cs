/* In this example, MessagePublisher acts as the subject that notifies its 
 * subscribers (UserSubscriber) whenever a new message is posted. 
 * Subscribers implement the IObserver interface, allowing them to be notified. 
 * This pattern decouples the publisher from its subscribers; 
 * new subscribers can be added or removed at any time without changing the publisher's code, 
 * adhering to the open/closed principle. */

MessagePublisher publisher = new MessagePublisher();

// Create subscribers
UserSubscriber alice = new UserSubscriber("Alice");
UserSubscriber bob = new UserSubscriber("Bob");

// Subscribe users to receive updates
publisher.Subscribe(alice);
publisher.Subscribe(bob);

// Post a message - all subscribers get notified
publisher.PostMessage("Hello, World!");

// Unsubscribe a user
publisher.Unsubscribe(bob);

// Post another message - only subscribed users get notified
publisher.PostMessage("Second message");