using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLaba2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is an example of a magic box:");

            int[] magicBoxExample = {9,2,25,18,11,3,21,19,12,10,22,20,13,6,4,16,14,7,5,23,15,8,1,24,17 };

            Console.WriteLine("");

            for (int i = 0; i < magicBoxExample.GetLength(0); i++)
            {
                Console.Write(magicBoxExample[i] + " ");
                if ( (i+1) % 5 == 0 )
                {
                    Console.WriteLine("");
                }
                
            }

            Console.WriteLine("");

            Console.WriteLine("Enter message");

            Console.WriteLine("");
            string message = Console.ReadLine();

            char[] magicBoxFirst = new char[25];

            char[] magicBoxSecond = new char[25];

            int counter = 0;

            for (int i = 0; i < magicBoxFirst.Length; i++)
            {
                if (message[i] == ' ')
                {
                    magicBoxFirst[i] = '_';
                }
                else
                {
                    magicBoxFirst[i] = message[i];
                }
                counter++;
            }
            for (int i = 0; i < magicBoxSecond.Length; i++)
            {
                if (message[counter] == ' ')
                {
                    magicBoxSecond[i] = '_';
                }
                else
                {
                    magicBoxSecond[i] = message[counter];
                }
                counter++;
            }

            Console.WriteLine("");
            Console.WriteLine("Before encryption");
            Console.WriteLine("");

            for (int i = 0; i < magicBoxFirst.Length; i++)
            {
                Console.Write(magicBoxFirst[i] + " ");
                if ((i + 1) % 5 == 0)
                {
                    Console.WriteLine("");
                }
            }

            Console.WriteLine("");

            for (int i = 0; i < magicBoxSecond.Length; i++)
            {
                Console.Write(magicBoxSecond[i] + " ");
                if ((i + 1) % 5 == 0)
                {
                    Console.WriteLine("");
                }
            }

            Console.WriteLine("");
            Console.WriteLine("After encryption");
            Console.WriteLine("");

            for (int i = 0; i < magicBoxFirst.Length; i++)
            {
                if (message[i] == ' ')
                {
                    magicBoxFirst[magicBoxExample[i] - 1] = '_';
                }
                else
                {
                    magicBoxFirst[magicBoxExample[i] - 1] = message[i];
                    
                }
            }

            for (int i = 0; i < magicBoxSecond.Length; i++)
            {
                if (message[i + magicBoxFirst.Length] == ' ')
                {
                    magicBoxSecond[magicBoxExample[i] - 1] = '_';
                }
                else
                {
                    magicBoxSecond[magicBoxExample[i] - 1] = message[i + magicBoxFirst.Length];
                }
            }


            for (int i = 0; i < magicBoxFirst.Length; i++)
            {
                Console.Write(magicBoxFirst[i] + " ");
                if ((i + 1) % 5 == 0)
                {
                    Console.WriteLine("");
                }
            }

            Console.WriteLine("");

            for (int i = 0; i < magicBoxSecond.Length; i++)
            {
                Console.Write(magicBoxSecond[i] + " ");
                if ((i + 1) % 5 == 0)
                {
                    Console.WriteLine("");
                }
            }

            Console.WriteLine("");
            Console.WriteLine("Decryption");
            Console.WriteLine("");

            char[] magicBoxDecryptionFirst = new char[25];

            char[] magicBoxDecryptionSecond = new char[25];

            for (int i = 0; i < magicBoxFirst.Length; i++)
            {
                if (magicBoxFirst[magicBoxExample[i] - 1] == ' ')
                {
                    magicBoxDecryptionFirst[i] = '_';
                }
                else
                {
                    magicBoxDecryptionFirst[i] = magicBoxFirst[magicBoxExample[i] - 1];
                }
            }
            for (int i = 0; i < magicBoxSecond.Length; i++)
            {
                if (magicBoxSecond[magicBoxExample[i] - 1] == ' ')
                {
                    magicBoxDecryptionSecond[i] = '_';
                }
                else
                {
                    magicBoxDecryptionSecond[i] = magicBoxSecond[magicBoxExample[i] - 1];
                }
            }
            
            for (int i = 0; i < magicBoxDecryptionFirst.Length; i++)
            {
                Console.Write(magicBoxDecryptionFirst[i] + " ");
                if ((i + 1) % 5 == 0)
                {
                    Console.WriteLine("");
                }
            }

            Console.WriteLine("");

            for (int i = 0; i < magicBoxDecryptionSecond.Length; i++)
            {
                Console.Write(magicBoxDecryptionSecond[i] + " ");
                if ((i + 1) % 5 == 0)
                {
                    Console.WriteLine("");
                }
            }
        }
    }
}
