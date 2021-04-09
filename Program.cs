using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Hash_Tutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            string secretWord = "Western";
            string guessWord = "";
            int guessCount = 0;
            int guessLimit = 5;
            bool outOfGuesses = false;


            while(guessWord != secretWord && !outOfGuesses)
            {
                if (guessCount < guessLimit)
                {
                    Console.Write("Enter guess: ");
                    guessWord = Console.ReadLine();
                    guessCount++;
                }
                else
                {
                    outOfGuesses = true;
                }
            }

            if (outOfGuesses)
            {
                Console.Write("Guess Limit Reached! You Lose. :(");
            }
            else
            {
                Console.Write("You found the secret word! You win!!!");
            }
            Console.ReadLine();
        }
    }
}
    