using Microsoft.EntityFrameworkCore;
using System;


namespace _01SQLTest;

public class CUDProgram
{
    public static void AddCategory()
    {
        using (Northwind db = new())
        {
            Helper.SectionTitle("Adding a Category");

            Helper.Printer("Enter the category name : ");
            string? name = Helper.GetInput();

            Category? category = new Category
            {
                CategoryName = name
            };

        db.Categories?.Add(category);
        db.SaveChanges();

        Helper.Info("Category added successfully.");

    }
}
public static void DeleteCategory()
{
    using (Northwind db = new())
    {
        Helper.SectionTitle("Deleting a Category");

        Helper.Printer("Enter the category ID: ");
        string input = Helper.GetInput()??"";
        int? id = int.Parse(input);
        

        Category? category = db.Categories?.Find(id);

        if (category is null)
        {
            Helper.Fail("Category not found.");
            return;
        }

        db.Categories?.Remove(category);
        db.SaveChanges();

        Helper.Info("Category deleted successfully.");

    }
}
public static void AddProduct()
{
    using (Northwind db = new())
    {
        Helper.SectionTitle("Adding a Product");

        Helper.Printer("Enter the product name: ");
        string? name = Helper.GetInput();

        Helper.Printer("Enter the product price: ");
        string input = Helper.GetInput() ?? "";
        decimal? price = decimal.Parse(input);

        Helper.Printer("Enter the product stock level: ");
        input = Helper.GetInput() ?? "";
        short stock = short.Parse(input);

        Helper.Printer("Enter the category ID: ");
        input = Helper.GetInput() ?? "";
        int categoryId = int.Parse(input);

        Product product = new Product
        {
            ProductName = name,
            Cost = price,
            Stock = stock,
            CategoryId = categoryId
        };

        db.Products?.Add(product);
        db.SaveChanges();

        Helper.Info("Product added successfully.");
    }
}
public static void UpdateProduct()
{
    using (Northwind db = new())
    {
        Helper.SectionTitle("Updating a Product");

        Helper.Printer("Enter the product ID: ");
        string? input = Helper.GetInput();
        int? id = int.Parse(input);

        Product? product = db.Products?.Find(id);

        if (product is null)
        {
            Helper.Fail("Product not found.");
            return;
        }

        Helper.Printer("Enter the new product name (leave empty to keep the existing name): ");
        string? name = Helper.GetInput();

        if (!string.IsNullOrEmpty(name))
        {
            product.ProductName = name;
        }

        Helper.Printer("Enter the new product price (leave empty to keep the existing price): ");
        input = Helper.GetInput();

        if (!string.IsNullOrEmpty(input))
        {
            product.Cost = decimal.Parse(input);
        }

        Helper.Printer("Enter the new product stock level (leave empty to keep the existing stock level): ");
        input = Helper.GetInput();

        if (!string.IsNullOrEmpty(input))
        {
            product.Stock = short.Parse(input);
        }

        Helper.Printer("Enter the new category ID (leave empty to keep the existing category): ");
        input = Helper.GetInput();

        if (!string.IsNullOrEmpty(input))
        {
            product.CategoryId = int.Parse(input);
        }

        db.SaveChanges();

        Helper.Info("Product updated successfully.");
    }
}
public static void DeleteProduct()
{
    using (Northwind db = new())
    {
        Helper.SectionTitle("Deleting a Product");

        Helper.Printer("Enter the product ID: ");
        string input = Helper.GetInput();
        int id = int.Parse(input);

        Product? product = db.Products?.Find(id);

        if (product is null)
        {
            Helper.Fail("Product not found.");
            return;
        }

        db.Products?.Remove(product);
        db.SaveChanges();

        Helper.Info("Product deleted successfully.");
    }
}
}
