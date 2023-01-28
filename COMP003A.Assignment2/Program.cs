// Author: Jaime Garcia
// Course: COMP003A
// Purpose: strings and math assignment week 2

using System.Transactions;

namespace COMP003A.Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "COMP-003A - Assignment 2";
            Console.BackgroundColor= ConsoleColor.DarkBlue;
            Console.ForegroundColor= ConsoleColor.White;

            //////CONSOLE SECTION UP TOP
            Console.WriteLine("********************" +
                "Console Section" +
                "**************************");

            Console.WriteLine("");


            ///// STRING
            Console.WriteLine("*************************" +
                "String Section" +
                "******************");
            Console.WriteLine("Enter first name:");
            string firstName = Console.ReadLine();
            
            Console.WriteLine("Enter middle name:");
            string middleName = Console.ReadLine();
            
            Console.WriteLine("Enter last name:");
            string lastName = Console.ReadLine();
            
            Console.WriteLine("Enter age in 2023:");
            string inputAge = Console.ReadLine();
            
            int yearBorn = 2023 - Convert.ToInt32(inputAge);

            Console.WriteLine($"Hello, {firstName} {middleName} {lastName}. You were born in {yearBorn}.");


            ////////////////////// /   Math Section /////////
            Console.WriteLine("");

            Console.WriteLine("****************" +
                "Math Section" +
                "************************");

            Console.WriteLine("Enter an integer for integer1:");
            int integer1 = Convert.ToInt32(Console.ReadLine());
         
            

           Console.WriteLine("Enter an integer for integer2"); 
            int integer2 = Convert.ToInt32(Console.ReadLine());
            
         
            Console.WriteLine($"{integer1} + {integer2} = {integer1 + integer2}");
            Console.WriteLine($"{integer1} - {integer2} = {integer1 - integer2}");
            Console.WriteLine($"{integer1} * {integer2} = {integer1 * integer2}");
            Console.WriteLine($"{integer1} / {integer2} = {integer1 / integer2}");
            Console.WriteLine($"{integer1} % {integer2} = {integer1 % integer2}");

          //////////// Circle Area and Circumference Calculator Section
          Console.WriteLine("");

            Console.WriteLine("***************" +
                "Circle Area & Circumference Calculator Section" +
                "**********************");

            Console.WriteLine("Enter radius:");
            
            double radius = Convert.ToDouble(Console.ReadLine());

            double area = Math.PI * Math.Pow(radius, 2);

            double circumference = 2 * Math.PI * radius;

            Console.WriteLine($"The area is:{area}");
            Console.WriteLine($"The circumference is:{circumference}");


        
        
        }
    }
}