using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1DEC23
{
    class Student
    {
        private int rollno;
        private string name;
        private string course;
        private int feepaid;

        public Student(int rollno, string name, string course)
        {
            this.rollno = rollno;
            this.name = name;
            this.course = course;
        }
        public void Payment(int amount)
        {
            feepaid += amount;
        }
        public void Print()
        {
            Console.WriteLine(rollno);
            Console.WriteLine(name);
            Console.WriteLine(course);
            Console.WriteLine(feepaid);
        }
        public int DueAmount
        {
            get
            {
                return Totalfee - feepaid;
            }
        }
        public int Totalfee
        {
            get
            {
                return course == "c#" ? 2000 : 3000;
            }
        }
    }
}