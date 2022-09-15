using System;

namespace SelectionStatementsExercise
{
    class Program
    {
        static void Main(string[] args)
        {

            var random = new Random();

            var faveNumber = random.Next(1, 1000);
            int response;
            Console.WriteLine("Let's see if you can guess my favorite number.");
            do

            {
                //ask user to guess favorite number
                Console.WriteLine("Enter your guess: ");
                response = int.Parse(Console.ReadLine());

                if (response < faveNumber)
                {
                    Console.WriteLine("Nope, that's too low! Try again.");
                }

                else if (response > faveNumber)
                {
                    Console.WriteLine("Nope, that's too high! Try again.");
                }
                else
                {
                    Console.WriteLine("Yes, that's correct!");
                }

            } while (response != faveNumber);


            //ask user for favorite subject
            Console.WriteLine("What is your favorite school subject?");
            var subject = Console.ReadLine();

            switch (subject.ToLower())
            {
                case "English":
                    Console.WriteLine("English is cool!");
                    break;
                case "Math":
                    Console.WriteLine("I like Math!");
                    break;
                case "Science":
                    Console.WriteLine("Science is fun!");
                    break;
                case "History":
                    Console.WriteLine("History is great!");
                    break;
                case "Social Studies":
                    Console.WriteLine("Social studies is a must!");
                    break;
                default:
                    Console.WriteLine("Oh, I never took that before.");
                    break;
            }
        }
    }
}