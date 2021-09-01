using System;
using System.Collections.Generic;

namespace genericStack
{
    class Program
    {
        
        static void Main(string[] args)
        {
             
          
                Stack<int> st = new Stack<int>();
            st.Push(10);
            st.Push(20);
            st.Push(30);
            st.Push(40);
            int a =st.Pop();

            foreach(int i in st)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine(a);

        }
    }
}
