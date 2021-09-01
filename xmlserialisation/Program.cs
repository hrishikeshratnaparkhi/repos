using System;
using System.Xml.Serialization;
using System.IO;

namespace xmlserialisation
{
    namespace Serialization
    {
        [XmlRoot(ElementName = "employee")]
        class Program
        {
            public class Employee
            {
                private string empID;
                private string empName;
                private string empAge;
                private string[] empSkills;

                [XmlAttribute(AttributeName = "empID")]

                public string EpID
                {
                    get { return empID; }
                    set { empID = value; }

                }
                public string Name
                {
                    get { return empName; }
                    set { empName = value; }
                }
                [XmlElement(ElementName = "Age")]
                public     string Age
                {
                    get { return empAge; }
                    set { empAge = value; }
                }
                [XmlElement(ElementName = "Skills")]
                public string[] skills
                {
                    get { return empSkills; }
                    set { empSkills = value; }

                }


            }

            class XmlSerilaizationex
            {
                public static void Main()
                {
                    Employee serializationEmp = new Employee();

                    string[] empSkills = { "c#", "Sql" };
                    serializationEmp.EpID = " empopop2";
                    serializationEmp.Name = "risji";
                    serializationEmp.Age = "26";
                    serializationEmp.skills = empSkills;

                    StreamWriter newStream = File.CreateText(@"C:\SerializationSample.xml");
                    XmlSerializer xmlSerialize = new XmlSerializer(typeof(Employee));

                    xmlSerialize.Serialize(newStream, serializationEmp);
                    newStream.Close();
                    Employee deserializeEmp = new Employee();

                    StreamReader readStream = File.OpenText(@"C:\SerializationSample.xml");
                    xmlSerialize = new XmlSerializer(typeof(Employee));

                    deserializeEmp = (Employee)xmlSerialize.Deserialize(readStream);

                    Console.WriteLine("deseriaslised object employee name" + deserializeEmp.Name);

                    Console.WriteLine("deseriaslised object employee name" + serializationEmp.Name);
                    Console.ReadKey();
                }
            }
        }
    }
}

