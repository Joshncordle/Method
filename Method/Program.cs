// Author: Joshua Cordle
// Date: 1/31/2019
// Comments: Using a method, print a greeting the user using their name
using System;

namespace Method
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ask for user input
            Console.WriteLine("Please enter your name");

            //Use try-catch block to confirm user enters data correctly
            try
            {
                //Read user input
                string user_input = Console.ReadLine();

                //Use pring greeting method to print greeting to user
                Print_Greeting(user_input);

                //End the program
                Console.WriteLine("press any key to exit the program...");
                Console.ReadKey(true);
            }
            
            //Recall catch to end program if wrong data type entered
            catch
            {
                Console.WriteLine("Please only enter your name...");
                Console.WriteLine("press any key to exit the program...");
                Console.ReadKey(true);
            }
        }

        //create custom method to print greeting to a user 
        private static void Print_Greeting(string user_input)
        {
            //Print greeting to user
            Console.WriteLine(" ");
            Console.WriteLine("Hello " + user_input);
        }
    }
}
