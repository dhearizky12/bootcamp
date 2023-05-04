using _01SQLTest;

namespace ProgramEFCore{
    public partial class ProgramEFCore{
        static void Main()
        {
            Northwind db = new Northwind();
            Console.WriteLine(db.Database.ProviderName);
        }
    }
}