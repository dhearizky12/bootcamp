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


    public interface IDapatTerbang
    {
        void Terbang();
    }

    interface IDapatLoncat
    {
        void Loncat();
    }
       interface ISound
    {
        void Sound();
    }
class Ayam : Hewan, IDapatTerbang, IDapatLoncat
    {
        public Ayam()
        {
            BeratBadan = 5;
        }

        //Mengimplementasikan method MempertahankanDiri khas Ayam
        public override void MempertahankanDiri()
        {
            Console.WriteLine("Ayam mematuk dengan sangat keras ....!!!");
        }

        //Membuat method Terbang baru khas Ayam
        public void Terbang()
        {
            Console.WriteLine("Ayam sedang terbang ...!!!");
        }

        //Membuat method Loncat baru khas Ayam
        public void Loncat()
        {
            Console.WriteLine("Ayam sedang loncat ...!!!");
        }
class Kucing : Hewan, IDapatTerbang, IDapatLoncat
    {
        public Kucing()
        {
            BeratBadan = 5;
        }

        //Mengimplementasikan method MempertahankanDiri khas kucing
        public override void MempertahankanDiri()
        {
            Console.WriteLine("Kucing mempertahankan diri dengan mencakar");
        }

        //Membuat method Terbang untuk kucing
        public void Terbang()
        {
            Console.WriteLine("Kucing tidak bisa terbang");
        }

        //Membuat method Loncat untuk kucing
        public void Loncat()
        {
            Console.WriteLine("kucing akan loncat saat ada mangsa");
        }

         public void Sound()
        {
            Console.WriteLine("miaw");
        }


        class Program
    {
        static void Main(string[] args)
        {
            Ayam chicken = new Ayam();

            chicken.MempertahankanDiri();
            chicken.Terbang();
            chicken.Loncat();

            Console.WriteLine("Berat badan chicken : {0}", chicken.BeratBadan);

            Console.WriteLine(" ");

            Kucing memong = new Kucing();

            memong.MempertahankanDiri();
            memong.Terbang();
            memong.Loncat();
            memong.Sound();

            Console.WriteLine("Berat badan Memong : {0}", memong.BeratBadan);
        }
    }
    }
    }
}