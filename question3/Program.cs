using System;
using System.Collections.Generic;
using System.Linq;

namespace question3
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter a sentence");
            string sentence = Console.ReadLine();


            char[] vowels = { 'a', 'e', 'i', 'ı', 'o', 'ö', 'u', 'ü' };
            List<char> vowelsAtSentence = new List<char>();


            for(int i=0; i < sentence.Length; i++)
            {
                if (vowels.Contains( sentence[i] ))
                {
                    vowelsAtSentence.Add(sentence[i]);
                }
            }




            foreach(var item in vowelsAtSentence)
            {
                Console.WriteLine(item);
            }






        }
    }
}
