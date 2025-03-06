using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnVatTomHum.Model.Models
{
    [Table("PostTags")]
    public class PostTag
    {
        [Key]
        [Column(Order = 0)]
        public int PostID { get; set; }
        [Column(Order = 1)]
        public string TagID { get; set; }
        [ForeignKey("PostID")]
        public virtual Post post { get; set; }  
        [ForeignKey("TagID")]
        public virtual Tag Tag { get; set; }

    }
}
