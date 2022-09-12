using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using Day19;

namespace Day19
{
    class AttributeProgram
    {
        static void WritedataForEachCode(Type t)
        {
            Console.WriteLine("Methods " + t.Name);

            System.Attribute[] attrs = System.Attribute.GetCustomAttributes(t);  // Reflection.  

            // Displaying output.  
            foreach (System.Attribute attr in attrs)
            {
                if (attr is DeveloperAttribute)
                {
                    DeveloperAttribute a = (DeveloperAttribute)attr;
                    Console.WriteLine(a.DeveloperName);
                }
            }
            Console.WriteLine("---------------------------------");
            MemberInfo[] minfo = t.GetMembers();

            foreach (var item in minfo)
            {
                System.Attribute[] attrs1 = System.Attribute.GetCustomAttributes(item);

                foreach (System.Attribute attrItem in attrs1)
                {
                    if (attrItem is DeveloperAttribute)
                    {
                        DeveloperAttribute a = (DeveloperAttribute)attrItem;
                        System.Console.WriteLine(a.DeveloperName);
                    }
                }

            }


        }
        static void Main(string[] args)
        {

            Program.WritedataForEachCode(typeof(Products));
            Console.Read();
        }
    }
}