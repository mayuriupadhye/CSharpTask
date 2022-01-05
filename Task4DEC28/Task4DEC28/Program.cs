﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Task4DEC28
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a String : ");
            string originalString = Console.ReadLine();
            StringBuilder reverseWordString = new StringBuilder();
            List<char> charlist = new List<char>();
            for (int i = 0; i < originalString.Length; i++)
            {
                if (originalString[i] == ' ' || i == originalString.Length - 1)
                {
                    if (i == originalString.Length - 1)
                        charlist.Add(originalString[i]);
                    for (int j = charlist.Count - 1; j >= 0; j--)
                        reverseWordString.Append(charlist[j]);
                    reverseWordString.Append(' ');
                    charlist = new List<char>();
                }
                else
                {
                    charlist.Add(originalString[i]);
                }
            }
            Console.WriteLine($"\nReverse Word String : \n{reverseWordString.ToString()}");
            Console.ReadKey();
        }
    }
}
