using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangmanGame
{
    public class Program
    {
        static void Main(string[] args)
        {
            HangmanGame game = new HangmanGame();

            string word = game.GenerateWord();

            Console.WriteLine($"The word consists of {word.Length} letters.");
            Console.WriteLine("Try to quess the word.");

            while (game.GameStatus == GameStatus.InProgress)
            {
                Console.WriteLine("Pick a letter");
                char symbol = Console.ReadLine().ToCharArray()[0];

                string curState = game.GuessLetter(symbol);
                Console.WriteLine(curState);

                Console.WriteLine($"Remaining tries = {game.RemainingTries}");
                Console.WriteLine($"Tried letters: {game.TriedLetters}");
            }

                if (game.GameStatus == GameStatus.Lost)
                {
                    Console.WriteLine($"You're hanged.\nThe word was: {game.Word}");
                }
                else if (game.GameStatus == GameStatus.Won)
                {
                    Console.WriteLine($"You won!!!");
                }

                Console.ReadLine();
            
        }
    }
}
