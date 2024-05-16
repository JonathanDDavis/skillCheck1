using System;

namespace Skill_Check_1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool newgame = true;
            while (newgame == true)
            {
                running.askingQuestions();
                running.numberGame();
                Console.WriteLine("Do you want to go through these again?");
                string reply = Console.ReadLine();
                if (reply == "yes")
                    Console.WriteLine("okay");

                else if (reply == "no")
                {
                    Console.WriteLine("Have a good day");
                    newgame = false;
                }

                else
                {
                    Console.WriteLine("That is an invalid input");
                }
            }
        }
    }

    class running
    {
        public static string askingQuestions()
        {
             Console.WriteLine("Hello, what is your name?");
                string username = Console.ReadLine();
                Console.WriteLine("What is your age?");
                int userage = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Are you alive?");
                bool alive = false;
                string alivecheck = Console.ReadLine();
                if (alivecheck == "yes")
                {
                    Console.WriteLine("Okay");
                    alive = true;
                }

                else if (alivecheck == "no")
                    Console.WriteLine("That's probably not good. You might want to go check that out.");

                else
                {
                    Console.WriteLine("That is an invalid input");
                }

                Console.WriteLine("Hello {0}, you are {1} years old and your are alive {2}.", username, userage, alive);

                return "";
        }

        public static string numberGame()
        {
            int[] mynumb = { 42, 24, 64 };
            int[] randomnum = new int[3];
            Console.WriteLine("List 3 random numbers.");
            int randomnum1 = Int32.Parse(Console.ReadLine());
            randomnum[0] = randomnum1;

            Console.WriteLine("Just 2 more numbers.");
            int randomnum2 = Int32.Parse(Console.ReadLine());
            randomnum[1] = randomnum2;

            Console.WriteLine("Just 1 more numbers.");
            int randomnum3 = Int32.Parse(Console.ReadLine());
            randomnum[2] = randomnum3;

            Console.WriteLine("Your random numbers are {0}, {1}, {2}", randomnum[0], randomnum[1], randomnum[2]);
            Console.ReadLine();

            Console.WriteLine("My random numbers were {0}, {1}, {2} ", mynumb[0], mynumb[1], mynumb[2]);

            return "";
        }

    }
}
