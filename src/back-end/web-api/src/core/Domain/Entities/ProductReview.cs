namespace Domain.Entities;

#nullable disable
public class ProductReview
{
    public int ProductId { get; set; }
    public string ReviewerName { get; set; }
    public DateTime ReviewDate { get; set; }
    public string EmailAddress { get; set; }
    public string Comments { get; set; }
}