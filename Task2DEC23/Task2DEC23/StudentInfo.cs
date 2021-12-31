﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2DEC23
{
    class StudentInfo
    {
        private int rollno;
        private string name;
        private string course;
        private int feepaid;
        private static double servicetax = 12.3;
        public StudentInfo(int rollno, string name, string course)
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
                double total = course == "c#" ? 2000 : 3000;
                //service tax
                total = total + total * servicetax / 100;
                return (int)total;
            }
        }
        public static double ServiceTax
        {
            get
            {
                return servicetax;
            }
            set
            {
                servicetax = value;
            }
        }
    }
}
