using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace genericListExample
{
    class Program
    {
        static void Main(string[] args)
        {
            listexp obj1 = new listexp();
            obj1.listMethod();

        }
    }
    class listexp
    {
        public void listMethod()
        {
            List<int> listobj = new List<int>();
            listobj.Add(1);
            listobj.Add(2);
            listobj.Add(3);
            listobj.Add(7);
            int count = listobj.Count;

            foreach (int item in listobj)
            {
                Console.WriteLine(item);

            }
            Console.WriteLine(count);
        }
    }
    class stackexp
    {
        public void stackMethod()
        {
            Stack<int> stkobj = new Stack<int>();

            stkobj.Push(123);
            stkobj.Push(456);
            stkobj.Push(789);
            stkobj.Push(5646);

        }
    }
    

}