using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionStatmentExercise
{
    internal class GuessTheNumber
    {
        public static void FavNumber() 
        {

            var favNumber = 29;
    
            while (true)
            {
                var userInput = int.Parse(Console.ReadLine());

                if (userInput < favNumber)
                {
                    Console.WriteLine("Come on. That is just too low. Please guess again.");
                }
                else if (userInput > favNumber)
                {
                    Console.WriteLine("Whoa there, you've gone waaaay to high. Why don't you give it another go?");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                    break;
                }
            }
            Console.ReadLine();
        }

    }
}
