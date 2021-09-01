using System;
using System.IO;
using System.Xml;

namespace XmlReaderWriter1
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlWriter xmlWriter = XmlWriter.Create("C:\\dept.xml");

            xmlWriter.WriteStartDocument();
            xmlWriter.WriteStartElement("departments");

            xmlWriter.WriteStartElement("department");
            xmlWriter.WriteAttributeString("Id", "1001");
            xmlWriter.WriteString("purchase");
            xmlWriter.WriteEndElement();

            xmlWriter.WriteStartElement("department");
            xmlWriter.WriteAttributeString("Id", "1002");
            xmlWriter.Close();
            using (XmlReader reader = XmlReader.Create("C:\\department.xml")) 
            {
                while(reader.Read())
                {
                    if (reader.IsStartElement())
                    {
                        switch (reader.Name.ToString())
                        {
                            case "Did":
                                Console.WriteLine("Name of elements is " + reader.ReadString());
                                break;
                            case "name":
                                Console.WriteLine("your depart is " + reader.ReadString());
                                break;
                            case "section":
                                Console.WriteLine("your dept is " + reader.ReadString());
                                break;
                        

                        }
                    }
                    Console.WriteLine("");
                }
            }

         
            
        }
    }
}
