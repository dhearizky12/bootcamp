using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace monopoli_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Game monopoly = new Game();
            monopoly.Create();
            monopoly.Start();

            Console.ReadKey();
        }
    }
}