using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Day8
{
    internal class PS3
    {

        static void Main(string[] args)
        {
            string path = @"S:\Apps\Dot Net\Day8\";

            Directory.CreateDirectory(path + "MyDir");
            Console.WriteLine("MyDir directory got created...");

            Console.WriteLine("-------------------");
            string path2 = @"S:\Apps\Dot Net\Day8\MyDir\";
            Directory.CreateDirectory(path2 + "Results17-18");
            Directory.CreateDirectory(path2 + "Results18-19");
            Directory.CreateDirectory(path2 + "Results20-21");
            Console.WriteLine("3 Sub directory in MyDir got created...");

            Console.WriteLine("-------------------");
            string path3 = @"S:\Apps\Dot Net\Day8\MyDir\Results17-18\";
            File.Create(path3 + "File1.txt");
            File.Create(path3 + "File2.txt");
            Console.WriteLine("2 Files got created in Results17-18 directory...");
            string path4 = @"S:\Apps\Dot Net\Day8\MyDir\Results18-19\";
            File.Create(path4 + "File1.txt");
            File.Create(path4 + "File2.txt");
            Console.WriteLine("2 Files got created in Results18-19 directory...");
            string path5 = @"S:\Apps\Dot Net\Day8\MyDir\Results20-21\";
            File.Create(path5 + "File1.txt");
            File.Create(path5 + "File2.txt");
            Console.WriteLine("2 Files got created in Results20-21 directory...");

            Console.WriteLine("-------------------");
            Directory.CreateDirectory(path3 + "Jan");
            Directory.CreateDirectory(path3 + "Feb");
            Directory.CreateDirectory(path3 + "Mar");
            Directory.CreateDirectory(path3 + "Apr");
            Directory.CreateDirectory(path3 + "May");
            Directory.CreateDirectory(path3 + "Jun");
            Directory.CreateDirectory(path3 + "Jul");
            Directory.CreateDirectory(path3 + "Aug");
            Directory.CreateDirectory(path3 + "Sep");
            Directory.CreateDirectory(path3 + "Oct");
            Directory.CreateDirectory(path3 + "Nov");
            Directory.CreateDirectory(path3 + "Dec");
            Console.WriteLine("MonthWise Folder created in Results17-18 directory....");

            Directory.CreateDirectory(path4 + "Jan");
            Directory.CreateDirectory(path4 + "Feb");
            Directory.CreateDirectory(path4 + "Mar");
            Directory.CreateDirectory(path4 + "Apr");
            Directory.CreateDirectory(path4 + "May");
            Directory.CreateDirectory(path4 + "Jun");
            Directory.CreateDirectory(path4 + "Jul");
            Directory.CreateDirectory(path4 + "Aug");
            Directory.CreateDirectory(path4 + "Sep");
            Directory.CreateDirectory(path4 + "Oct");
            Directory.CreateDirectory(path4 + "Nov");
            Directory.CreateDirectory(path4 + "Dec");
            Console.WriteLine("MonthWise Folder created in Results18-19 directory....");

            Directory.CreateDirectory(path5 + "Jan");
            Directory.CreateDirectory(path5 + "Feb");
            Directory.CreateDirectory(path5 + "Mar");
            Directory.CreateDirectory(path5 + "Apr");
            Directory.CreateDirectory(path5 + "May");
            Directory.CreateDirectory(path5 + "Jun");
            Directory.CreateDirectory(path5 + "Jul");
            Directory.CreateDirectory(path5 + "Aug");
            Directory.CreateDirectory(path5 + "Sep");
            Directory.CreateDirectory(path5 + "Oct");
            Directory.CreateDirectory(path5 + "Nov");
            Directory.CreateDirectory(path5 + "Dec");
            Console.WriteLine("MonthWise Folder created in Results20-21 directory....");

            Console.WriteLine("-------------------");
            Console.WriteLine("Enumerate of MyDir Directory:");
            var dir2 = from Dir in Directory.EnumerateDirectories(path2) select Dir;
            Console.WriteLine("Subdirectories: {0}", dir2.Count<string>().ToString());
            Console.WriteLine("List of Subdirectories");
            foreach (var dir in dir2)
            {
                Console.WriteLine("{0}", dir.Substring(dir.LastIndexOf("\\") + 1));
            }

            Console.WriteLine("-------------------");
            Console.WriteLine("Enumerate of Results17-18 Directory:");
            var dir3 = from MyDir in Directory.EnumerateDirectories(path3) select MyDir;
            Console.WriteLine("Subdirectories: {0}", dir3.Count<string>().ToString());
            Console.WriteLine("List of Subdirectories");
            foreach (var dir in dir3)
            {
                Console.WriteLine("{0}", dir.Substring(dir.LastIndexOf("\\") + 1));
            }

            Console.WriteLine("-------------------");
            Console.WriteLine("Enumerate of Results18-19 Directory:");
            var dir4 = from MyDir in Directory.EnumerateDirectories(path4) select MyDir;
            Console.WriteLine("Subdirectories: {0}", dir4.Count<string>().ToString());
            Console.WriteLine("List of Subdirectories");
            foreach (var dir in dir4)
            {
                Console.WriteLine("{0}", dir.Substring(dir.LastIndexOf("\\") + 1));
            }

            Console.WriteLine("-------------------");
            Console.WriteLine("Enumerate of Results20-21 Directory:");
            var dir5 = from MyDir in Directory.EnumerateDirectories(path5) select MyDir;
            Console.WriteLine("Subdirectories: {0}", dir5.Count<string>().ToString());
            Console.WriteLine("List of Subdirectories");
            foreach (var dir in dir5)
            {
                Console.WriteLine("{0}", dir.Substring(dir.LastIndexOf("\\") + 1));
            }
            Console.ReadLine();
        }
    }
}
