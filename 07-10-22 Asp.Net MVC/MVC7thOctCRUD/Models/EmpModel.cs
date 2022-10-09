using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC7thOctCRUD.Models
{
    public class EmpModel
    {
        [Required()]
        public int EmployeeID { get; set; }

        [MaxLength(10, ErrorMessage = "First Name should be less than 10 chars.")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Name cannot be kept blank")]
        public string FirstName { get; set; }

        [MaxLength(10, ErrorMessage = "Last Name should be less than 10 chars.")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Name cannot be kept blank")]
        public string LastName { get; set; }

        [MaxLength(20, ErrorMessage = "Title should be less than 20 chars.")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Title cannot be kept blank")]
        public string Title { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }
    }  
}