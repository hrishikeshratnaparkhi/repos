using System;

namespace Tableprogram
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, product;
            Console.WriteLine("enter the numer of which you want table to be displayed");
            num = Convert.ToInt32(Console.ReadLine());

            for(int i = 1; i <= 10; i++)
            {
                product = num * i;
                Console.WriteLine("{0} x {1} = {2}", num, i, product);
            }
        }
    }
}
