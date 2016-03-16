using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment31516
{
    class Program
    {
        static void Main(string[] args)
        {
            //PART ONE

            //Create a program that asks the user to enter an integer. 
            //If the integer is less than 10, print the message "This number is too small".
            //If the integer is greater than or equal to 10, print "This number is big enough".
            Console.WriteLine("Greetings! Please enter an integer:");
            int userNumber = int.Parse(Console.ReadLine());
            if (userNumber < 10)
            {
                Console.WriteLine("This number is too small");
            }
            else if (userNumber >= 10)
            {
                Console.WriteLine("This number is big enough");
            }

            //PART TWO

            //Create a program that creates an array of five hard-coded floating-point values,
            // then prints out just the second value. 
            float[] arrayOfFiveNum = { 3.5F, 45.6F, 99.24F, 3.99F, 2.67F };
            Console.WriteLine(arrayOfFiveNum[1]);
            
            //PART THREE 

            //Modify the above program so that it uses a foreach loop to display 
            //all the values in the array, all on one line.
            float[] arrayOfFiveNum = { 3.5F, 45.6F, 99.24F, 3.99F, 2.67F };
            foreach (float fiveNum in arrayOfFiveNum)
            {
                Console.Write(fiveNum + " ");
            }
            //PART FOUR 

            //Write a program that asks the user to enter an integer. 
            //If the user enters '1', print "Only one?".
            //If the user enters '100', print "100? That's a lot!".
            //If the user enters something other than these two numbers, 
            //print "Input not recognized.".The program should use a switch statement.
            Console.WriteLine("Hi user, will you give me an integer?");
            int userInput = int.Parse(Console.ReadLine());
            switch (userInput)
            {
                case 1:
                    Console.WriteLine("Only one?");
                    break;
                case 100:
                    Console.WriteLine("100? That's a lot!");
                    break;
                default:
                    Console.WriteLine("Input not recognized.");
                    break;
            }
        }
        }
}
