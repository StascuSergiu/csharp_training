using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTrainingConsoleApp
{
    internal class Year
    {
        public int year;

        public Year(int year)
        {
            this.year = year;
        }

        public bool isLeap()
        {
            return (year % 4) == 0;
        }
    }
}
