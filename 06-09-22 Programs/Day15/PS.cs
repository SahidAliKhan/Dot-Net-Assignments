using Library1;
using System;

namespace Day15
{
    public class PS
    {
        static void Main(string[] args)
        {
           Employee employee = new Employee();
            employee.workplace();
            employee.Work();
           Manager manager = new Manager();
            manager.Work();
           Clerk clerk = new Clerk();
            clerk.Work();

            Console.WriteLine("---------------------");

            Bank b = new Bank();
            Console.WriteLine("Enter deposit year, month, date: ");
            int y = Convert.ToInt32(Console.ReadLine());
            int m = Convert.ToInt32(Console.ReadLine());
            int d = Convert.ToInt32(Console.ReadLine());
            DateTime n = new DateTime(y, m, d);
            b.Date = n;
            b.NoOfDays();

            Console.WriteLine("Enter Deposit Amount: ");
            b.Deposit = Convert.ToInt32(Console.ReadLine());
            b.PrintBalance();
            b.CalculateInterest();

            Console.WriteLine("Enter Withdrawl Amount: ");
            b.Withdraw = Convert.ToInt32(Console.ReadLine());
            b.PrintBalance();
            b.CalculateInterest();

            Savings s = new Savings();
            Console.WriteLine("Enter Savings Deosit Amount: ");
            int q = Convert.ToInt32(Console.ReadLine());
            s.Deposit = q.deposit();
            Console.WriteLine("Withdrawl amount from savings acc:");
            int q1 = Convert.ToInt32(Console.ReadLine());
            s.Withdraw = q1.withdraw();
            s.CalculateInterest();
            s.PrintBalance();

            Current c = new Current();
            Console.WriteLine("Enter Current Amount:");
            int c1 = Convert.ToInt32(Console.ReadLine());
            c.Deposit = c1.deposit();
            Console.WriteLine("Enter Withdrawl Amount:");
            int c2 = Convert.ToInt32(Console.ReadLine());
            c.Withdraw = c2.withdraw();
            c.CalculateInterest();
            c.PrintBalance();

            Console.ReadLine();
        }
    }
}
