using System;

namespace PatternPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            a = 10;
            b = a++;
            Console.WriteLine("A value {0}", a);
            Console.WriteLine("B value {0}", b);
            b = ++a;
            Console.WriteLine("A is {0}", a);
            Console.WriteLine("B is {0} ", b);

           // breakContinue obj = new breakContinue();
           // obj.continue1();
            //obj.break1();


            gotostmt Ogoto = new gotostmt();
            Ogoto.gotomethod();


        }
    }
    class breakContinue
    {
        public void break1()
        {
            for (int i = 0; i < 10; i++)
            {
                if (i == 5)
                {
                    break;
                }

                Console.WriteLine("{0}", i);



            }
        }
        public void continue1()
        {
            for (int i = 0; i < 10; i++)
            {
                if (i == 5)
                {
                    continue;
                }

                Console.WriteLine(i);



            }

        }
    }
    class gotostmt
    {
        public void gotomethod()
        {
            int i = 3, j = 0;
            switch (i)
            {
                case 1:
                    j += 10;
                    Console.WriteLine("J value is {0}", j);
                    break;
                case 2:
                    j += 5;
                    goto case 1;
                case 3:
                    j += 11;
                    goto case 1;
                    break;
                default:
                    Console.WriteLine("ss");
                    break;
            }
            Console.WriteLine("");
            Console.ReadLine();


        }

    }
}


        



   