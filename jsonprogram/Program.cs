using System;
using System.Runtime.Serialization.Json;
using System.IO;


namespace jsonprogram
{
    class Employee
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string[] Skills { get; set; }

    

    class JsonSerialization
    {
        public static void Main()
        {
            Employee employee = new Employee
            {
                EmployeeId = 121,
                EmployeeName = "kevin";
            Skills = new String[] { "C", "sql" };
        };


            StreamWriter newStream = File.CreateText(@"C:\results.Json");

                DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(Employee));
                        using (FileStream file = new FileStream("results.Json" , FileMode.OpenorCreate, FileAccess.Read));
                                {
            
                                 serializer.WriteObject(File, employee);
                                     }

}

        



       
  
