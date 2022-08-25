using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Day8
{
    internal class PS4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Drives Info:");
            DriveInfo[] dinfo = DriveInfo.GetDrives();
            foreach (var item in dinfo)
            {
                Console.WriteLine("Drive Name: " + item.Name);
                Console.WriteLine("Drive Size: " + item.TotalSize);
                Console.WriteLine("Drive Type: " + item.DriveType);
                Console.WriteLine("Drive Format: " + item.DriveFormat);
                Console.WriteLine("Drive VolumeLabel: "+ item.VolumeLabel);
                Console.WriteLine("Drive IsReady?: " + item.IsReady);
                Console.WriteLine("----------------------------");
            }
            Console.ReadLine();
        }
    }
}
