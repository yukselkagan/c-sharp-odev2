using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace question1
{
    class Program
    {
        static void Main(string[] args)
        {



            int inputCount = 20;

            ArrayList primeNumberList = new ArrayList();
            ArrayList nonPrimeNumberList = new ArrayList();




            Console.WriteLine($"Enter 20 number");


            for(int i=1; i <= inputCount; i++)
            {

                if (int.TryParse(Console.ReadLine(), out int newNumber))
                {
                    if(newNumber > 0)
                    {
                        if (IsPrimeNumber(newNumber))
                        {
                            primeNumberList.Add(newNumber);
                        }
                        else
                        {
                            nonPrimeNumberList.Add(newNumber);
                        }

                    }
                    else
                    {
                        Console.WriteLine("Need positive number");
                    }

                }
                else
                {
                    Console.WriteLine("Need numeric input");
                }
            }

            Console.WriteLine("");


            Console.WriteLine("Prime Numbers: ");
            List<int> listForAverage = primeNumberList.Cast<int>().ToList();
            Console.WriteLine($"Number of elements: {primeNumberList.Count}");
            Console.WriteLine($"Average of elements: {listForAverage.Average()}");

            primeNumberList.Sort();
            Console.WriteLine("List elements: ");
            foreach (var item in primeNumberList)
            {
                Console.WriteLine(item);
            }


            Console.WriteLine("");


            Console.WriteLine("Non Prime Numbers: ");
            listForAverage = nonPrimeNumberList.Cast<int>().ToList();
            Console.WriteLine($"Number of elements: {nonPrimeNumberList.Count}");
            Console.WriteLine($"Average of elements: {listForAverage.Average()}");

            Console.WriteLine("List elements: ");
            foreach (var item in nonPrimeNumberList)
            {
                Console.WriteLine(item);
            }













        }



        public static bool IsPrimeNumber(int number)
        {
            if(number == 1 || number == 2) { return false; }


            for (int i = 2; i < number; i++)
            {
                if ((number % i) == 0)
                {
                    return false;
                }
            }
            return true;




        }







    }
}
