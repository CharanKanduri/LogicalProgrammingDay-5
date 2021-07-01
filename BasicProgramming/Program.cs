using System;

namespace BasicProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Basic Programming Examples");
            Console.WriteLine("Please Select the option\n1.Find Leap Year\n2.Find Factors\n3.Find Vowel or Consonent\n4.Find Largest Among Three");

            int chioce= Convert.ToInt32(Console.ReadLine());
            switch (chioce)
            {
                case 1:
                    FindLeapYear.ReadInput();
                    break;
                case 2:
                    FindFactors.ReadInput();
                    break;

                case 3:
                    // code block
                    break;

                default:
                    // code block
                    break;
            }

        }
    }
}
