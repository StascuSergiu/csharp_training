// See https://aka.ms/new-console-template for more information
using CSharpTrainingConsoleApp;

for(; ; )
{
    Console.WriteLine("Choose exercise, from 1 to 7, 100 to exit:");
    int exerciceNumber= int.Parse( Console.ReadLine() );
    Console.WriteLine("Exercice "+ exerciceNumber);

    switch (exerciceNumber)
    {
        case 1:
            Console.WriteLine("Give a number to check if it is divisible by 7 and 11:");
            Number number = new Number(int.Parse(Console.ReadLine()));
            Console.WriteLine(number.isDivisibleBy7and11().ToString());
            break;

        case 2:
            Console.WriteLine("Give an year to check if it is leap");
            Year year = new Year(int.Parse(Console.ReadLine()));
            Console.WriteLine(year.isLeap().ToString());
            break;

        case 3:
            Console.WriteLine("47th prime number is :");
            Number number1 = new Number(0);
            int index = 0;
            while (index!=47)
            {
                number1.myNumber++;
                if (number1.isPrime())
                {
                    index++;
                }
            }
            Console.WriteLine(number1.myNumber.ToString());
            break;
        case 100: return;

        default: Console.WriteLine("Invalid execise number!!!"); break;
     

    }
    
}

