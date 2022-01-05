using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2_1
{
    class Student
    {
        public int RollNo;
        public string Name;
        public string CourseJoined;
        public int FeePaid;

        public Student(int RollNo,string Name,string CourseJoined)
        {
            this.RollNo = RollNo;
            this.Name = Name;
            this.CourseJoined = CourseJoined;
        }
        public void Payment(int amount)
        {
            FeePaid += amount;
        }
        public int TotalFee
        {
            get
            {
                if (CourseJoined.ToLower() == "c#")
                    return 2000;
                else if (CourseJoined.ToLower() == "asp.net")
                    return 3000;
                return 0;
            }
        }
        public int DueAmount
        {
            get
            {
                return TotalFee - FeePaid;
            }
        }
        public void Print()
        {
            Console.WriteLine("Roll No : {0}", RollNo);
            Console.WriteLine("Name : {0}", Name);
            Console.WriteLine("Course Joined : {0}", CourseJoined);
            Console.WriteLine($"Total Fee : {TotalFee}"); ;
            Console.WriteLine("Fee Paid : {0}", FeePaid);
            Console.WriteLine("Due Amount : {0}", DueAmount);
        }
    }
}
