using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int mystery_number = randomGenerator.Next(1, 101);

        int guess = -1;

        while (guess != mystery_number)
        {
            Console.Write("Guess the mystery number: ");
            guess = int.Parse(Console.ReadLine());

            if (mystery_number > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (mystery_number < guess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You got it!");
            }

        }                    
    }
}