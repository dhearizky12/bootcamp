using System;

namespace Day7_1
{
    static class Program
    {
       // delegate T MyDelegate<T>(string name);
        public static void Main()
        {
            Publisher publisher = new ();
            Subscriber subscriber = new ();
            //Subscriber1 subscriber1 = new ();
            //publisher.MyEvent += subscriber.MyEventHandler;
            //ini digunakan untuk mendaftarkan subsriber ke publisher, jika tidak di daftarkan maka tidak akan menerima event, dan hanya output do something
           // publisher.MyEvent += subscriber.MyEventHandler;
            // // kalau pakai += dia akan mendaftarkan subscriber baru dan tidak akan menghapus yang lama jadi akan memberikan value yang ada di RaiseEVent yaitu Hello
            //publisher.MyEvent += subscriber1.MyEventHandler1;
            //publisher.MyEvent += su
            publisher.DoSomething();
            //publisher.DoSomething();
            subscriber.Subscribe(publisher)
;
            publisher.DoSomething();
            // Console.WriteLine("Hello World!");
        }
    }
}