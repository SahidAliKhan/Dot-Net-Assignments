using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC6thOctPS.Models
{
    public class ProductModel
    {
        [Required()]
        public int Prodid { get; set; }
        [MaxLength(20, ErrorMessage = "Name should be less than 20")]
        [MinLength(3, ErrorMessage = "Name should be more than 3")]
        public string ProdName { get; set; }
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        public DateTime MfgDate { get; set; }
    }
}