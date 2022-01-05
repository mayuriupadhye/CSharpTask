using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DArray_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] idArr = new string[] { };
            string[] sourceArr = new string[] { };
            string[] networkArr = new string[] { };
            string[] destinationArr = new string[] { };
            string[] statusArr = new string[] { };

            FileStream filestreamObj = new FileStream(@"F:\C#_Programs\example_1.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(filestreamObj);
            
            while(sr.Peek() > 0)
            {
                string str = sr.ReadLine();
                string[] strArray = str.Split(':');
                
                if (str != "")
                {
                    if (strArray.Length > 1)
                    {
                        if (str.StartsWith("Id"))
                        {
                             idArr = strArray;
                        }
                        else if (str.StartsWith("Source"))
                        {
                            sourceArr = strArray;
                        }
                        else if (str.StartsWith("Network"))
                        {
                            networkArr = strArray;
                        }
                        else if (str.StartsWith("Destination"))
                        {
                            destinationArr = strArray;
                        }
                        else if (str.StartsWith("Network"))
                        {
                            networkArr = strArray;
                        }
                    }
                    else
                        Console.WriteLine();

                }
                sr.Close();
                filestreamObj.Close();
            }
            Console.ReadKey();

            /*List<string> id = new List<string>();
            id.Add("1");
            List<string> source = new List<string>();
            source.Add("86876786");
            List<string> network = new List<string>();
            network.Add("airtel");
            List<string> destination = new List<string>();
            destination.Add("878979723");
            List<string> status = new List<string>();
            status.Add("Success");

            foreach(string value in id)
            {
                Console.WriteLine("ID is:");
                Console.WriteLine(value);
            }
            Console.WriteLine();
            foreach (string value in source)
            {
                Console.WriteLine("Source is:");
                Console.WriteLine(value);
            }
            Console.WriteLine();
            foreach (string value in network)
            {
                Console.WriteLine("Network is:");
                Console.WriteLine(value);
            }
            Console.WriteLine();
            foreach (string value in destination)
            {
                Console.WriteLine("Destination is:");
                Console.WriteLine(value);
            }
            Console.WriteLine();
            foreach (string value in status)
            {
                Console.WriteLine("Status is:");
                Console.WriteLine(value);
            }*/



        }
    }
}
