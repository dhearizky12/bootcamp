using System;

public class Animal
{
    private string Name;


    public Animal(string name)
    {
        Name = name;
        Console.WriteLine($"Creating an instance of {name}.");
    }

    ~Animal()
    {
        Console.WriteLine("Destroying the instance of " + Name);
    }
}
class Program
	{
		static void Main(string[] args)
		{
            Animal cat = new Animal("Fluffyyy");
			Animal cat2 = new Animal("Fluffy2");
			Animal cat3 = new Animal("Fluffy3");
			Animal cat4 = new Animal("Fluffy4");
            cat = null; // objek "cat" dihapus dari memori
            GC.Collect(1);
            Console.ReadKey();
           
        }
    }     
