using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.IO;

namespace Day19PS
{
    public class ProblemA
    {
        static void Main(string[] args)
        {
            string path = @"S:\Apps\Dot Net\Day19PS\Day19PSLibrary\bin\Debug\Day19PSLibrary.dll";
            Assembly asm1 = Assembly.LoadFrom(path);
            Type[] types = asm1.GetTypes();
            Type t = null;
            foreach (var i in types)
            {
                Console.WriteLine("Name: " + i.Name);
                Console.WriteLine("Full Name: " + i.FullName);
                Console.WriteLine("Is Class?: " + i.IsClass);
                Console.WriteLine("Is ValueType?: " + i.IsValueType);
                Console.WriteLine("Is Array?: " + i.IsArray);
                Console.WriteLine("Is Enum?: " + i.IsEnum);
                Console.WriteLine("Is Generic Type?: " + i.IsGenericType);
                Console.WriteLine("---------------");
                MemberInfo[] min = i.GetMembers();
                foreach (var m in min)
                {
                    Console.WriteLine("Member Info Name: " + m.Name);
                    Console.WriteLine("Declaring type: " + m.DeclaringType);
                }
                MethodInfo[] method = i.GetMethods();
                foreach (var methodI in method)
                {

                    Console.WriteLine("Method Name: " + methodI.Name);
                    Console.WriteLine("Is Method Public?: " + methodI.IsPublic);
                    Console.WriteLine("Is Method Static?: " + methodI.IsStatic);

                    ParameterInfo[] pinfo = methodI.GetParameters();
                    foreach (var p in pinfo)
                    {
                        Console.WriteLine("Parameter Name: " + p.Name);
                        Console.WriteLine("Parameter Position: " + p.Position);
                        Console.WriteLine("Parameter Type: " + p.ParameterType);
                    }
                }

                t = asm1.GetType(i.FullName);
                object obj = Activator.CreateInstance(t);
                double ans1 = (double)i.InvokeMember("Cube", BindingFlags.Public | BindingFlags.Instance | BindingFlags.InvokeMethod, null, obj, new object[1] { 8.0d });
                Console.WriteLine("Cube of 8: " +ans1);
                double ans2 = (double)i.InvokeMember("Sqrt", BindingFlags.Public | BindingFlags.Instance | BindingFlags.InvokeMethod, null, obj, new object[1] { 8.0d });
                Console.WriteLine("Square Root of 8: " + ans2);
            }

            Console.ReadLine();
        }
    }
}
