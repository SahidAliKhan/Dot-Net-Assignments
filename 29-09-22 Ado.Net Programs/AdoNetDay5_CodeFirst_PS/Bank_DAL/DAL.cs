using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_DAL
{
    public class Borrower
    {
        [Key]
        public int BorrowerID { get; set; }
        public string BorrowerName { get; set; }
        public string Street { get; set; }
        public string City{ get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string CompanyName { get; set; }
        public string JobName { get; set; }
    }


    public class Loan
    {
        [Key]
        public int LoanID { get; set; }
        public string LoanType { get; set; }
        [Range(100000,200000,ErrorMessage ="Loan Amount is Invalid")]
        public int Amount { get; set; }
        public int Duration { get; set; }
        public int RateOfInterest { get; set; }
    }

    public class MyContext: DbContext
    {
        public MyContext():base("MyContext")
        {
            Database.SetInitializer<MyContext>(new CreateDatabaseIfNotExists<MyContext>());
        }
        public virtual DbSet<Borrower> Borrowers { get; set; }
        public virtual DbSet<Loan> Loans { get; set; }

    }


}
