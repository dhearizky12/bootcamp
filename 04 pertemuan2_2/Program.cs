using System;
namespace ConstructorDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat memong = new Cat();
            //memong.name = "Memong";
            memong.SetName("Memong");
            memong.SetAge (5);
            Console.WriteLine(memong.GetName() +" " + memong.GetAge());
            memong.SetName("Cepong");
            Console.WriteLine(memong.GetName());
        }
    }

    public class Cat
    {
        private string? name;

        public void SetName(string? name)
        {
            this.name = name;
        }
        public string? GetName()
        {
            return name;
        }
    

        private int age;

        public void SetAge(int age)
        {
            this.age = age;
        }
        public int GetAge()
        {
            return age;
        }
    }
}