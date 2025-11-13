using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bookstore.Domain.Products;

[Table("Product")]
public class Product
{
    [Key]
    [Column("ProductID")]
    public int ProductID { get; set; }

    [Required]
    [StringLength(15)]
    [Column("Name")]
    public string Name { get; set; }

    [Required]
    [StringLength(256)]
    [Column("ProductNumber")]
    public string ProductNumber { get; set; }

    [Required]
    [Column("SafetyStockLevel")]
    public int SafetyStockLevel { get; set; }
}