using System;
using System.Linq;

namespace question2
{
    class Program
    {
        static void Main(string[] args)
        {

            int inputCount = 20;


            int[] numberArray = new int[inputCount];
            int[] highestNumbers = new int[3];
            int[] lowestNumbers = new int[3];


            Console.WriteLine($"Enter {inputCount} number");

            for(int i = 0; i < inputCount; i++)
            {
                numberArray[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("");


            Array.Sort(numberArray);
            foreach (var item in numberArray)
            {
                //Console.WriteLine(item);
            }


            for(int i=0; i < 3; i++)
            {
                lowestNumbers[i] = numberArray[i];
            }
            for (int i = 0; i < 3; i++)
            {
                highestNumbers[i] = numberArray[inputCount-1-i];
            }


            int lowestNumbersAverage = lowestNumbers.Sum() / lowestNumbers.Length;
            int highestNumbersAverage = highestNumbers.Sum() / highestNumbers.Length;
            

            Console.WriteLine($"Lowest numbers average: {lowestNumbersAverage}");
            Console.WriteLine($"Highest numbers average: {highestNumbersAverage}");


            Console.WriteLine($"Sum of averages: {lowestNumbersAverage+highestNumbersAverage}");
















        }
    }
}
