using Microsoft.EntityFrameworkCore;
namespace _01SQLTest;


public class QueriesProgram
{
    public static void QueryingCategories()
    {
        using (Northwind db = new())
        {
            Helper.SectionTitle("Querying Categories and Products and Suppliers");

            IQueryable<Category>? categories = db.Categories?
                .Include(c => c.Products)
                .ThenInclude(p=>p.Supplier);

            if ((categories == null) || (!categories.Any()))
            {
                Helper.Fail("No Categories Found");
                return;
            }
            Helper.Info($"ToQueryString: {categories.ToQueryString()}");
            foreach (Category? c in categories)
            {
                Helper.Printer($"Category: {c.CategoryName} has {c.Products.Count} products.");
            
                foreach (Product? n in c.Products)
                Helper.Printer($"\tProduct : {n.ProductName} || has Supplier : {n.Supplier?.CompanyName} || Contact Name: {n.Supplier?.ContactName}");
        }
    }
}

    public static void FilteredIncludes()
    {
        using (Northwind db = new())
        {
            Helper.SectionTitle("Filtered Includes");
            string? input;
            int stock;

            do
            {
                Helper.Printer("Enter a product stock level: ");
                input = Helper.GetInput();
            } while (!int.TryParse(input, out stock));

            IQueryable<Category>? categories = db.Categories?
                .Include(c => c.Products.Where(p => p.Stock >= stock));

            if ((categories == null) || (!categories.Any()))
            {
                Helper.Fail("No Categories Found");
                return;
            }
            Helper.Info($"ToQueryString: {categories.ToQueryString()}");
            foreach (Category? c in categories)
            {
                Helper.Info($"Category: {c.CategoryName} has {c.Products.Count} products with minimum {stock}.");

                foreach (Product? p in c.Products)
                {
                    Helper.Printer($"\t{p.ProductName} has {p.Stock} in stock.");
                }
            }
        }
    }

    public static void QueryingProducts()
    {
        using (Northwind db = new())
        {
            Helper.SectionTitle("Products that cost more than a price, highest at top.");

            string? input;
            decimal price;
            do
            {
                Helper.Printer("Enter a product price: ");
                input = Helper.GetInput();
            } while (!decimal.TryParse(input, out price));

            IQueryable<Product>? products = db.Products?
                .Where(product => product.Cost > price)
                .OrderByDescending(product => product.Cost);

            if ((products is null) || (!products.Any()))
            {
                Helper.Fail("No products found.");
                return;
            }
            Helper.Info($"ToQueryString: {products.ToQueryString()}");
            foreach (Product p in products)
            {
                Helper.Printer($"{p.ProductId}: {p.ProductName} costs {p.Cost:$#,##0.00} and has {p.Stock} in stock.");
            }
        }
    }
}
