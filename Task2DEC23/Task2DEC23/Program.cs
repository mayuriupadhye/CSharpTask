using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2DEC23
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentInfo s = new StudentInfo(111, "Pooja", "asp.net");
            s.Payment(1000);
            s.Print();
            Console.WriteLine("Dueamount : " + s.DueAmount);
            Console.ReadKey();
        }
    }
}
