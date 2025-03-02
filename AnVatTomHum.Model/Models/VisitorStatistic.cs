using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnVatTomHum.Model.Models
{
    public class VisitorStatistic
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public DateTime VisitedDate { get; set; }
        [Required]
        [Column(TypeName ="Varchar")]
        [MaxLength(50)]
        public string IPAdress { get; set; }
    }
}
