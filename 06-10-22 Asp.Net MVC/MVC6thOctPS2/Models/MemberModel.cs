using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC6thOctPS2.Models
{
    public class MemberModel
    {
        [Required()]
        public int Memberid { get; set; }
        [MaxLength(10, ErrorMessage = "Name cannot be greater than 10 characters")]
        [MinLength(3, ErrorMessage = "Name cannot be less than 3 character")]
        public string MemberName { get; set; }
    }
}