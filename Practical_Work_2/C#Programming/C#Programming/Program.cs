using System;
using System.Reflection.Metadata.Ecma335;
using C_Programming.Classes;
using C_Programming.Enums;

namespace WorkingWithClasses
{
    internal class Program
    {

        static void Main(String[] args)
        {
            Students student = new Students();

            Console.Write("FirstName: ");
            string firstname = Console.ReadLine();

            Console.Write("LastName: ");
            string lastname = Console.ReadLine();

            Console.Write("Age: ");
            int age = int.Parse(Console.ReadLine());

            student.FirstName = firstname;
            student.LastName = lastname;
            student.Age = age;

            Console.WriteLine($"New Student {student.FirstName} {student.LastName}, {student.Age} Years old is created");

            Train train = new Train(amountOfSoldTickets: 10, ticketsPrice: 50);

            train.setNumberOfPassengers(10);
            train.SetNumbersOfCarriage(2);

            int profit = train.CalculateProfit();

            Console.WriteLine($"Profit is {profit}");

        }

        #region Classes

        public class Person
        {
            public string Name { get; set; }

            public Person(string name)
            {
                Name = name;
            }

            public override string ToString()
            {
                return $"Hello! My name is {Name}";
            }

            ~Person()
            {
                Name = String.Empty;
            }
        }

        #endregion


    }
}