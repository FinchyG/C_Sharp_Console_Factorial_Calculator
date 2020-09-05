using System;

namespace FactorialCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            bool endProgram = false;

            while (!endProgram)
            {
                Console.WriteLine("Please enter a whole number");
                string userInput = Console.ReadLine();

                while(!Int16.TryParse(userInput, out Int16 x))
                {
                    Console.WriteLine("You must input a whole number:");
                    userInput = Console.ReadLine();
                }

                Int16 userNum = Convert.ToInt16(userInput);
                Int16 factorial = 1;

                while (userNum > 1)
                {
                    factorial *= userNum;
                    userNum -= 1;
                }

                Console.WriteLine("The factorial of {0} is {1}", userInput, factorial);

                Console.WriteLine("Press q to quit program or any other key to calculate another factorial:");
                string keyPress = Console.ReadLine().ToLower();

                if (keyPress == "q")
                {
                    endProgram = true;
                }
            }
        }
    }
}
