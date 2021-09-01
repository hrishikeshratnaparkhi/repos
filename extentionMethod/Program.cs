using System;

namespace extentionMethod
{
    static class ExtentionString
    {
        public static string UppercaseFirstLetter(this string value)
        {
            if (value.Length > 0)
            {
                char[] array = value.ToCharArray();
                array[0] = char.ToUpper(array[0]);
                return new string(array);
            }
            return value;
        }

    }
    class ExtentionMethodEX
    {
        static void Main()
        {
            string es = "arun kumar";
            Console.WriteLine(es.UppercaseFirstLetter());
            Console.ReadKey();

                
        }
    }
    


    
}
