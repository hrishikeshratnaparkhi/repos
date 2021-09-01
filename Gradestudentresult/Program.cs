using System;

namespace Gradestudentresult
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int sub1, sub2, sub3;
             int average;
            int avgsum;
            Console.WriteLine("Enter the subjet 1 marks");
            sub1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the subjet 2 marks");
            sub2 = Convert.ToInt32(Console.ReadLine()); 
            Console.WriteLine("Enter the subjet 3 marks");
            sub3 = Convert.ToInt32(Console.ReadLine());
           
             avgsum = sub1 + sub2 + sub3;

             average = (avgsum / 3);
            
             if (average >= 90)
            {
                Console.WriteLine("Grade A");
            }
            else if (average > 80 && average < 90)
            {
                Console.WriteLine("Grade B");
            }
            else
            {
                Console.WriteLine("Grade pass");
            }
            
            
            

            
            
            
            

            
                 
        }
    }
}
