using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5DEC28
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a String for find all possible substring of a given string : ");
            string inputString = Console.ReadLine();
            Console.Write("All substrings for given string are : ");
            for (int i = 0; i < inputString.Length; ++i)
            {
                StringBuilder subString = new StringBuilder(inputString.Length - i);
                for (int j = i; j < inputString.Length; ++j)
                {
                    subString.Append(inputString[j]);
                    Console.Write(subString + " ");
                }
            }
            Console.ReadLine();
            Console.WriteLine("-----------");
        }
    }
}
