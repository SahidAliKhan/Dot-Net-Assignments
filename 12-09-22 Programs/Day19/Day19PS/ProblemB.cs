using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
namespace Day19PS
{
    class ProgramB
    {
        static void WritedataForEachCode(Type t)
        {
            Console.WriteLine("Methods " + t.Name);

            System.Attribute[] attrs = System.Attribute.GetCustomAttributes(t);  // Reflection.  

            // Displaying output.  
            foreach (System.Attribute attr in attrs)
            {
                if (attr is StereoDiscAttribute)
                {
                    StereoDiscAttribute a = (StereoDiscAttribute)attr;
                    Console.WriteLine(a.SongName);
                    Console.WriteLine(a.Language);
                    Console.WriteLine(a.Lyrics);
                }
            }
            Console.WriteLine("---------------------------------");
            MemberInfo[] minfo = t.GetMembers();

            foreach (var item in minfo)
            {
                System.Attribute[] attrs1 = System.Attribute.GetCustomAttributes(item);

                foreach (System.Attribute attrItem in attrs1)
                {
                    if (attrItem is StereoDiscAttribute)
                    {
                        StereoDiscAttribute a = (StereoDiscAttribute)attrItem;
                        System.Console.WriteLine(a.SongName);
                        Console.WriteLine(a.Language);
                        Console.WriteLine(a.Lyrics);
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            ProgramB.WritedataForEachCode(typeof(Song));
            Console.Read();
        }
    }
}