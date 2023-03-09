using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTrainingConsoleApp
{
    public class Number
    {
        public int myNumber;

        public Number(int myNumber)
        {
            this.myNumber = myNumber;
        }

        public bool isDivisibleBy(int divisor) 
        {
            return myNumber % divisor == 0; 
        }

        public bool isDivisibleBy7and11()
        {
            return isDivisibleBy(7) && isDivisibleBy(11);
        }

        public bool isPrime()
        {
            int index;
            if (myNumber <= 1)
                return false;
            if (myNumber == 2)
                return true;

            for (index = 2; index <= ((int)Math.Sqrt(myNumber))+1; index++)
            {
                if(myNumber%index== 0) return false;
            }
            return true;
            
        }
    }
}
