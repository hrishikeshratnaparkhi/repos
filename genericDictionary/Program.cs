using System;
using System.Collections.Generic;

namespace genericDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> Dt = new Dictionary<int, string>(5);
            Dt.Add(1, "rishi");
            Dt.Add(5, "rishi");
            Dt.Add(2, "rishi");
            Dt.Add(8, "rishi");

            foreach(KeyValuePair<int,string> i in Dt)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine(" ********************/*********************");
                
            Sorteddictionary sdM = new Sorteddictionary();
            sdM.sortedDnryMethod();
        }
    }
    class Sorteddictionary
    {
        public void sortedDnryMethod()
        {
            SortedDictionary<int, string> SD = new SortedDictionary<int, string>();
            SD.Add(4, "rishi r");
            SD.Add(5, "rishi r");
            SD.Add(3, "rishi r");
            SD.Add(9, "rishi r");
            SD.Add(6, "rishi r");
            foreach (KeyValuePair<int , string> i in SD)
            {
                Console.WriteLine(i);
            }
        }

    }
}
