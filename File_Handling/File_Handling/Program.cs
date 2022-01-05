using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace File_Handling
{
    class Program
    {
        static void Main(string[] args)
        {
            string file = @"F:\C#_Programs\example_1.txt";
            //Creating and Writting
            using (StreamWriter writer = new StreamWriter(file))
            {
                writer.Write(DateTime.Now.ToString());
                Console.WriteLine("Successfully Added Current Date and Time");
            }
            //Reading File
            using (StreamReader reader = new StreamReader(file))
            {
                Console.Write("Reading Current Time : ");
                Console.WriteLine(reader.ReadToEnd());
            }
            Console.ReadKey();
        }
    }
}
