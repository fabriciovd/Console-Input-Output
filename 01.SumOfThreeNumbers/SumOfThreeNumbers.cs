/*Write a program that reads 3 integer numbers from the console and prints their sum.
*/
using System;


    class SumOfThreeNumbers
    {
        static void Main()
        {
            Console.Title = "Sum calculator";
            Console.WriteLine("Insert Three numbers to sum\r\n|");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("+");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("+");
            int c = int.Parse(Console.ReadLine());
            int sum =(a+ b+ c);
            Console.WriteLine("{0} is total sum",sum);
        }
    }
