﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TeduShop.Model.Abstract;

namespace TeduShop.Model.Models
{
    [Table("Posts")]
    public class Post : Auditable
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
        public int PostCategoryID { get; set; }

        [MaxLength(500)]
        public string Image { get; set; }
        public string Discription { get; set; }
        public string Content { get; set; }
        public bool? HotFlag { get; set; }
        public int ViewCount { get; set; }

        [ForeignKey("PostCategoryID")]
        public virtual PostCategorie PostCategorie { get; set; }

        public virtual IEnumerable<PostTag> PostTags { get; set; }
    }
}