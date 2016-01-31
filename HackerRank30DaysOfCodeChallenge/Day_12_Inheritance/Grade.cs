using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_12_Inheritance
{
    public class Grade : Student
    {
        private int score;

        public Grade(string fname, string lname, int p, int score) 
            :base(fname, lname, p)
        {
            this.score = score;
        } 

        public char calculate()
        {
            if (this.score < 40)
            {
                return 'D';
            }
            if (this.score < 60)
            {
                return 'B';
            }
            if (this.score < 75)
            {
                return 'A';
            }
            if (this.score < 90)
            {
                return 'E';
            }
            if (this.score <= 100)
            {
                return 'O';
            }

            return 'Q'; // default
        }

    }
}
