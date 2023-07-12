using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 101);

        //Console.Write("What is my magic number?");
        //int number = int.Parse(Console.ReadLine());

        //Console.Write("Guess my magic number:");
        int guess = -1;

        while (guess != number)
        {

            Console.Write("Guess my magic number:");
            guess = int.Parse(Console.ReadLine());

            string answer = "";

            if (guess > number)
            {
                answer = "Lower";
            }
            else if (guess < number)
            {
                answer = "Higher";
            }
            else if (guess == number)
            {
                answer = "You guessed it!";
            }
            else
            {
                answer = "Please enter an integer";
            }

            Console.WriteLine(answer);
        }

    }
}