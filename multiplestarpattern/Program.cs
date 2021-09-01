using System;

namespace multiplestarpattern
{
    class pattern1
    {
        public  void patternMethod1()
        {
            int n;
            Console.WriteLine("enter the size of pattern");
            n = Convert.ToInt32( Console.ReadLine());

            for(int i = 0; i <= n; i++)
            {
                for(int j = 0; j < i+1; j++)
                {
                    Console.Write(j);
                    
                }
                
            }

        }
    }
    class pattern2
    {
        public void patternMethod2()
        {
            int n;
            Console.WriteLine("enter the size of pattern");
            n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j <= i ; j++)
                {
                    Console.Write(i);
                    
                }
                Console.Write("\n");

            }
            for (int i = n; i > 0; i--)
            {
                for (int j = 0; j<i; j++)
                {
                    Console.Write(i);

                }
                Console.Write("\n");
            }
        }
    }













    class Program
    {
        static void Main(string[] args)
        {
            pattern1 obj1 = new pattern1();
            pattern2 obj2 = new pattern2();
            //obj1.patternMethod1();
            obj2.patternMethod2();
        }
    }
}
