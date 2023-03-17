using System.ComponentModel.DataAnnotations;

namespace Domain.Entities;

#nullable disable
public class Category
{
    [Key]
    public int CategoryID { get; set; }
    public string CategoryName { get; set; }
    public string Description { get; set; }
    //public int MyProperty { get; set; }
}
