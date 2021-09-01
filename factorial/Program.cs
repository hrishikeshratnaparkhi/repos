using System;

namespace factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            int fact =1;
            Console.WriteLine("enter the number to get the factorial of it");
            num = Convert.ToInt32(Console.ReadLine());

            for(int i=0;num>i;num--)
            {
                fact = fact * num;
            }
            Console.WriteLine(fact);
        }
    }
}
