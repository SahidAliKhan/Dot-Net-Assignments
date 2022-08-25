using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;

namespace Day8
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            //CreateXmlFile();
            ReadXmlFile();
            Console.ReadLine();
        }

        private static void CreateXmlFile()
        {
            XmlWriter xw = XmlWriter.Create("emp.xml");
            xw.WriteStartDocument();
            xw.WriteStartElement("empdata");
            xw.WriteAttributeString("city", "Pune");
            xw.WriteElementString("empno", "1");
            xw.WriteElementString("empname", "ABC");
            xw.WriteElementString("deptno", "10");
            xw.WriteComment("This is a comment");


            xw.WriteEndElement();
            xw.WriteEndDocument();
            xw.Close();
            xw.Dispose();
        }

        private static void ReadXmlFile()
        {
            FileStream fs = new FileStream("emp.xml", FileMode.Open, FileAccess.Read);
            XmlTextReader xr = new XmlTextReader(fs);
            while (xr.Read())
            {
                switch (xr.NodeType)
                {
                    case XmlNodeType.None:
                        Console.WriteLine(xr.Value);
                        break;
                    case XmlNodeType.Element:
                        Console.WriteLine(xr.Value);
                        break;
                    case XmlNodeType.Attribute:
                        Console.WriteLine(xr.Value);
                        break;
                    case XmlNodeType.Text:
                        Console.WriteLine(xr.Value);
                        break;
                    case XmlNodeType.CDATA:
                        Console.WriteLine(xr.Value);
                        break;
                    case XmlNodeType.EntityReference:
                        Console.WriteLine(xr.Value);
                        break;
                    case XmlNodeType.Entity:
                        Console.WriteLine(xr.Value);
                        break;
                    case XmlNodeType.ProcessingInstruction:
                        Console.WriteLine(xr.Value);
                        break;
                    case XmlNodeType.Comment:
                        Console.WriteLine(xr.Value);
                        break;
                    case XmlNodeType.Document:
                        Console.WriteLine(xr.Value);
                        break;
                    case XmlNodeType.DocumentType:
                        Console.WriteLine(xr.Value);
                        break;
                    case XmlNodeType.DocumentFragment:
                        Console.WriteLine(xr.Value);
                        break;
                    case XmlNodeType.Notation:
                        Console.WriteLine(xr.Value);
                        break;
                    case XmlNodeType.Whitespace:
                        Console.WriteLine(xr.Value);
                        break;
                    case XmlNodeType.SignificantWhitespace:
                        Console.WriteLine(xr.Value);
                        break;
                    case XmlNodeType.EndElement:
                        Console.WriteLine(xr.Value);
                        break;
                    case XmlNodeType.EndEntity:
                        Console.WriteLine(xr.Value);
                        break;
                    case XmlNodeType.XmlDeclaration:
                        Console.WriteLine(xr.Value);
                        break;
                }
            }
            xr.Close();
            xr.Dispose();
            fs.Close();
            fs.Dispose();
        }
    }
}
