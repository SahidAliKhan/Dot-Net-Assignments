using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Library1
{
    public interface IBank
    {
        void PrintBalance();
        void CalculateInterest();
    }
    public class Bank: IBank
    {
        static int amt = 10000;
        private int _deposit;
        public int Deposit
        {
            get { return _deposit; }
            set { _deposit = value; }
        }
        private int _withdraw;
        public int Withdraw
        {
            get { return _withdraw; }
            set
            {
                if (Total() < 10000)
                {
                    Withdraw = 0;
                }
                {
                    Withdraw = value;
                }
            }
        }
        public int Total()
        {
            int total;
            total = Deposit + amt - Withdraw;
            return total;
        }
        private DateTime _date;

        public DateTime Date
        {
            get { return _date; }
            set { _date = value; }
        }
        public void NoOfDays()
        {
            TimeSpan t = DateTime.Now - Date;
            Console.WriteLine("No of Days: " + t.TotalDays);
        }
        public void CalculateInterest()
        {
            int s = Total();
            Console.WriteLine("Enter Interest Rate: ");
            int m = Convert.ToInt32(Console.ReadLine());
            float i = (s * m) / 100;
            Console.WriteLine("Interest rate per year is:  " +i);
        }
        public void PrintBalance()
        {
            int n = Total();
            Console.WriteLine("Yotal Total Balance: " +n);
        }
    }
    public class Savings: Bank, IBank
    {
        public void CalculateInterest()
        {
            int m = base.Total();
            float i = (4 * m) / 100;
            Console.WriteLine("Saving Interest rate per year is:  " + i);
        }
        public void PrintBalance()
        {
            int m = base.Total();
            float i = (4 * m) / 100;
            float a = m + i;
            Console.WriteLine("Savings Amount is:  " + a);
        }
    }
    public class Current : Bank, IBank
    {
        public void CalculateInterest()
        {
            int m = base.Total();
            float i = (2 * m) / 100;
            Console.WriteLine("Current Interest rate per year is:  " + i);
        }
        public void PrintBalance()
        {
            int m = base.Total();
            float i = (2 * m) / 100;
            float a = m + i;
            Console.WriteLine("Current Amount is:  " + a);
        }
    }
    public static class extension
    {
        public static int deposit(this int i)
        {
            return i;
        }
        public static int withdraw(this int i)
        {
            return i;
        }
    }
}
