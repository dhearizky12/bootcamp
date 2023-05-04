using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Sqlite;
using System.IO;

namespace _01SQLTest;

public class Northwind : DbContext //DbContext adalah concrate class
{
    private string path = String.Empty;
    public DbSet<Product>? Products { get; set; }
    
    public DbSet<Category>? Categories { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        //string path = "D:/Dhea_Bootcamp/learn/Pertemuan 27/01SQLTest/Northwind.db";
        path = Path.Combine(Environment.CurrentDirectory, "Northwind.db");
        string connectionPath = $"Data Source = {path}";
        optionsBuilder.UseSqlite(connectionPath);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Category>()
        .Property(c => c.CategoryName)
        .IsRequired()
        .HasMaxLength(15);

        if (Database.ProviderName?.Contains("Sqlite") ?? false)
        {
            modelBuilder.Entity<Product>()
            .Property(p => p.Cost)
            .HasConversion<double>();
        }
    }
}
