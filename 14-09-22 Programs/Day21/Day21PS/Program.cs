using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;
using Day21Library;

namespace Day21PS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerUser s1 = new CustomerUser();
            s1.Id = 7809731494;
            s1.Password = "7809731494@pass";
            s1.validate();
            CustomerUser s2 = new CustomerUser();
            s2.Id = 7809731494;
            s2.Password = "7809731494@pass";
            s2.validate();
            FileStream fs = new FileStream(@"empty.bin", FileMode.Create, FileAccess.Write);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, s1);
            bf.Serialize(fs, s2);
            fs.Flush();
            fs.Close();
            fs.Dispose();
            FileStream fs1 = new FileStream(@"empty.bin", FileMode.Open, FileAccess.Read);
            BinaryFormatter bf1 = new BinaryFormatter();
            CustomerUser[] s = new CustomerUser[2];
            for (int i = 0; i < 2; i++)
            {

                s[i] = (CustomerUser)bf1.Deserialize(fs1);
            }
            foreach (var item in s)
            {
                Console.WriteLine(item.Id);
                Console.WriteLine(item.Password);
                Console.WriteLine(item.login);
                Console.WriteLine(item.date);
            }

            fs1.Flush();
            fs1.Close();
            fs1.Dispose();
            Searching si1 = new Searching();
            si1.initiate();
            si1.DisplayMovies();
            si1.search();
            FileStream fs2 = new FileStream(@"empty1.bin", FileMode.Create, FileAccess.Write);
            BinaryFormatter write = new BinaryFormatter();
            write.Serialize(fs2, si1);
            fs2.Flush();
            fs2.Close();
            fs2.Dispose();
            FileStream fs3 = new FileStream(@"empty1.bin", FileMode.Open, FileAccess.Read);
            BinaryFormatter read = new BinaryFormatter();
            Searching si2 = new Searching();
            si2 = (Searching)read.Deserialize(fs3);
            foreach (var item in si2.Search)
            {
                Console.WriteLine($"{item.mname} {item.mlanguage} {item.mgenre} {item.mstock}");
            }
            fs3.Flush();
            fs3.Close();
            fs3.Dispose();


            Console.WriteLine("Add watchlist");
            Watch e1 = new Watch();
        mer:

            Console.WriteLine("enter name of movie");
            e1.Addtowatchlist();
            Console.WriteLine("Enter yes to continue");
            string d = Console.ReadLine();
            if (d == "yes")
            {
                goto mer;
            }
            foreach (var item in e1.watchlist)
            {

                Console.WriteLine($"{item.Item1.mname} {item.Item1.mlanguage} {item.Item1.mgenre} {item.Item1.mstock} {item.Item2}");
            }
            string s11 = JsonConvert.SerializeObject(e1);
            FileStream fs7 = new FileStream(@"empty3.json", FileMode.Create, FileAccess.Write);
            StreamWriter w1 = new StreamWriter(fs7);
            w1.Write(s11);
            w1.Close();
            w1.Dispose();
            fs7.Close();
            fs7.Dispose();
            FileStream fs8 = new FileStream(@"empty3.json", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs8);
            string s12 = sr.ReadToEnd();

            Watch s22 = JsonConvert.DeserializeObject<Watch>(s12);
            foreach (var item in s22.watchlist)
            {

                Console.WriteLine($"{item.Item1.mname} {item.Item1.mlanguage} {item.Item1.mgenre} {item.Item1.mstock} {item.Item2}");
            }
            Console.WriteLine("Already seen movie");
            e1.releaselist();
            List<Movie> dgg = new List<Movie>();
            foreach (var item in e1.release)
            {
                dgg.Add(item.Item1);
            }
            s1.alreadyseen = dgg;
            FileStream fs4 = new FileStream(@"empty2.Xml", FileMode.Create, FileAccess.Write);
            System.Xml.Serialization.XmlSerializer xm = new System.Xml.Serialization.XmlSerializer(typeof(CustomerUser));
            xm.Serialize(fs4, s1);
            fs4.Flush();
            fs4.Close();
            fs4.Dispose();
            FileStream fs5 = new FileStream(@"empty2.Xml", FileMode.Open, FileAccess.Read);
            System.Xml.Serialization.XmlSerializer ms = new System.Xml.Serialization.XmlSerializer(typeof(CustomerUser));
            var t = (CustomerUser)ms.Deserialize(fs5);
            Console.WriteLine("Already seen movies");
            foreach (var item in t.alreadyseen)
            {
                Console.WriteLine($"{item.mname} {item.mlanguage} {item.mgenre} {item.mstock}");
            }
            fs5.Flush();
            fs5.Close();
            fs5.Dispose();
            Console.WriteLine("Cost of which movie you want to know");
            string id = Console.ReadLine();
            e1.totalcostassociated(id);
            FileStream fs9 = new FileStream(@"empty4.bin", FileMode.Create, FileAccess.Write);
            BinaryFormatter write1 = new BinaryFormatter();
            write1.Serialize(fs9, e1);
            fs9.Flush();
            fs9.Close();
            fs9.Dispose();
            FileStream fs81 = new FileStream(@"empty4.bin", FileMode.Open, FileAccess.Read);
            BinaryFormatter read1 = new BinaryFormatter();

            var sii2 = (Watch)read.Deserialize(fs81);
            foreach (var item in sii2.total)
            {
                Console.WriteLine($"{item.Item1} {item.Item2} {item.Item3}");
            }
            fs81.Flush();
            fs81.Close();
            fs81.Dispose();
        }
    }
}
