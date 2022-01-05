using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Assignment_1
{
    class Information
    {
        public void getContactDetails()
        {
            FileStream filestreamObj = new FileStream(@"F:\C#_Programs\example_1.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(filestreamObj);
            Console.WriteLine("ID\t\tSource\t\t\tDestination\t\tDate\t\t\tStatus\t\tNetwork");

            while(sr.Peek() > 0)
            {
                string str = sr.ReadLine();
                string[] strArray = str.Split(':');

                if (str != "")
                {
                    if (strArray.Length > 1)
                    {
                        if (str.StartsWith("Date"))
                        {
                            string date = strArray[1].Split(' ')[0];
                            Console.Write(date + "\t\t");
                        }
                        else
                            Console.Write(strArray[1] + "\t\t");
                    }
                }
                else
                    Console.WriteLine();
            }
            sr.Close();
            filestreamObj.Close();
            //Console.ReadKey();
        }
    }
}
