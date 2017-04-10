/*
 * Lab Assignment for IS412 Week 2
 * Lab 1
 * 
 * Brian Scarlett * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scarlett_Wk2_Lab1_IS412
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables
            string YourName;
            string reversedString = "";

            Console.WriteLine("What is your name? ");
            YourName = Console.ReadLine();

            // Create array to print name backwards
            for(int i = YourName.Length -1; i >= 0; i--)
            {
                reversedString += YourName[i];
            }

            // Print name out backwards
            Console.WriteLine($"Hello { YourName}. Your name spelled backwards looks like: {reversedString}");

            // System pause
            Console.ReadKey();

        }
    }
}
