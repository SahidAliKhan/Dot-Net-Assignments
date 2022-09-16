using System;
using System.Text;
using HRLibarayS;
using System.IO;
using System.Xml.Serialization;
using System.Web.Script.Serialization;
using Newtonsoft.Json;
using System.Runtime.Serialization.Formatters.Soap;
using System.Runtime.Serialization.Formatters.Binary;

namespace Day21
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("1. Binary 2. XML 3. SOAP 4. JSon 5.Exit");
            int ch = Convert.ToInt32(Console.ReadLine());
            switch (ch)
            {

                case 1:
                    // binarySerialization();
                       binaryDeSerialization();
                       break;

                case 2:
                    // xmlSerialize();
                    xmlDeSerialize();
                    break;
                case 3:
                    SoapSerialize();
                    SoapDeSerialize();
                    break;
                case 4:
                    // JsonSerialization();
                    //JsonDeSerialization();

                    //JsonSerializationarray();
                    JsonDeSerializationarray();

                    //using  JsonConvert
                    //  Employee emp4 = new Employee();
                    //  emp4.Empid = 102;
                    //  emp4.Empname = "Seema";
                    //  emp4.Salary = 10000;
                    //  emp4.Password = "myPassSeema";
                    //  emp4.CalculateSalary();
                    //  string s1 = JsonConvert.SerializeObject(emp4);
                    //  FileStream fs1 = new FileStream("empjsonSec.json", FileMode.Create, FileAccess.Write);
                    //  StreamWriter sw1 = new StreamWriter(fs1);
                    //  sw1.Write(s1);

                    //  fs1.Flush();
                    //  sw1.Close();
                    //  fs1.Close();

                    //Employee empreadData  =JsonConvert.DeserializeObject<Employee>(s1);
                    //  Console.WriteLine(empreadData.Empid);
                    //  Console.WriteLine(empreadData.Empname);
                    //  Console.WriteLine(empreadData.Salary);
                    //  Console.WriteLine(empreadData.Password);
                    //  Console.WriteLine(empreadData.GrossSal);

                    break;
                case 5:
                    Environment.Exit(1);
                    break;
            }
            Console.Read();
        }

        private static void SoapDeSerialize()
        {
            FileStream fs5 = new FileStream("empdataSoap.soap", FileMode.Open, FileAccess.Read);
            SoapFormatter soapFormatter = new SoapFormatter();
            Employee employee = (Employee)soapFormatter.Deserialize(fs5);
            Console.WriteLine(employee.Empid);
            Console.WriteLine(employee.Empname);
            Console.WriteLine(employee.Salary);
            Console.WriteLine(employee.Password);
            Console.WriteLine(employee.GrossSal);
            fs5.Flush();
            fs5.Close();
            fs5.Dispose();
        }

        private static void xmlDeSerialize()
        {
            FileStream fs_xml1 = new FileStream(@"empxmldata.xml", FileMode.Open, FileAccess.Read);
            XmlSerializer xmlread = new XmlSerializer(typeof(Employee));
            Employee empda = (Employee)xmlread.Deserialize(fs_xml1);
            Console.WriteLine(empda.Empid);
            Console.WriteLine(empda.Empname);
            Console.WriteLine(empda.Password);
            Console.WriteLine(empda.Salary);
            Console.WriteLine(empda.GrossSal);
            fs_xml1.Flush();
            fs_xml1.Close();
            fs_xml1.Dispose();
        }

        private static void SoapSerialize()
        {
            Employee emp5 = new Employee();
            emp5.Empid = 102;
            emp5.Empname = "Seema";
            emp5.Salary = 10000;
            emp5.Password = "myPassSeema";
            emp5.CalculateSalary();

            FileStream fs2 = new FileStream("empdataSoap.soap", FileMode.Create, FileAccess.Write);

            SoapFormatter soap = new SoapFormatter();
            soap.Serialize(fs2, emp5);
            fs2.Flush();
            fs2.Close();
            fs2.Dispose();
        }

        private static void JsonDeSerialization()
        {
            FileStream fs = new FileStream("empjson.json", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string s1 = sr.ReadToEnd();


            JavaScriptSerializer js = new JavaScriptSerializer();

            Employee ejso = js.Deserialize<Employee>(s1);
            Console.WriteLine(ejso.Empid);
            Console.WriteLine(ejso.Empname);
            Console.WriteLine(ejso.Salary);
            Console.WriteLine(ejso.Password);
            Console.WriteLine(ejso.GrossSal);
        }

        private static void JsonDeSerializationarray()
        {
            FileStream fs = new FileStream("empjsonarr.json", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string s1 = sr.ReadToEnd();

            Employee[] eda = JsonConvert.DeserializeObject<Employee[]>(s1);

            foreach (var item in eda)
            {
                Console.WriteLine(item.Empid);
                Console.WriteLine(item.Empname);
                Console.WriteLine(item.Salary);
                Console.WriteLine(item.GrossSal);
                Console.WriteLine(item.Password);
            }
        }
        private static void JsonSerializationarray()
        {
            Employee[] arr = new Employee[2];
            arr[0] = new Employee();
            arr[0].Empid = 102;
            arr[0].Empname = "Seema";
            arr[0].Salary = 10000;
            arr[0].Password = "myPassSeema";
            arr[0].CalculateSalary();

            arr[1] = new Employee();
            arr[1].Empid = 103;
            arr[1].Empname = "Arya";
            arr[1].Salary = 20000;
            arr[1].Password = "myPassArya";
            arr[1].CalculateSalary();

            JavaScriptSerializer js = new JavaScriptSerializer();
            StringBuilder s1 = new StringBuilder();
            js.Serialize(arr, s1);
            Console.WriteLine(s1);
            FileStream fs = new FileStream("empjsonarr.json", FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            sw.Write(s1);

            fs.Flush();
            sw.Close();
            fs.Close();
        }
        private static void JsonSerialization()
        {
            Employee emp3 = new Employee();
            emp3.Empid = 102;
            emp3.Empname = "Seema";
            emp3.Salary = 10000;
            emp3.Password = "myPassSeema";
            emp3.CalculateSalary();
            JavaScriptSerializer js = new JavaScriptSerializer();
            StringBuilder s1 = new StringBuilder();
            js.Serialize(emp3, s1);
            Console.WriteLine(s1);
            FileStream fs = new FileStream("empjson.json", FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            sw.Write(s1);

            fs.Flush();
            sw.Close();
            fs.Close();
        }

        private static void xmlSerialize()
        {
            FileStream fs_xml = new FileStream(@"empxmldata.xml", FileMode.Create, FileAccess.Write);
            Employee emp2 = new Employee();
            emp2.Empid = 102;
            emp2.Empname = "Seema";
            emp2.Salary = 10000;
            emp2.Password = "myPassSeema";
            double gsal = emp2.CalculateSalary();
            XmlSerializer xml = new XmlSerializer(typeof(Employee));
            xml.Serialize(fs_xml, emp2);
            fs_xml.Flush();
            fs_xml.Close();
            fs_xml.Dispose();
        }

        private static void binaryDeSerialization()
        {
            try
            {
                FileStream fs1 = new FileStream(@"empdata.bin", FileMode.Open, FileAccess.Read);
                BinaryFormatter formatter1 = new BinaryFormatter();
                Employee edata = (Employee)formatter1.Deserialize(fs1);
                Console.WriteLine(edata.Empid);
                Console.WriteLine(edata.Empname);
                if (edata.Password != null)
                {

                    Console.WriteLine(edata.Password);
                }
                else
                {
                    throw new NullReferenceException("Password unavailable");
                }

                Console.WriteLine(edata.Salary);
                Console.WriteLine(edata.GrossSal);
                fs1.Flush();
                fs1.Close();
                fs1.Dispose();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void binarySerialization()
        {
            Employee emp1 = new Employee();
            emp1.Empid = 101;
            emp1.Empname = "Prajakata";
            emp1.Salary = 10000;
            emp1.Password = "myPassPraj";
            double gsal = emp1.CalculateSalary();

            FileStream fs = new FileStream(@"empdata.bin", FileMode.Create, FileAccess.Write);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(fs, emp1);

            fs.Flush();
            fs.Close();
            fs.Dispose();

        }
    }
}
