﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeduShop.Model.Models
{
    [Table("Tags")]
    public class Tag
    {
        [Key]
        [MaxLength(50)]
        [Column(TypeName ="varchar")]
        public string ID { get; set; }

        [MaxLength(100)]
        public string Name { get; set; }
        [MaxLength(100)]
        [Column(TypeName ="varchar")]
        public string Type { get; set; }

        public virtual IEnumerable<PostTag> PostTags { get; set; }
        public virtual IEnumerable<ProductTag> ProductTag { get; set; }
    }
}