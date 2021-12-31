using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3DEC23
{
    class PartTimeCourse : Course
    {
        private string timings;
        public PartTimeCourse(string name, int duration, int coursefee, string timings) : base(name, duration, coursefee)
        {
            this.timings = timings;
        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine(timings);
        }
        public override int GetTotalFee()
        {
            return (int)(coursefee * 0.90);//for 10% discount
        }
    }
}
