//enum


enum OrderStatus
{
    Pending,
    Processing,
    Shipped,
    Delivered,
    Cancelled
}

class Program
{
    static void Main()
    {

        //Console.WriteLine("orderId = " +orderId);

        Console.Write("Enter the value of order ID: ");
        int orderId = int.Parse(Console.ReadLine());

        OrderStatus status = GetOrderStatus(orderId);

        if (status == OrderStatus.Processing)
        {
            Console.WriteLine("This order is currently being processed.");
        }
        else if (status == OrderStatus.Delivered)
        {
            Console.WriteLine("This order has been delivered.");
        }
        else
        {
            Console.WriteLine("This order is in a different status.");
        }
    }

    static OrderStatus GetOrderStatus(int orderId)
    {
        if (orderId > 0 && orderId <= 100)
        {
            return OrderStatus.Delivered;
        }
         if (orderId == 0)
          {
            return OrderStatus.Cancelled;
        }
         if (orderId > 100)
          {
            return OrderStatus.Processing;
        }
        else
        {
            return OrderStatus.Pending;
        }
    }
}