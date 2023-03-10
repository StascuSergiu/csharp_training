using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTrainingConsoleApp
{
    internal class NumberArray
    {
        public List<int> list;

        public NumberArray()
        {
            list = new List<int>();
        }

        public void generateListFromRandomNElements(int numberOfElements)
        {
            Random rnd = new Random();
            int index;
            for(index = 0; index < numberOfElements; index++)
            {
                list.Add(rnd.Next(0,100));
            }  
        }

        public int getMax()
        {
            int max = 0;

            foreach (int element in list)
            {
                if (element > max)
                {
                    max = element;
                }
              
            }
            return max;
        }

        public int getSecondLargestElement()
        {
            int secondLargest = 0;
            int max = getMax();

            foreach (int element in list)
            {
               
                if((element > secondLargest)&&(element != max))
                {
                    secondLargest = element;    
                }
            }
            return secondLargest;
        }
    }
}
