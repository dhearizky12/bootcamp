using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace _01SQLTest;

public class Category
{
    [Key]
    public int CategoryId {get;set;}
    [Required] //tidak boleh null
    [StringLength (15)]

    public string? CategoryName {get; set;}

    [Column (TypeName = "ntext")]

    public string? Description {get; set;}

    public virtual ICollection <Product> Products {get; set;} // untuk one to many
    //pakai virtual karena nanti ada eager loading dan easy loading
    //eager loading => semua di load
    // lazy loading => hanya load sesuatu yang akan diakses (seeprti streaming => parsial)
    //manual loading => menentukan sendiri apa yang mau diambil

    public Category ()
    {
        Products = new HashSet<Product>(); //hashet itu harus unik
    }
}
