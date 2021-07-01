using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgramming
{
    class FindVowelOrConsonent
    {
        public static void ReadInput()
        {

            Console.WriteLine("Enter the alphabet: ");
            char alphabet = Console.ReadKey().KeyChar;
            CharProperity(alphabet);


             Console.WriteLine("Enter the alphabet: ");
                char alphabet = Console.ReadKey().KeyChar;
            CharProperity(alphabet);
                

        }

        public static void CharProperity(char ch)
        {
            if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u' || ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U')
            {

                Console.WriteLine("\n" + ch + " is Vowel.");

                Console.WriteLine("\n"+ch + " is Vowel.");


            }
            else if ((ch >= 'a' && ch <= 'z') || (ch >= 'A' && ch <= 'Z'))
            {

                Console.WriteLine("\n" + ch + " is Consonant.");
            }
        }

                Console.WriteLine("\n"+ch + " is Consonant.");
            }
        }


    }
}

