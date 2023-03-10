using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTrainingConsoleApp
{
    public class Number
    {
        private int decRepresentation;
        private String binaryRepresentation;
       
        public Number(int myNumber)
        {
            this.decRepresentation = myNumber;
            this.binaryRepresentation = convertIntBinaryFromDec();
        }

        public Number(String binaryRepresentation)
        {
            this.binaryRepresentation = binaryRepresentation;
            this.decRepresentation = convertInDecFromBinary();
        }


        public int getDecRepresenatation()
        {
            return decRepresentation;
        }

        public String getBinaryRepresentation()
        {
            return binaryRepresentation;    
        }

        public bool isDivisibleBy(int divisor) 
        {
            return decRepresentation % divisor == 0; 
        }

        public bool isDivisibleBy7and11()
        {
            return isDivisibleBy(7) && isDivisibleBy(11);
        }

        public bool isPrime()
        {
            int index;
            if (decRepresentation <= 1)
                return false;
            if (decRepresentation == 2)
                return true;

            for (index = 2; index <= ((int)Math.Sqrt(decRepresentation))+1; index++)
            {
                if(decRepresentation%index== 0) return false;
            }
            return true;
        }

        public void setAstPrimeByIndex(int primeIndex)
        {
            int actualPrimeIndex = 0;
            while (actualPrimeIndex != primeIndex)
            {
                decRepresentation++;
                if (isPrime())
                {
                    actualPrimeIndex++;
                }
            }
        }

        public int getSumOfDigits()
        {
            int sum = 0;
            int aux = decRepresentation;
            while (aux != 0)
            {
                sum += aux % 10;
                aux = (int)aux / 10;
            }
            return sum;
        }


        public int convertInDecFromBinary()
        {
            double poz = 0;
            int decValue = 0;

            char[] auxiliatCharArray = binaryRepresentation.ToCharArray();
            Array.Reverse(auxiliatCharArray);
            foreach(char c in auxiliatCharArray)
            {
                decValue += ((int)c - 0x30)* (int)Math.Pow(2.0,poz++);
            }

            return decValue;
        }

        public string convertIntBinaryFromDec()
        {
            string auxCharArray = "";
            int aux = decRepresentation;
            while (aux != 0)
            {
                
                auxCharArray += (aux%2).ToString();
                aux = aux / 2;
            }
            auxCharArray.Reverse();
            return auxCharArray;
        }
    }
}
