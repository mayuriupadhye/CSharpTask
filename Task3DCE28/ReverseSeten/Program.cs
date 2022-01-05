using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseSeten
{
    class Program
    {
        public static void Main(string[] args)
        {
            int temp;
            Console.WriteLine("Enter the string : ");
            string s = Console.ReadLine();
            string[] a = s.Split(' ');
            int k = a.Length - 1;
            temp = k;
            Console.WriteLine("\nReverse string : ");
            for (int i = k; temp >= 0; k--)
            {
                Console.Write(a[temp] + "" + ' ');
                --temp;
            }
            Console.ReadKey();
        }
    }
}
