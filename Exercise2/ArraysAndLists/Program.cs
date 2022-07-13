using System;
using System.Collections.Generic;
namespace ArraysAndLists
{
    class Program
    {

        static void Main(string[] args)
        {
            //TODO:

            // Create an int Array and populate numbers 1-10
            int[] numbersarray = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10,};
            /* Create two Lists of type int.
             * Name one List "evens"
             * Name the other List "odds"
             */

            var even = new List<int>();
            var odd = new List<int>();

            /* Using either a foreach or for loop,
             * nest an if statement to check to see
             *  if a number is even or odd.
             * Then add those numbers to either the evens List
             * or the odds List
             */
            for (int number = 0; number < numbersarray.Length + 1; number++)
            {
                if (number % 2 == 0) 
                {
                    even.Add(number); 
                }
                else if (number % 2 == 1)
                {
                    odd.Add(number);
                }
            }

            /* Now using foreach or for loops,
             * display each List of even and odd numbers
             *
             * Try to be creative in your display
             */
            Console.WriteLine("These Numbers are even.");
            foreach (var number in even)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("These Numbers are odd.");
            foreach (var number in odd)
            {
                Console.WriteLine(number);
            }
        }
    }
}
