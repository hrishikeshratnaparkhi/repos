using System;

namespace genericClass
{
    class generictype<t1, t2>
    {
        public t1  myproperty { get; set; }
        public void genericmethod(t1 x , t2 y)
        {
            Console.WriteLine( x ) ;
            Console.WriteLine(y) ;
        }

    }




    class genericexp
    {
        static void Main(string[] args)
        {
            generictype<int, string> obj1 = new generictype<int, string>();
            obj1.genericmethod(1, "rishi");
            
        }
    }
}
