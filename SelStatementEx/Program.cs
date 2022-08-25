using System;

namespace SelStatementEx
{ 
    internal class Program
    {
        static void Main(string[] args)
        {
            //int favNumber = 13;

            //Console.WriteLine("Guess my favorite number. Hint: It is between 1 and 20.");
            //int userGuess = int.Parse(Console.ReadLine());

            //if (userGuess < favNumber)
            //{
            //Console.WriteLine("Too low. Try again!");
            //}
            //else if (userGuess > favNumber)
            //{
            //Console.WriteLine("Too high. Try again!");
            //}
            //else if (userGuess == favNumber)
            //{
            //Console.WriteLine("You guessed it! You have earned one ice cream cone.");
            //}
            //else
            //{
            //Console.WriteLine("Nevermind. Our machine is broken.");
            //}

            string subject = "physics";

            Console.WriteLine("Choose a branch of science.");
            string userSubject = Console.ReadLine();

            switch (userSubject)
            {

                case "physics":
                    Console.WriteLine("You chose the best branch!");
                    break;
                case "biology":
                    Console.WriteLine("Physics is better than biology");
                    break;
                case "chemistry":
                    Console.WriteLine("An honorable second place to physics.");
                    break;
                case "botany":
                    Console.WriteLine("An unusual choice, but a very good one.");
                    break;
                case "geology":
                    Console.WriteLine("A rare choice but a respectable one.");
                    break;
                default:
                    Console.WriteLine("My favorite branch is physics.");
                    break;
            }

        }
    }
}

