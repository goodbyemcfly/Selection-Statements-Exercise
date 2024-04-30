using System.Runtime.InteropServices;

namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {

            // Assignment #1

            int favNumber = 13;
            int userInput = 0;
            Console.WriteLine("Hello! Can you guess my favorite number?");

            while (userInput != favNumber)
            {
                Console.WriteLine("Input your guess here(hint: it's between 1 and 100)");
                userInput = int.Parse(Console.ReadLine());
                if (userInput > favNumber)
                {
                    Console.WriteLine("Too high, please guess again");
                }
                else if (userInput < favNumber)
                {
                    Console.WriteLine("Too low, please guess again");
                }
            }
            if (userInput == favNumber)
            {
                Console.WriteLine($"Congratulations! {userInput} is correct!");
            }
        }
    }
}
