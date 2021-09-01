using System;
using System.Reflection;

namespace Delegateexp
{
    class reflections
    {
        public static void Main()
        {
            System.Type type = typeof(Employee);
            Console.WriteLine(type);

            MethodInfo[] methods = type.GetMethods();
            PropertyInfo[] properties = type.GetProperties();
            FieldInfo[] fields = type.GetFields();

            Console.WriteLine("employee class has following methods");
            foreach (MemberInfo method in methods)
            {
                Console.WriteLine(method.Name);

            }
            Console.WriteLine("employee class has following propertiewd");
            foreach (MemberInfo property in properties)
            {
                Console.WriteLine(property.Name);


            }
            Console.WriteLine("employee class has following fields");
            foreach (MemberInfo field in fields)
            {
                Console.WriteLine(field.Name);


            }

        }
        public class Employee
        {
            public int age;
            public string name;
            public int Age
            {
                get
                {
                    return age;

                }
                set
                {
                    age = value;

                }
            }
            public string Name
            {
                get
                {
                    return name;
                }
                set
                {
                    Name = value;

                }
            }
        }
    }
}
