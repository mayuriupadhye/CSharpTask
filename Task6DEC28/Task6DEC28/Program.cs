using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6DEC28
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, l, z = 0, lrg, lrg2nd;
            int[] arr1 = new int[50];

            Console.Write("Enter the Input the size of array : ");
            num = Convert.ToInt32(Console.ReadLine());

            //Stored values into the array
            Console.Write("Input {0} elements in the array :\n", num);
            for (l = 0; l < num; l++)
            {
                arr1[l] = Convert.ToInt32(Console.ReadLine());
            }
            // find location of the largest element in the array 
            lrg = 0;
            for (l = 0; l < num; l++)
            {
                if (lrg < arr1[l])
                {
                    lrg = arr1[l];
                    z = l;
                }
            }
            // ignore the largest element and find the 2nd largest element in the array 
            lrg2nd = 0;
            for (l = 0; l < num; l++)
            {
                if (l == z)
                {
                    l++;  //ignoring the largest element 
                    l--;
                }
                else
                {
                    if (lrg2nd < arr1[l])
                    {
                        lrg2nd = arr1[l];
                    }
                }
            }
            Console.Write("The Second largest element in the array is :  {0} \n\n", lrg2nd);
            Console.ReadLine();
        }
    }
}
