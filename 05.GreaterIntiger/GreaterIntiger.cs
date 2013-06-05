/*Write a program that gets two numbers from the console and prints the greater of them. Don’t use if statements.
*/
using System;


class GreaterIntiger
    {
        static void Main()
        {
            Console.Title = "Which is greater";
            Console.WriteLine(Convert.ToString("Which is greather\r\n").PadLeft(48,' '));
            Console.WriteLine("Insert number A to compare:");
            decimal a = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Next insert number B:");
            decimal b = decimal.Parse(Console.ReadLine());
            Console.WriteLine("The greater number is: "+(Math.Max(a,b)));
        }
    }
