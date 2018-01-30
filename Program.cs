using System;

namespace hw2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write the year");
            int year = Convert.ToInt32(Console.ReadLine());

            if(year % 4 == 0)
                Console.WriteLine("It is leap year");
            
            if(year % 4 != 0)
                Console.WriteLine("It is Not Leap year");
        }
    }
}
