using System;
using System.Threading;

namespace threadpool
{
    class Program
    {
        public static void Main()
        {
            ThreadPool.QueueUserWorkItem(new WaitCallback(ProcessTask), null);
            Console.WriteLine("main thread in action");
            Thread.Sleep(2000);
            Console.WriteLine("main thread in action");

            
        }
        private static void QueueUserWorkItem(WaitCallback waitcallback,object p)
        {
            throw new NotImplementedException();

        }
        static void ProcessTask(object param)
        {
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine("thread t1 in action");

            }
        }
    }
}
