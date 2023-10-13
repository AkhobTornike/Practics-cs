using System;

namespace PensionersValidation
{
    class checkPensioners
    {
        static void Main(string[] args)
        {
            int userAge;
            String userGender;
            int PensionerWemenAge = 65;
            int PensionerMenAge = 60;

            do
            {
                // Start Take Age
                Console.Write("Enter Your Age: ");
                var userInput = Console.ReadLine();

                if (int.TryParse(userInput, out userAge) )
                {
                    if (userAge > 0)
                    {
                        // Get Age
                        Console.WriteLine($"Entered: {userAge} years old.");
                        break;
                    }
                    else
                        Console.WriteLine("Age must be greater than 0. Please enter a valid age.");
                }
                else
                    Console.WriteLine("Invalid input. Please enter a valid age.");
            } while (true);


            // Start Take Gender
            do
            {
                Console.Write("Enter your gender (M/m for Male, F/f for Female): ");
                userGender = Console.ReadLine();

                if (userGender.Equals("M", StringComparison.OrdinalIgnoreCase) || userGender.Equals("Male", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Entered: Male");
                    userGender = "M";
                    break;
                }
                else if (userGender.Equals("F", StringComparison.OrdinalIgnoreCase) || userGender.Equals("Female", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Entered: Female");
                    userGender = "F";
                    break;
                }
                else
                    Console.WriteLine("Invalid input. Please enter a valid gender (M/m for Male, F/f for Female)!");
            } while (true);

            if (userGender.Equals("M"))
            {
                if (userAge >= PensionerMenAge)
                    Console.WriteLine("You are Pensioner");
                else
                    Console.WriteLine($"You need more {PensionerMenAge - userAge} Years to be a Pensioner");
            }
            else
            {
                if (userAge > PensionerWemenAge)
                    Console.WriteLine($"You need more {PensionerWemenAge - userAge} Years to be a Pensioner");
            }
        }
    }
}