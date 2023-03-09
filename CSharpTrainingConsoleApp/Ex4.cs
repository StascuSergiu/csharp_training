using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTrainingConsoleApp
{
    public class Fibonaci
    {
        public List<int> fibonaciList = new List<int>();

        public Fibonaci()
        {
            fibonaciList.Add(1);
            fibonaciList.Add(2);
        }

        public void addNextElement()
        {
            fibonaciList.Add(getNextElement());
            
        }

        public int getNextElement()
        {
            return fibonaciList.Last() + fibonaciList.ElementAt(fibonaciList.Count() - 2);
        }

        public int sumOfEvenUnder(int maxNumber)
        {
            int sum = 2;


            while (getNextElement() < maxNumber)
            {
                addNextElement();
                if (this.fibonaciList.Last() % 2 == 0)
                {
                    sum += this.fibonaciList.Last();
                }

            } 
            
            return sum;

        }
    }
}
