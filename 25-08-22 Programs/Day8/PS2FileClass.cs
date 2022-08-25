using System;
using System.IO;

namespace Day8
{
    class PS2FileClass
    {
        static void Main(string[] args)
        {
            //Problem2
            string path = @"S:\Apps\Dot Net\Day8\";
            string path2 = @"S:\Apps\Dot Net\Day8\PathForCopyFile";
            Console.WriteLine("Enter the file name");
            string fname = Console.ReadLine();
            Console.WriteLine("Enter your file contents: ");
            string con = Console.ReadLine();
            File.WriteAllText(path + fname, con);
            Console.WriteLine("File created successfully with contents...");

            Console.WriteLine("Enter your Copy FiLe name: ");
            string cop = Console.ReadLine();
            File.Copy(path + fname, path + cop);
            Console.WriteLine("File Copied to a same folder with different filename successfully...");
           
            File.Copy(path + fname, path2 + cop);
            Console.WriteLine("Also file got Copied to a different folder with different filename successfully...");
            
            File.Move(path + fname, path2 + "MovedFile.txt");
            Console.WriteLine("Moved {0} file to a different folder successfully..." ,fname);
            
            Console.WriteLine("Now Create a new file to delete. Enter file name:");
            string dname = Console.ReadLine();
            File.Create(path + dname);
            File.Delete(dname);
            Console.WriteLine("{0} file got deleted.",dname);

            FileInfo fileInfo = new FileInfo(fname);  
            Console.WriteLine("{0} Extension: {1}" ,fname, fileInfo.Extension);
            Console.WriteLine("{0} Creation Time: {1}", fname , fileInfo.CreationTime);
            Console.WriteLine("{0} Directory: {1}", fname, fileInfo.Directory);


            Console.ReadLine();
        }
    }
}
