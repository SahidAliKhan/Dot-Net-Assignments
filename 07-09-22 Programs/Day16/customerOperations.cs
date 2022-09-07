using DelegateLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day16
{
    public delegate void HandleInsertUpdateCustomer(Customer c);
    class customerOperations : EventArgs
    {
        public static event HandleInsertUpdateCustomer InsertEvent;

        public static event HandleInsertUpdateCustomer UpdateEvent;
        //Event takes a parameter Customer object
        public static List<Customer> list = new List<Customer>();

        static void Main(string[] args)
        {
            InsertEvent += CustomerOperations_InsertEvent;
            UpdateEvent += CustomerOperations_UpdateEvent;
            Console.WriteLine("Menu 1 for Insert 2 for Update");
            int ch = Convert.ToInt32(Console.ReadLine());
            Customer c = new Customer();
            switch (ch)
            {
                case 1:

                    Console.WriteLine("Enter custid");
                    c.custid = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter custname");
                    c.custname = Console.ReadLine();
                    Console.WriteLine("Enter phone no");
                    c.phoneno = Convert.ToInt32(Console.ReadLine());
                    InsertEvent(c);
                    break;
                case 2:

                    Console.WriteLine("Enter custid");
                    c.custid = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter custname");
                    c.custname = Console.ReadLine();
                    Console.WriteLine("Enter phone no");
                    c.phoneno = Convert.ToInt32(Console.ReadLine());
                    UpdateEvent(c);
                    break;
                default:
                    Environment.Exit(1);
                    break;
            }


            Console.Read();
        }

        private void InsertMethod(Customer c)
        {
            list.Add(c);
            Console.WriteLine("Added successfully");
            foreach (var item in list)
            {
                Console.WriteLine(item.custid);
                Console.WriteLine(item.custname);
                Console.WriteLine(item.phoneno);
            }
        }
        private void UpdateMethod(Customer c)
        {
            list.Remove(c);
            list.Add(c);
            //Customer found = list.Find(x => x.custid == c.custid);
            //found.custname = c.custname;
            //found.phoneno = c.phoneno;
            Console.WriteLine("Updated successfully");
        }



        private static void CustomerOperations_UpdateEvent(Customer c)
        {
            //throw new NotImplementedException();
            customerOperations operations = new customerOperations();
            HandleInsertUpdateCustomer del = new HandleInsertUpdateCustomer(operations.UpdateMethod);
            del.Invoke(c);


        }

        private static void CustomerOperations_InsertEvent(Customer c)
        {
            customerOperations operations = new customerOperations();
            HandleInsertUpdateCustomer del = new HandleInsertUpdateCustomer(operations.InsertMethod);
            del.Invoke(c);

        }
    }
}
