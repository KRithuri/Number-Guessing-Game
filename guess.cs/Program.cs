using System;
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
            int[] attempt_list = new int[10];
            int attempts = 0;

            int returnvalue = random.Next(1, 10);

            Console.WriteLine(" Guess a number between 1 to 10 ");
            int response = Convert.ToInt32(Console.ReadLine());

            while (response > returnvalue)
            {
                Console.WriteLine($"No the number is low than {response} try again !");
                response = Convert.ToInt32(Console.ReadLine());

                attempts += 1;
            }

            while (response < returnvalue)
            {
                Console.WriteLine($"No the number is high than {response} try again !");
                response = Convert.ToInt32(Console.ReadLine());
                attempts += 1;
            }

            while (response != returnvalue)
            {
                Console.WriteLine($" wrong answer {response} is not the good response try again !");
                response = Convert.ToInt32(Console.ReadLine());
                attempts += 1;
            }

            Console.WriteLine($"Good ! Its  {returnvalue}");
            attempts += 1;
            Console.WriteLine($"It took {attempts} attempts!");
            attempt_list.Append(attempts);
            Console.ReadKey();
        }
    }
}
