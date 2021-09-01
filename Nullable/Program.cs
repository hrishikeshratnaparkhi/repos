using System;

namespace Nullable
{
    class NullableExample
    {
        static void Main(string[] args)
        {
            int? num = null;

            if (num.HasValue == true) {
                Console.WriteLine("Result 1 from if block");
                Console.WriteLine("num =" + num.Value);
            }
           else
            {
                Console.WriteLine("Result 2 from else block");
                Console.WriteLine("num " + num.GetValueOrDefault());



            }
            Console.ReadKey();

        }
    }
}
