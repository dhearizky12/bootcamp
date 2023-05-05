namespace _01SQLTest;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


public class Supplier
{
    public int SupplierId { get; set; }

    [Required]
    //[StringLength(40)]

    public string? CompanyName { get; set; } = null;
    [StringLength(40)]

    public string? ContactName { get; set; } = null;
    [StringLength(40)]

    public string? ContactTitle { get; set; } = null;
    [StringLength(30)]
    public string? Address { get; set; } = null;
    [StringLength(60)]

    public string? City { get; set; } = null;
    [StringLength(60)]

    public virtual ICollection<Product> Products { get; set; } = new HashSet<Product>(); // untuk one to many
    //pakai virtual karena nanti ada eager loading dan easy loading
    //eager loading => semua di load
    // lazy loading => hanya load sesuatu yang akan diakses (seeprti streaming => parsial)
    //manual loading => menentukan sendiri apa yang mau diambil

    // public Supplier()
    // {
    //     Products = new HashSet<Product>(); //hashet itu harus unik
    // }

    //public virtual Supplier? Supplier { get; set; }
}
