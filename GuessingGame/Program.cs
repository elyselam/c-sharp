using System;

namespace GuessingGame {
    class Program {
        static void Main(string[] args) {
            string secretWord = "louie";
            string guess = "";
            int guessCount = 0;
            int guessLimit = 3;
            bool outOfGuesses = false;

            while (guess != secretWord && !outOfGuesses) {
                if (guessCount < guessLimit) {

                    Console.Write("enter guess: ");
                    guess = Console.ReadLine();
                    guessCount++;
                } else {
                    outOfGuesses = true; //boolean flags
                }
            }
            if (outOfGuesses) {
                Console.Write("you lose!")
            }
            Console.Write("you got it! Woof woof!")
        }
    }
}