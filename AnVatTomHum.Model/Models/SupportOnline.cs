using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Migrations.Builders;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnVatTomHum.Model.Models
{
    [Table("SupportOnlines")]
    public class SupportOnline
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [Required]
        [Column(TypeName = "varchar")]
        [MaxLength(10)]
        public string Department { get; set; }
        [MaxLength(250)]
        public string Skype { get; set; }
        [MaxLength(250)]
        public string Facebook { get; set; }
        [MaxLength(250)]
        public string Email { get; set; }
        [MaxLength(10)]
        public string Status { get; set; }
    }
}
