using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CodeFirst13thOct.Models
{
    public class Dept
    {
        [Required()]
        public int deptno
        {
            get;
            set;
        }
        [MaxLength(50, ErrorMessage = "can't be more than 50")]
        public string deptname
        {
            get;
            set;
        }
        [MaxLength(50, ErrorMessage = "can't be more than 50")]
        public string location
        {
            get; set;
        }
    }
}