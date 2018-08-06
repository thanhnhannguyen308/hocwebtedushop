using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeduShop.Model.Models
{
    [Table("ProductTags")]
    public class ProductTag
    {
        [Key]
        [Column(Order = 1)]
        public int ProductTags { get; set; }


        [Key]
        [Column(TypeName ="varchar", Order = 2)]
        [MaxLength(50)]
        public string TagID { get; set; }

        [ForeignKey("TagID")]
        public virtual Tag Tag { get; set; }

        [ForeignKey("ProductTags")]
        public virtual Product Products { get; set; }
    }
}