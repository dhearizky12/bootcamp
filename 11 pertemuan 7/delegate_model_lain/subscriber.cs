namespace Day7_1;

public class Subscriber
{
    public void Subscribe(Publisher publisher)
    {
        publisher.MyEvent += MyEventHandler;
    }
    public void MyEventHandler(string name)
    {
        Console.WriteLine($"MyEventHandler: {name}");
    }
}
public class Subscriber1{
    public void Subscribe1(Publisher publisher)
    {
        publisher.MyEvent += MyEventHandler1;
    }
    public void MyEventHandler1(string name)
    {
        Console.WriteLine($"MyEventHandler1: {name}");
    }
}