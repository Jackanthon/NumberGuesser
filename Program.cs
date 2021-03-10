using System;


namespace NumberGuesser
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int guess;
            int guesses = 0;
            int num = random.Next(100);
            Console.WriteLine("Guess a number 1-100");
            
            for (int i = 0; i < 100; i++)
            {
                guess = Convert.ToInt32(Console.ReadLine());
                if (guess > 0 || guess < 100)
                {
                    if (guess > num)
                    {
                        Console.WriteLine("Too high");
                        Console.WriteLine("Your guess: " + guess);
                        guesses++;
                    }
                    else if (guess < num)
                    {
                        Console.WriteLine("Too low");
                        Console.WriteLine("Your guess: " + guess);
                        guesses++;
                    }
                    else if (guess == num)
                    {
                        Console.WriteLine("Correct!!!!!!!");
                        guesses++;
                        Console.WriteLine("Guessed taken: " + guesses);
                        return;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid Number");
                    return;
                }

            }


        }
    }
}
