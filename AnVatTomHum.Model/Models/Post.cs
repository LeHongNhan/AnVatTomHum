﻿using AnVatTomHum.Model.Abstracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnVatTomHum.Model.Models
{
    [Table("Posts")]
    public class Post : Auditable
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Column(TypeName = "varchar")]
        [MaxLength(256)]
        [Required]
        public string Alias { get; set; }
        [Required]
        public int CategoryID { get; set; }
        [MaxLength(256)]
        public string Image {  get; set; }
        [MaxLength(500)]
        public string Description { get; set; }  
        public string Content { get; set; }
        public bool? HomeFlag { get; set; }
        public bool? HotFlag { get; set; }
        public int? ViewCount { get; set; }
        [ForeignKey("CategoryID")]
        public virtual PostCategory PostCategory { get; set; }
    }
}
