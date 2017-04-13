/*
 * Lab Assignment for IS412 Week 2
 * Lab 2 
 * - Accept a string and replaces all instances of the string false with true.
 * 
 * Brian Scarlett * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scarlett_Wk2_Lab2_IS412
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables
            string myString;

            // User enter sentence containing the word "false"
            Console.WriteLine("Enter a sentence: ");
            myString = Console.ReadLine();

            // Convert all to lower case
            myString = myString.ToLower();

            // Replace all instances of "false" with "true"
            myString = myString.Replace("false", "true");
                        
            // Print result
            Console.WriteLine($"Replaced \"false\" with \"true\": {myString}");
            
            // System pause
            Console.ReadKey();

        }
    }
}
