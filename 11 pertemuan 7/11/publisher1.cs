using System;

public class MyEventPublisher
{
    public delegate void MyDelegate(string message);
    public event MyDelegate MyEvent;

    public void DoSomething()
    {
        Console.WriteLine("Akan ada hal yang harus di publish");
        OnMyEvent("ini adalah METHOD ON MY EVENT DARI CLASS MY EVENT PUBLISHER");
    }

    protected virtual void OnMyEvent(string message) //tidak bisa terima return
    {
        MyEvent?.Invoke(message);
         Console.WriteLine("selesai");
    }
}