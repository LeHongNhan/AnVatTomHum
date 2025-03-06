using AnVatTomHum.Model.Abstracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AnVatTomHum.Model.Models
{
    [Table("Products")]
    public class Product : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [Column(TypeName = "varchar")]
        [MaxLength(256)]
        public string Alias { get; set; }
        [Required]
        public int CategoryID { get; set; }
        [MaxLength(256)]
        public string Image { get; set; }
        [Column(TypeName ="xml")]
        public string MoreImage { get; set; }
        
        public Decimal Price { get; set; }

        public Decimal? PromotionPrice { get; set; } 
        public string Description { get; set; }
        public string Content { get; set; }
        public bool? HomeFlag { get; set; }
        public bool? HotFlag { get; set; }
        public int ViewCount {  get; set; }
        [ForeignKey("CategoryID")]
        public virtual ProductCategory ProductCategory { get; set; }
        public virtual IEnumerable<OrderDetail> OrderDetails { get; set; }

    }
}
