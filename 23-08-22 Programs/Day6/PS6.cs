using System;


namespace Day6
{
    internal class PS6
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Department Name: ");
            string dname = Console.ReadLine();
            if (dname == "Purchase")
            {
                int p = (int)deptnames.Purchase;
                Console.WriteLine("Department Number: " + p);
            }
            else if (dname == "Sales")
            {
                int p = (int)deptnames.Sales;
                Console.WriteLine("Department Number: " + p);
            }
            else if (dname == "Training")
            {
                int p = (int)deptnames.Training;
                Console.WriteLine("Department Number: " + p);
            }
            else if (dname == "Accounts")
            {
                int p = (int)deptnames.Accounts;
                Console.WriteLine("Department Number: " + p);
            }
            else
                Console.WriteLine("Invalid input.");
            Console.ReadLine();
        }
        enum deptnames
        {
            Purchase = 1,
            Sales = 2,
            Training = 3,
            Accounts = 4
        }
    }
}
