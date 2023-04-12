public class Program
{
    static void Main(string[] args)
    {
        var publisher = new MyEventPublisher();
        var subscriber1 = new MyEventSubscriber1();
        // publisher.DoSomething();
        var subscriber2 = new MyEventSubscriber2();
        publisher.MyEvent += subscriber1.MyEventHandler;
        publisher.MyEvent += subscriber2.MyEventHandler;
         var subscriber3 = new MyEventSubscriber3();
        publisher.MyEvent += subscriber3.MyEventHandler;
        publisher.DoSomething();
       // publisher.OnMyEvent("Hello World");
    }
}