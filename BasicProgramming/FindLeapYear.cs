using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgramming
{
    class FindLeapYear
    {
        public static void ReadInput()
        {
            Console.WriteLine("Enter the Year: ");
            int year = Convert.ToInt32(Console.ReadLine());

            FindingLeapYear(year);




        }
        public static void FindingLeapYear(int year) 
        {
            if (((year % 4 == 0) && (year % 100 != 0)) || (year % 400 == 0))
            {
                Console.WriteLine("{0} is a Leap Year.", year);
            }
            else Console.WriteLine("{0} is not a Leap Year.", year);
        }

    }
}
