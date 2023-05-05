using _01SQLTest;

namespace ProgramEFCore
{
    public partial class Program
	{
		static void Main()
		{
			Northwind db = new Northwind();
			Console.WriteLine(db.Database.ProviderName);
			MenuProgram();
		}

		static void MenuProgram()
		{
			string? input;
			bool isValidInput = false;
			Console.Clear();
			while (!isValidInput)
			{
				Console.WriteLine("1) Querying Categories and Products");
				Console.WriteLine("2) Filtered Includes");
				Console.WriteLine("3) Querying Products");
				Console.WriteLine("4) Adding a Category");
				Console.WriteLine("5) Adding a Product");
				Console.WriteLine("6) Updating a Product");
				Console.WriteLine("7) Deleting a Product");
				Console.WriteLine("8) Deleting a Category");
				Console.WriteLine("X) Exit");
				Console.Write("Enter a command: ");
				input = Helper.GetInput();

				switch (input?.ToLower())
				{
					case "1":
                    QueriesProgram.QueryingCategories();
						break;
					case "2":
						QueriesProgram.FilteredIncludes();
						break;
					case "3":
						QueriesProgram.QueryingProducts();
						break;
					case "4":
						CUDProgram.AddCategory();
						break;
					case "5":
						CUDProgram.AddProduct();
						break;
					case "6":
						CUDProgram.UpdateProduct();
						break;
                    case "7":
                       CUDProgram.DeleteProduct();  
                       break;
					case "8":
						CUDProgram.DeleteCategory();
						break;
					case "9":
						CUDProgram.DeleteProduct();
						break;
					case "x":
						isValidInput = true;
						break;
					default:
						Console.WriteLine("Invalid input. Please try again.");
						break;
				}
			}
		}
	}
}