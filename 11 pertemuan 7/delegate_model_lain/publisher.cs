namespace Day7_1;

public class Publisher
{
    public delegate void MyDelegate(string name);
    public event MyDelegate? MyEvent;
    public void DoSomething()
    {
        Console.WriteLine("Do something");
        RaiseEvent("Nama saya");
    }
    public virtual void RaiseEvent(string name)
    {
        MyEvent?.Invoke(name);
    }
}