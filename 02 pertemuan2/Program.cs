using System;
namespace ConstructorDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat memong = new Cat();
            Cat memong2 = new Cat(5, "Memong", 4);
            memong.Display();
            memong2.Display();
            memong.age = 3;
            memong2.age = 5;
        }
    }

    public class Cat
    {
        public int age;
        string name;
        int legCount;
        
        public Cat()
        {
            age = 3;
            name = "Cepong";
            legCount = 4;
        }

        public Cat(int age, string name, int legCount)
        {
            this.age = age;
            this.name = name;
            this.legCount = legCount;
        }
        public void Display()
        {
            Console.WriteLine($"Kucing yang bernama {name} berumur {age}, dia memiliki kaki berjumlah {legCount}");
        }
    }
}