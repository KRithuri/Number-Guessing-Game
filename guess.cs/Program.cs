using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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

            int randomNumber = random.Next(1, 10);

            Console.WriteLine("Hello user! Welcome to the number guessing game!");
            Console.Write("What is your name? ");
            string player_name = Console.ReadLine();
            Console.WriteLine($"Hi {player_name}, would you like to play the guessing game? (Y-yes or N-no): ");
            string play_option = Console.ReadLine();

            //code to run if user chooses no
            if(play_option.ToLower() != "y")
            {
                Console.WriteLine("That is cool. Thanks!");
                Console.ReadKey();
            }
            //code to run if user chooses yes
            else
            {
                //check if attempt array has elements
                if(attempt_list == null || attempt_list.Length == 0)
                {
                    Console.WriteLine("There is currently no high score. It is yours for the taking!");
                }
                else
                {
                    
                    Console.WriteLine($"The current score if {attempt_list[1]} attempts");
                }
                    
                //ask user to guess
                Console.Write(" Guess a number between 1 to 10: ");
                int response = Convert.ToInt32(Console.ReadLine());

                //loop to run if response is greater than random number
                while (response > randomNumber){
                    Console.Write($"No the number is low than {response} try again: ");
                    response = Convert.ToInt32(Console.ReadLine());
                    //increment attempts
                    attempts += 1;
                }
                //loop to run if response is less than random number
                while (response < randomNumber){
                    Console.Write($"No the number is high than {response} try again: ");
                    response = Convert.ToInt32(Console.ReadLine());
                    attempts += 1; //increment attempts
                }
                        //loop to run if response is not equal to random number
                while (response != randomNumber){
                    Console.Write($" wrong answer {response} is not the good response try again: ");
                    response = Convert.ToInt32(Console.ReadLine());
                    attempts += 1; //increment attempts
                }
                 //code to run if attempt is equal to random number
                Console.WriteLine();
                        
                        
                Console.WriteLine($"Good ! Its  {randomNumber}");
                attempts += 1; //increment attempts

                 //display results to user 
                Console.WriteLine($"It took {attempts} attempts!");
                Console.WriteLine("Thank you for playing...!");
                attempt_list.Append(attempts);
                Console.ReadKey();
               
               
            }
           
        }
    }
}
