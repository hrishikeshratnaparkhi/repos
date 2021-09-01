using System;
using System.Collections.Generic;

namespace genericQUEUE
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> Q = new Queue<string>();

            Q.Enqueue("780");
            Q.Enqueue("200");
            Q.Enqueue("70");
            Q.Enqueue("20");
            
            string first = Q.Peek();
            Q.Dequeue();


            foreach(string i in Q)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine(first);

        }
    }
}
