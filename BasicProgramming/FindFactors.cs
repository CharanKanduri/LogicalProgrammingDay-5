using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgramming
{
    class FindFactors
    {
        public static void ReadInput()
        {
            Console.WriteLine("Enter the number : ");
            int number = Convert.ToInt32(Console.ReadLine());
            Factors(number);


        }
        public static void Factors(int n)
        {
            int i = 1;
            while (i <= n)
            {
                if (n % i == 0) Console.WriteLine(i+" ");
                i++;
            }
        }
    }
}
