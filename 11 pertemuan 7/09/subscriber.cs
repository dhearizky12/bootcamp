// Subscriber.cs

public class EventSubscriber
{
    public void HandleEvent(object sender, EventArgs e)
    {
        Console.WriteLine("Menerima event dari " + sender.ToString());
    }
}
public class EventSubscriber1
{
    public void HandleEvent(object sender, EventArgs e)
    {
        Console.WriteLine("Menerima event2 dari " + sender.ToString());
    }
}