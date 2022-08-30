using System;
using System.Collections.Generic;
using System.IO;

namespace ExceptionHandlingExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //DONE -----------------------------------------------------------------------------
            // First create an char[], it must contain 6 numbers and 3 letters - name it arr
            char[] arr = new char[] { '1', '1', '0', '7', '0', '8', 'N', 'O', 'V' };

            //DONE Create a list called numbers that will hold integers
            var numbers = new List<int>();

            //DONE Create an string variable with an empty string initializer - name it str
            string str;

            // using a foreach loop, attempt to parse the elements in your char[] with int.Parse()
            // and Exceptions will be thrown 
            // Below we will set this up 
            // ------------------------------------------------------------------------------


            foreach (var item in arr)
            {
                try
                {
                    str = item.ToString();
                    int number = int.Parse(str);
                    numbers.Add(number);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message); //gives us a general message
                    Console.WriteLine(ex.GetType()); //tell us what kind of exception we have 
                    Console.WriteLine($"Unable to Parse '{item}'"); //custom message
                    Console.WriteLine();
                }
            }



            foreach (var num in numbers)
            {
                Console.WriteLine(num);
            }
        }
    }
}
