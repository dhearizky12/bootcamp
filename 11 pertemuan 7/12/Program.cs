class MainProgram 
{
    static void Main(string[] args) 
    {
        Publisher myPublisher = new Publisher();
        Subscriber mySubscriber = new Subscriber();
        SecondSub mySecondSub = new SecondSub();
        myPublisher.MyEvent += mySubscriber.Notification;
        myPublisher.MyEvent += mySecondSub.Notification;
        myPublisher.InvokeEvent("Running on ");
    }
}

public class Publisher 
{
    public delegate void MyDelegate(string message);
    public event MyDelegate MyEvent;

    public void InvokeEvent(string message)
    {
        if (MyEvent != null)
        {
            foreach (MyDelegate del in MyEvent.GetInvocationList())
            {
                del.Invoke(message);
                Thread.Sleep(5000);
            }
        }
    }
}

public class Subscriber
{
    public void Notification(string message) 
    {
        Console.WriteLine( message + "First Subscriber");
    }
}

public class SecondSub
{
    public void Notification(string message)
    {
        Console.WriteLine( message + "Second Subscriber");
    }
}