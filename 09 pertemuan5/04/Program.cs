//Generic instance;
namespace MyProgram;

class Program
{
    static void Main()
    {
        GenericAutoMobile<int, int, CarDescription> myGenericClassInt = new();
        //CarDescription? myCar = myGenericClassInt.MyMethod(5,"6");
        CarDescription Toyota = new CarDescription();
        CarDescription? myCar = myGenericClassInt.CarEditor(Toyota);
        CarDescription Toyota2 = myGenericClassInt.MyMethod(5, 4);
        //myCar.NumberOfDoors = 4;
        //myCar.NumberOfWheels = 6;
        Console.WriteLine(myCar.NumberOfDoors);
        Console.WriteLine(myCar.NumberOfWheels);

        GenericAutoMobile<int, int, string> myGenericClassInt2 = new();
        CarDescription? myCar2 = myGenericClassInt2.CarEditor("tes");

    }
}

class GenericAutoMobile<TKey, TKey2, TKey3>
{
    public GenericAutoMobile()
    {
        Console.WriteLine("GenericAutoMobile constructor");
    }
    public CarDescription? MyMethod(TKey key, TKey2 key2)
    {
        if ((key is int a && key2 is int b))
        {
            CarDescription myCar = new();
            myCar.NumberOfDoors = a;
            myCar.NumberOfWheels = b;
            return myCar;
        }
        else if (key is string c && key2 is string d)
        {
            CarDescription myCar = new();
            myCar.NumberOfDoors = int.Parse(c);
            myCar.NumberOfWheels = int.Parse(d);
            return myCar;
        }
        Console.WriteLine("Invalid input");
        return null;
    }

    public CarDescription CarEditor(TKey3 key3)
    {
        if (key3 is CarDescription Car)
        {
            Car.NumberOfDoors = 5;
            Car.NumberOfWheels = 6;
            return Car;
        }
        Console.WriteLine("Invalid input in carEditor class");
        return null;
    }
}

public class CarDescription
{
    public int NumberOfDoors { get; set; }
    public int NumberOfWheels { get; set; }
    public CarDescription()
    {
        Console.WriteLine("GenericCar constructor");
    }
}