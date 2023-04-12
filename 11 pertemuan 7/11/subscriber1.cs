public class MyEventSubscriber1
{
    public void MyEventHandler(string message)
    {
        Console.WriteLine("Subscriber 1 received the message: " + message);
    }
}

public class MyEventSubscriber2
{
    public void MyEventHandler(string message)
    {
        Console.WriteLine("Subscriber 2 received the message: " + message);
    }
}
public class MyEventSubscriber3
{
    public void MyEventHandler(string message)
    {
        Console.WriteLine("Subscriber 3 received the message: " + message);
    }
}