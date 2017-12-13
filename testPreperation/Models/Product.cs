using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace testPreperation.Models
{
    [Table("Product")]
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display (Name = "ProductID")]
        public int ProductId { get; set; }

        [ForeignKey("associatedCategory")]
        public int CategoryId { get; set; }

        [Display(Name = "ProductID")]
        public string Description { get; set; }

        [Column(TypeName ="date")]
        [Display(Name ="Date of last Order")]
        public DateTime? LastOrderDate { get; set; }

        [Column(TypeName = "date")]
        [Display(Name = "Date of first stocked")]
        public DateTime? FirstStockedOn { get; set; }

        [Display(Name ="Quantity In Stock")]
        public int QuantityInStock { get; set; }

        [Display(Name ="Unit Price")]
        public float UnitPrice { get; set; }

        public virtual Category associatedCategory { get; set;
        }
    }
}