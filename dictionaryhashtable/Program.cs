using System;
using System.Collections;


namespace collections

{
    class Program
    {
        public void StackMethod()
        {
           
            Stack myST = new Stack();
            myST.Push(1);
            myST.Push("rishi");
            myST.Push('C');

            foreach(var item in myST)
            {
                Console.WriteLine(item);

            }
            Console.WriteLine("////////End Loop.......");
            Console.WriteLine(myST.Pop());

            Console.WriteLine("//////////delete element");

            foreach(var item in myST)
            {
                Console.WriteLine(item);

            }
            Console.WriteLine("######END LOOP-----");
            Console.WriteLine("Top most item to be delete" +"  "+ myST.Peek());


        }

    }
    //\\\\\\\\\\\\\\\\\\\\Queue Collection
    class QueueeClass
    {
        public void QueuMethod()
        {
            
            Queue myQ = new Queue();
            myQ.Enqueue("rishi");
            myQ.Enqueue(1);
            myQ.Enqueue('R');

            foreach(var Item in myQ)
            {
                Console.WriteLine(Item);
            }

            object dequed = myQ.Dequeue();
            Console.WriteLine("Dqueued Element is "+ dequed);




            foreach (var Item in myQ)
            {
                Console.WriteLine(Item);
            }




        }
    }

    class bitarrays
    {
        public void bitarrayMetod()
        {
            BitArray mybitarray = new BitArray(3);
            mybitarray[0] = true;
            mybitarray[1] = false;
            mybitarray[2] = true;
            Console.WriteLine("//////////////////////////");
            PrintValues(mybitarray);
            Console.WriteLine("setting all the bits");
            mybitarray.SetAll(false);
            PrintValues(mybitarray);
        }
        public static void PrintValues(IEnumerable myarr)
        {
            foreach (object obj in myarr)
                Console.WriteLine(obj);


        }
    }









    //        public void HashTableMethod()
    //        {
    //            Hashtable myHT = new Hashtable();
    //            myHT.Add("1", "C#");
    //            myHT.Add("second", "java");
    //            myHT.Add("third", "C++");
    //            myHT.Add("fourth", "C");

    //            Console.WriteLine("keys and values");
    //            PrintKeysAndValues(myHT);
    //            Console.WriteLine("values for key secomd is " + myHT["third"]);
    //        }
    //        public void PrintKeysAndValues(Hashtable myList)
    //        {
    //            IDictionaryEnumerator myEnumerator = myList.GetEnumerator();
    //            while (myEnumerator.MoveNext())
    //            {
    //                Console.WriteLine("\t{0}:\t{1}", myEnumerator.Key, myEnumerator.Value);

    //            }
    //            Console.WriteLine();
    //        }
    //    }

    //    class dictnryHastTableex
    //    {
    //        public static void Main()
    //        {
    //            Program obj = new Program();
    //            obj.HashTableMethod();
    //            Console.ReadKey();
    //        }
    //    }


    class stackex
    {
        public static void Main()
        {
            // Program obj = new Program();
            //obj.StackMethod();
            QueueeClass objQ = new QueueeClass();
            objQ.QueuMethod();
            bitarrays Obit = new bitarrays();
            Obit.bitarrayMetod();
            Console.ReadKey();

        }
    }
}





//}
