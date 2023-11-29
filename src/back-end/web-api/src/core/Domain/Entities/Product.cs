using System.ComponentModel.DataAnnotations;

namespace Domain.Entities;

#nullable disable

public class Product
{
    [Key]
    public int Id { get; set; }

    public string Name { get; set; }
    public string ProductNumber { get; set; }
    public string Size { get; set; }
    public double Weight { get; set; }
    public string Color { get; set; }
    public decimal StandardCost { get; set; }
    public int ProductSubcategoryId { get; set; }
    public DateTime? CreatedDate { get; set; }
    public int? CreatedBy { get; set; }
    public int? ModifiedDate { get; set; }
    public DateTime? ModifiedBy { get; set; }

    public ProductSubcategory ProductSubcategory { get; set; } = null!;
    public List<ProductReview> ProductReviews { get; set; } = null!;
    public List<ProductPhoto> ProductPhotos { get; set; } = null;
}