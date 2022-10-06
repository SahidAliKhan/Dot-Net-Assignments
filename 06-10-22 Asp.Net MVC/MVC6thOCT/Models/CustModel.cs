using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC6thOCT.Models
{
    public class CustModel
    {
        [Required()]
        public int Custid { get; set; }
        [MaxLength(10,ErrorMessage ="Name can't be more than 10")]
        [MinLength(3, ErrorMessage = "Name can't be less than 1")]
        public string Custname { get; set; }
        public string City { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        public DateTime RegistrationDate { get; set; }
    }
}