using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2_2
{
    class Student : Person
    {
        private int[] TestScore;
        public Student(string FName, string LName, int ID, int[] TestScore)
          :base(FName,LName,ID)
        {
            this.TestScore = TestScore;
        }
        public char Calculate()
        {
            float Average = 0;
            float Sum = 0;
            char Grade = ' ';

            for ( int i=0, length=this.TestScore.Length; i<length; i++)
            {
                Sum += this.TestScore[i];
            }
            if (TestScore.Length != 0)
                Average = Sum / (float)TestScore.Length;
            if (Average >= 90 && Average <= 100)
            {
                Grade = 'O';
            }
            else if (Average >= 80 && Average < 90)
            {
                Grade = 'E';
            }
            else if (Average >= 70 && Average < 80)
            {
                Grade = 'A';
            }
            else if (Average >= 55 && Average < 70)
            {
                Grade = 'P';
            }
            else if (Average >= 40 && Average < 55)
            {
                Grade = 'D';
            }
            else if (Average < 40)
            {
                Grade = 'T';
            }
            return Grade;
        }
    }
}
