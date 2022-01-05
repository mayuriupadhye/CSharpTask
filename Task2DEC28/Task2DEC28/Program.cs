using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2DEC28
{
    class Program
    {
        public static void Main(string[] args)
        {

            string str1;

            Console.WriteLine("Enter the string :");
            str1 = Console.ReadLine();

            char[] arr = str1.ToCharArray();
            Array.Reverse(arr);

            Console.WriteLine(new String(arr));
            Console.ReadKey();
        }
    }
}
