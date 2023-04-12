namespace Program;

class Program 
{
    static void Main() {
        ProductFood myProductFood = GenericOnlineShop.DisplayProduct<string, int>("Burger",6000);
        ProductFood myProductFood2 = GenericOnlineShop.DisplayProduct<string, int>("Burger",8000);
       // ProductFood myproductfood2 = GenericOnlineShop.DisplayProduct<string, string>("Burger","5000");
        Console.WriteLine(myProductFood.Name);
        Console.WriteLine(myProductFood.Price);
        //GenericOnlineShop.SetProduct<ProductFood>(myProductFood);
       // GenericOnlineShop.SetProduct<ProductFood>(myproductfood2);
        //myProductFood= GenericOnlineShop.ProductEditor<string, int>("Pizza",11000);
        Console.WriteLine(myProductFood2.Name);
        Console.WriteLine(myProductFood2.Price);
    }
}

static class GenericOnlineShop
{
    public static ProductFood internalProduct;
    public static ProductFood? DisplayProduct<T, T2>(T a, T2 b)
    {
        if(a is string keyone && b is int keytwo) 
        {
            ProductFood myProductFood = new ProductFood();
            myProductFood.Name = keyone;
            myProductFood.Price = keytwo;
            return myProductFood;
        }
        return null;
    }
    public static void SetProduct<T>(T a) {
        if(a is ProductFood myProductFood)
            internalProduct = myProductFood;
        else
            Console.WriteLine("Invalid input");
    }
    public static ProductFood? ProductEditor<T, T2>(T a, T2 b){
        if(a is string keyone && b is int keytwo) 
        {
            internalProduct.Name = keyone;
            internalProduct.Price = keytwo;
            return internalProduct;
        }
        return null;
    }
}

public class ProductFood
{
    public string Name { get; set; }
    public int Price { get; set; }
    public int Quantity { get; set; }
    public string Description { get; set; }
}