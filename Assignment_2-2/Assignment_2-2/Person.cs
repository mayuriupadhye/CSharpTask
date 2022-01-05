using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2_2
{
    class Person
    {
        protected string FName;
        protected string LName;
        protected int ID;

        public Person(string FName, string LName, int ID)
        {
            this.FName = FName;
            this.LName = LName;
            this.ID = ID;
        }
        public void PrintPerson()
        {
            Console.WriteLine("Name : " + LName + "," + FName + "\nID : " + ID);
        }
    }
}
