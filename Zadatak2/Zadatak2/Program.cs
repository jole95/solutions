using System;
using System.Linq;

namespace Zadatak2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input:");
            string input = String.Join("", Console.ReadLine().Where(c => char.IsLetter(c))).Trim().ToLower(); // filtriraj samo slova
            string reversedInput = new string(input.Reverse().ToArray());

            if (input == reversedInput)
                Console.WriteLine("Output: Palindrom");
            else
                Console.WriteLine("Output: Nije palindrom");

           
            Console.ReadKey();
        }
    }
}
