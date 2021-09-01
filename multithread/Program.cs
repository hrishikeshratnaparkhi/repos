using System;
using System.Threading;

namespace multithread
{
    class Program
    {
        
        

        static void Main()
        {
            Program task1 = new Program(ProcessTask1);
            Program task2 = new Program(ProcessTask2);
            Thread t1 = new Thread(task1);
            Thread t2 = new Thread(task2);
            t1.Start();
            t2.Start();
            Console.ReadLine();


        }
        static void ProcessTask1()
        {
            for(int i=0; i < 5; i++)
            {
                Console.WriteLine("thread t1 in action`");
                Thread.Sleep(5);

            }
        }
        static void ProcessTask2()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("thread t2 in action`");
                Thread.Sleep(10);

            }
        }

    }
}
