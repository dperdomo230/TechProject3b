/* 
    Author: Daniel Perdomo
    Date: 15 September 2020
    Comments: This C# console application demonstrates the use of a manually populated array, 
    and a foreach loop that iterates through the array. No user input is required.
*/
using System;

namespace TechProject3b
{
    class Program
    {
        static void Main(string[] args)
        {
            // This is an array with manually populated values.
            int[] numbers = { 1, 2, 3, 4, 5, 6 , 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25 };

            // Here is the foreach loop that iterates through the array.
            foreach(int i in numbers)
            {
                // This line displays all of the values present in the numbers array 
                Console.WriteLine("Element value = " + i);
            }
            Console.WriteLine("Press any key to exit the program.");
            // Pause the program and await the user to press a key to end the program
            Console.ReadKey(true);
        } // End of main
    } // End of class
} // End of namespace
