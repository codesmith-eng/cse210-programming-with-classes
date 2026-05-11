using System;

class Program
{
    static void Main(string[] args)
    {
        //creating a random class for the computer to pick any number randomly from 0 - 100 just like ramdom.randit in python
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 100);

        //declaring an initial variable for guess
        int guess = 0;

        //variable for counting number of guesses
        int guessCount = 0;

        Console.WriteLine("Welcome to the Guess Game");
        Console.WriteLine("");

        while (guess != number)
        {
            Console.Write("Your Guess? ");
            string myGuess = Console.ReadLine();

            //There is no need to put int before guess here because guess has been declared an integer at the top outside while loop
            guess = int.Parse(myGuess);

            guessCount += 1;

            if (number > guess)
            {
                Console.WriteLine("Higher");
            }

            else if (guess > number)
            {
                Console.WriteLine("Lower");
            }

            else
            {
                Console.WriteLine("You Guess right");
            }
        }
        Console.WriteLine($"Your Number of Guesses are {guessCount}");

        Console.WriteLine("Thanks for Playing, Goodbye!!!");
    }

}