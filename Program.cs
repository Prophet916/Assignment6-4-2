using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6_4_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * You are building a library management system for your school library. As part of the system, 
             * you need to implement a search functionality that allows users to find a book by its unique 
             * ISBN number. To achieve this, you decide to write a C# program that performs a binary search 
             * on an array of ISBN numbers. Sort the array / list by using in built sort functions.
             */

            // Sample ISBN numbers (you can replace this with actual data)
            string[] isbnNumbers = { "9780451524935", "9780061122415", "9780439554930", "9781408855652", "9780743273565" };

            // Prompt user to enter the ISBN number to search for
            Console.Write("Enter the ISBN number to search (without dashes): ");
            string searchISBN = Console.ReadLine();

            // Sort the array of ISBN numbers
            Array.Sort(isbnNumbers);

            // Perform binary search to find the book by its ISBN
            int foundIndex = Array.BinarySearch(isbnNumbers, searchISBN);

            // Check if the book was found or not
            if (foundIndex >= 0)
            {
                // Display the book's details (you can extend this with more book information)
                Console.WriteLine("Book ISBN: " + isbnNumbers[foundIndex]);
                // Add more book details here if needed
            }
            else
            {
                Console.WriteLine("Book with ISBN " + searchISBN + " not found.");
            }
            Console.ReadKey();
        }
    }
}
