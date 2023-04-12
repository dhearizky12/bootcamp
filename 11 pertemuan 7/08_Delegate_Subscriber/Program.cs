 class Program
    {
        static void Main(string[] args)
        {
            Publisher publisher = new Publisher();
            Subscriber subscriber = new Subscriber();

            // Subscribe to the event
            publisher.SomethingHappened += subscriber.OnSomethingHappened;

            // Trigger the event
            publisher.DoSomething();

            // Unsubscribe from the event
            publisher.SomethingHappened -= subscriber.OnSomethingHappened;

            Console.ReadKey();
        }
    }
