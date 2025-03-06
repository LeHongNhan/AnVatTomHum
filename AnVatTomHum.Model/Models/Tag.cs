using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnVatTomHum.Model.Models
{
    [Table("Tags")]
    public class Tag
    {
        [Key]
        [Column(TypeName = "varchar")]
        [MaxLength(50)]
        public string Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
    }
}
