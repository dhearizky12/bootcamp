// Hewan
using System;
namespace AbstractClassDanInterface
{
    public abstract class Hewan
    {
        private int _beratBadan;

        public int BeratBadan
        {
            get { return _beratBadan; }
            set
            {
                if (value <= 0)
                    value = 1;
                else
                    _beratBadan = value;
            }
        }
        //Ini adalah abstract method
        public abstract void MempertahankanDiri();
    }

    class Ayam : Hewan
    {
        public Ayam()
        {
            BeratBadan = 5;
        }

        //Mengimplementasikan method MempertahankanDiri khas Ayam
        public override void MempertahankanDiri()
        {
            Console.WriteLine("Ayam mematuk dengan sangat keras .... ");
        }
    }

    class Kucing : Hewan
    {
        public Kucing()
        {
            BeratBadan = 0;
        }

        //Mengimplementasikan method MempertahankanDiri khas Ayam
        public override void MempertahankanDiri()
        {
            Console.WriteLine("Kucing mencakar musuhnya.. ");
        }
    }


public class Program
{
  static void Main(string[] args)
  {
         Ayam chicken = new Ayam();

            chicken.MempertahankanDiri();
           // siImoet.Terbang();
            // siImoet.Loncat();

          Console.WriteLine("Berat badan siImoet : {0}", chicken.BeratBadan);

          Console.WriteLine(" ");      

          Kucing Memong = new Kucing();

            Memong.MempertahankanDiri();
           // siImoet.Terbang();
            // siImoet.Loncat();

          Console.WriteLine("Berat badan Memong : {0}", Memong.BeratBadan);      
  }
}
}
