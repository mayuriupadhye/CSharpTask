using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Student std1 = new Student(1, "Mayuri", "C#");
            Student std2 = new Student(2, "Pooja", "ASP.NET");

            std1.Payment(1000);
            std2.Payment(500);

            std1.Print();
            Console.WriteLine();
            std2.Print();
            //Console.WriteLine();

            Console.ReadKey();
        }
    }
}
