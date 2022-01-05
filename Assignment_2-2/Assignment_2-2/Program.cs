using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2_2
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter the First Name :");
            string FName = Console.ReadLine();
            Console.Write("Enter the Last Name :");
            string LName = Console.ReadLine();
            Console.Write("Enter ID :");
            int ID = int.Parse(Console.ReadLine());
            Console.Write("Enter the Num of Scores :");
            int NumScores = int.Parse(Console.ReadLine());
            int[] TestScores = new int[NumScores];
            for(int i = 0; i < NumScores; i++)
            {
                Console.Write("Enter the TestScores {0}:", (i + 1));
                TestScores[i] = int.Parse(Console.ReadLine());
            }
            Student StdObj = new Student(FName, LName, ID, TestScores);
            StdObj.PrintPerson();
            Console.WriteLine("Grade : " + StdObj.Calculate());
            Console.ReadLine();

        }
    }
}
