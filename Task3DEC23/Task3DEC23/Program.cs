using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3DEC23
{
    class Program
    {
        static void Main(string[] args)
        {
            Course c = new OnSiteCourse("ASP.NET", 40, 5500, "Techno Tech", 10);
            c.Print();
            Console.WriteLine(c.GetTotalFee());
            Console.WriteLine("\n");

            c = new PartTimeCourse("C#", 50, 5100, "9am-6pm");
            c.Print();
            Console.WriteLine(c.GetTotalFee());
            Console.ReadLine();
        }
    }
}
