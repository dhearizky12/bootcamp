using System.Diagnostics.Contracts;

class Program
{
    static void Main(string[] args)
    {
        int x = -5;
        int y = 10;

        //Contract.Requires(x >= 0 , "x harus lebih dari 0" );	
        //Contract.Requires(y >= 0, "y harus lebih dari 0");

        Contract.Ensures (x >= 0 , "x harus lebih dari 0");
        Contract.Ensures (y >= 0 , "x harus lebih dari 0");

        //Contract.Assert(x >= 0 , "x harus lebih dari 0" );
        //Contract.Assert(y >= 0, "y harus lebih dari 0");


        int z = x + y;
        Contract.Ensures(z > x && z > y);

        Console.WriteLine("The value of z is: " + z);
    }
}
