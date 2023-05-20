using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.InteropServices;
using System.Xml.Serialization;

namespace Domain.Entities;

#nullable disable
[Table("ProductCategory",Schema = "Production")]
public class ProductCategory
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
}
