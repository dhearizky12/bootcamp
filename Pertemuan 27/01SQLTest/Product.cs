using System.Threading;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _01SQLTest;

public class Product
{
    public int ProductId {get;set;}

    [Required]
    [StringLength(40)]

    public string? ProductName {get;set;} = null;

    [Column ("UnitPrice",TypeName="money")]
    public decimal? Cost {get; set;}

    [Column ("UnitsInStock")]
    public short? Stock {get; set;}
    public bool Discontinued {get;set;}

    public int CategoryId {get; set;}

    public virtual Category? Category {get; set;}

     public int SupplierId {get; set;}

    public virtual Supplier? Supplier {get; set;}
}
