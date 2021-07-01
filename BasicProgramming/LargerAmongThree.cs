using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgramming
{
    class LargerAmongThree
    {
        public static void ReadInput()
        {
            Console.WriteLine("Enter Three Numbers: ");
            int digit1 = Convert.ToInt32(Console.ReadLine());
            int digit2 = Convert.ToInt32(Console.ReadLine());
            int digit3 = Convert.ToInt32(Console.ReadLine());

            IsGreater(digit1, digit2, digit3);


        }
        public static void IsGreater(int num1, int num2, int num3)
        {
            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.Write("Number one is the largest!\n");
                }
                else
                {
                    Console.Write("Number three is the largest!\n");
                }
            }
            else if (num2 > num3)
                Console.Write("Number two is the largest!\n");
            else
                Console.Write("Number three is the largest!\n");
        }
    }
}
