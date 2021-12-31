using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1DEC23
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student(1, "Mayuri", "c#");
            s.Payment(1000);
            s.Print();
            Console.WriteLine("DueAmount : " + s.DueAmount);
            Console.ReadKey();
        }
    }
}
