namespace Domain.Entities;

#nullable disable

public class ProductSubcategory
{
    public int Id { get; set; }
    public int ProductCategoryId { get; set; }
    public string Name { get; set; }
}