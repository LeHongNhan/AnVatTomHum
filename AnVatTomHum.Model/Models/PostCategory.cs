using AnVatTomHum.Model.Abstracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnVatTomHum.Model.Models
{
    [Table("PostCategories")]
    public class PostCategory : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required]
        [MaxLength(256)]
        public string name { get; set; }
        [Required]
        [Column(TypeName = "varchar")]
        [MaxLength(256)]

        public string Alias { get; set; }
        public string Description { get; set; }
        public int? ParentID {  get; set; }
        public int? DisplayOrder { get; set; }
        [MaxLength(256)]
        public string image { get; set; }
        public bool? HomeFlag { get; set; }
        public virtual IEnumerable<Post> Posts { get; set; }
    }
}
