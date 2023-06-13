using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities;

#nullable disable

[Table("ProductSubcategory", Schema = "Production")]
public class ProductSubcategory
{
    public int Id { get; set; }
    public int ProductCategoryId { get; set; }
    public string Name { get; set; }
    public int Index { get; set; }
}