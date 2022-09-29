using Bank_DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNetDay5_CodeFirst_PS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyContext context = new MyContext();
            context.Borrowers.Add(new Borrower { BorrowerID = 1, BorrowerName = "Zaid Khan", Street = "HN-02",City ="Pune", State = "Maharastra", Country = "India", JobName = "SDE", CompanyName = "Mphasis" });

            context.Loans.Add(new Loan { LoanID = 10203, LoanType = "Home Loan", Amount = 150000, Duration = 12, RateOfInterest = 12 });

            context.SaveChanges();
            Console.WriteLine("Inserted Succesfully..");
            Console.ReadLine();
        }
    }
}
