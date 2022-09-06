using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day15
{
    public class ATMdemo
    {
        static int AvailableBalace = 10000;
        internal AccountTypes TypeOfAccount { get; set; }

        public void ShowMenu()
        {
            Console.WriteLine("Enter account type \n1 for savings \n2 for current  \n3 for fixed");
            //AccountTypes choice =(AccountTypes) Convert.ToInt32(Console.ReadLine());
            TypeOfAccount = (AccountTypes)Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("U selected account type= " + TypeOfAccount);
            MakeTransaction();

        }
        private void MakeTransaction()
        {
            Console.WriteLine("Press 1 to withdraw and 2 to deposit 3 for exit");
            int c = Convert.ToInt32(Console.ReadLine());
            if (c == 1)
            {
                Console.WriteLine("Enter the amt to withdraw");
                int amt = Convert.ToInt32(Console.ReadLine());
                bool status = Withdraw(amt);
                if (status)
                {
                    Console.WriteLine("Thanks for using atm");
                }
                else
                {
                    Console.WriteLine("Some problem occured....");
                }
            }
        }
        public bool Withdraw(int amt)
        {
            bool status = false;
            if (amt <= AvailableBalace)
            {
                AvailableBalace = AvailableBalace - amt;
                status = true;
            }
            Console.WriteLine("After withdraw available bal=" + AvailableBalace);

            return status;
        }
    }
    internal enum AccountTypes
    {
        Savings = 1,
        Current = 2,
        Fixed = 3
    }
}
