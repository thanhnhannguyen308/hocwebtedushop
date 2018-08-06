using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;
using TeduShop.Model.Abstract;

namespace TeduShop.Model.Models
{
    [Table("Products")]
    public class Product : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        [MaxLength(256)]
        public string Name { get; set; }

        [Required]
        [MaxLength(256)]
        [Column(TypeName ="varchar")]
        public string Alias { get; set; }

        public int CategoryID { get; set; }

        [MaxLength(500)]
        public string Image { get; set; }

        public XElement MoreImages { get; set; }
        public decimal Price { get; set; }
        public decimal? Promotion { get; set; }
        public int? Warranty { get; set; }
        public string Content { get; set; }
        public bool? HotFlag { get; set; }

        [Required]
        public int ViewCount { get; set; }

        [ForeignKey("CategoryID")]
        public virtual ProductCategory ProductCategorie { get; set; }

        public virtual IEnumerable<OrderDetail> OrderDetails { get; set; }

        public virtual IEnumerable<ProductTag> ProductTags { get; set; }
    }
}