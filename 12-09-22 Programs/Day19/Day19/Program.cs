using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Day19
{
    public class Program
    {
        internal static void WritedataForEachCode(Type type)
        {
            throw new NotImplementedException();
        }

        static void Main(string[] args)
        {
            string path = @"S:\Apps\Dot Net\Day19\ReflectionLibrary\bin\Debug\ReflectionLibrary.dll";
            
            Assembly asm = Assembly.LoadFrom(path);
            Type t = null;
            //  Assembly asm1=Assembly.GetAssembly(typeof(path));
            Type[] types = asm.GetTypes();
            foreach (var item in types)
            {
                Console.WriteLine("Name= " + item.Name);//classname
                Console.WriteLine("Full Name= " + item.FullName);//assemblyname/namespacename and class
                Console.WriteLine("IS Class=" + item.IsClass);
                Console.WriteLine("IS Abstract=" + item.IsAbstract);
                Console.WriteLine("Whether public= " + item.IsPublic);


                Console.WriteLine("-----------------");
                MemberInfo[] minfo = item.GetMembers();

                foreach (var minfoitem in minfo)
                {

                    Console.WriteLine("Member Info Name= " + minfoitem.Name);

                    Console.WriteLine("Declaring type=" + minfoitem.DeclaringType);
                }

                Console.WriteLine("---------------------");
                MethodInfo[] methodInfos = item.GetMethods();
                foreach (var methodInfosItem in methodInfos)
                {

                    Console.WriteLine("Name = " + methodInfosItem.Name);
                    Console.WriteLine("IS PUBLIC= " + methodInfosItem.IsPublic);
                    Console.WriteLine("IS STATIC = " + methodInfosItem.IsStatic);

                    ParameterInfo[] pinfo = methodInfosItem.GetParameters();
                    Console.WriteLine("---Add method Parameters----");

                    //if (methodInfosItem.Name == "add")
                    //{
                        foreach (var par in pinfo)
                        {
                            Console.WriteLine(par.Name);
                            Console.WriteLine(par.Position);
                            Console.WriteLine(par.ParameterType);


                        }
                    //}
                }
                t = asm.GetType(item.FullName);

                object obj = Activator.CreateInstance(t);

                //int ans = (int)item.InvokeMember("add", BindingFlags.Public | BindingFlags.Instance | BindingFlags.InvokeMethod, null, obj, new object[2] { 20, 20 });
                //Console.WriteLine(ans);

                //PropertyInfo ifo=t.GetProperty("empid");
                //ifo.SetValue("empid", 101);
                item.InvokeMember("AcceptData", BindingFlags.Public | BindingFlags.Instance | BindingFlags.InvokeMethod, null, obj, new object[2] { 101, "abc" });

                item.InvokeMember("DisplayData", BindingFlags.Public | BindingFlags.Instance | BindingFlags.InvokeMethod, null, obj, null);

                break;


            }
            Console.ReadLine();
        }
    }
}
