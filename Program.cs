using System;

namespace Day2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name; DateTime bdate; float radius, pi = 3.14f;
            Console.WriteLine("Enter your Name:");
            name = Console.ReadLine();
            Console.WriteLine("Your Name is "+ name);
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Enter your Date of Birth: ");
            bdate = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Your DOB is: " +bdate);
            CalculateAge(bdate);
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Enter a Radius: ");
            radius = Convert.ToSingle(Console.ReadLine());
            double area = pi * radius * radius;
            Console.WriteLine("Area is: " +area);
            Console.WriteLine("-----------------------------------");
            Console.ReadLine();
        }
        static void CalculateAge(DateTime Birthdate)
        {
            int currentDate = DateTime.Now.Year;
            int byear = Birthdate.Year;
            int age = currentDate - byear;
            Console.WriteLine("Your Age as per your Birthdate= " + age);
        }
    }
}
