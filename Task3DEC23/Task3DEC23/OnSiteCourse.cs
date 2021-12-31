using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3DEC23
{
    class OnSiteCourse : Course
    {
        private string company;
        private int nostud;
        public OnSiteCourse(string name, int duration, int coursefee, string company, int nostud)
            : base(name, duration, coursefee)
        {
            this.company = company;
            this.nostud = nostud;
        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine(company);
            Console.WriteLine(nostud);
        }
        public override int GetTotalFee()
        {
            return (int)(coursefee * 1.1);//10% more
        }
    }
}
