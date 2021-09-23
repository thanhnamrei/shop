using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Domain.Entities
{
    [Table("product",Schema = "production")]
    public class Product
    {
        [NotMapped]
        public int Rating { get; set; }

        [Column("name")]
        public string Name { get; set; }

        [Column("standard_cost")]
        public decimal Price { get; set; }

        [Column("description")]
        public string Description { get; set; }

        [Column("product_id")]
        public int Id { get; set; }
    }
}
