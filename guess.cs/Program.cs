﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace guess.cs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            start_game();

        }
        //function to play game
        static void start_game()
        {
            Random random = new Random();
            //create array to store number of attempts
            int[] attempt_list = new int[10];
            //variable to store attempts
            int attempts = 0;

            int returnvalue = random.Next(1, 10);

            //ask user to guess
            Console.WriteLine(" Guess a number between 1 to 10 ");
            int response = Convert.ToInt32(Console.ReadLine());

            //loop to run if response is greater than random number
            while (response > returnvalue)
            {
                Console.WriteLine($"No the number is low than {response} try again !");
                response = Convert.ToInt32(Console.ReadLine());
                //increment attempts
                attempts += 1;
            }
            //loop to run if response is less than random number
            while (response < returnvalue)
            {
                Console.WriteLine($"No the number is high than {response} try again !");
                response = Convert.ToInt32(Console.ReadLine());
                attempts += 1; //increment attempts
            }
            //loop to run if response is not equal to random number
            while (response != returnvalue)
            {
                Console.WriteLine($" wrong answer {response} is not the good response try again !");
                response = Convert.ToInt32(Console.ReadLine());
                attempts += 1; //increment attempts
            }
            //code to run if attempt is equal to random number
            Console.WriteLine($"Good ! Its  {returnvalue}");
            attempts += 1;
            Console.WriteLine($"It took {attempts} attempts!");
            attempt_list.Append(attempts);
            Console.ReadKey();
        }
    }
}
