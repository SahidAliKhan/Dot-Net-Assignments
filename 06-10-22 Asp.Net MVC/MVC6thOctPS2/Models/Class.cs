using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC6thOctPS2.Models
{
    public class MemberClass
    {
        public int MemberID { get; set; }
        public string MemberName { get; set; }
    }
    public class BookClass
    {
        public int BookID { get; set; }
        public string BookName { get; set; }
    }
    public class IssueClass
    {
        public int IssueID { get; set; }
        public string IssuedBookName { get; set; }
    }
}