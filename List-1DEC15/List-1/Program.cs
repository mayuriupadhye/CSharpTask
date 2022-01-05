﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace List_1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> mylist = temp(new List<int>(new int[] { 1, 2, 3, 4 }));
            foreach (var i in mylist)
            {
                Console.Write(i.ToString() + " ");
            }
            Console.ReadKey();
        }
        public static List<int> temp(List<int> nums)
        {
            IEnumerable<int> e = nums.Select(x => 5 * (x + 2));
            return e.ToList();
        }
    }
}
