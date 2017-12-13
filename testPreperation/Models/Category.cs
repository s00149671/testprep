using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace testPreperation.Models
{
    [Table("Category")]

    public class Category
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name ="CategoryID")]

        public int CategoryId { get; set; }
        [Display(Name = "CategoryID")]
        public string CategoryName { get; set; }

        public virtual ICollection<Product> productsInCategory { get; set; }





    }
}