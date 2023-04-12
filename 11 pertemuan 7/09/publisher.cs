// Publisher.cs

public delegate void EventHandler(object sender, EventArgs e);

public class EventPublisher
{
    public event EventHandler MyEvent;

    public void DoSomething()
    {
        // Do some work...

        // Notify subscribers of the event
        MyEvent?.Invoke(this, EventArgs.Empty);
    }
}