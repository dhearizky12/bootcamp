// Program.cs

using System;

class Program
{
    static void Main(string[] args)
    {
        var publisher = new EventPublisher();
        var subscriber = new EventSubscriber();

        publisher.MyEvent += subscriber.HandleEvent;

       // publisher.DoSomething(); // Output: Received event from EventPublisher


         var subscriber1 = new EventSubscriber1();

        publisher.MyEvent += subscriber1.HandleEvent;

        publisher.DoSomething(); 
         
    }
}