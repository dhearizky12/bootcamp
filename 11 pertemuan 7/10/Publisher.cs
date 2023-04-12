public class MyEventPublisher
{
    public delegate void MyDelegate (string massage);
    public void Publisher () {
        Console.WriteLine ("harus mem-publish");
    }
    public void cancelpublish(){
        Console.WriteLine ("cancel publish");
    }
  
}