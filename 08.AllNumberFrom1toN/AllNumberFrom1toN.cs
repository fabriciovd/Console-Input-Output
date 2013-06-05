/*Write a program that reads an integer number n from the console and prints 
 * all the numbers in the interval [1..n], each on a single line.
*/
using System;


class AllNumberFromOnetoN
{
    static void Main()
    {
        Console.Title = "1 to n priter";
        Console.Write("Insert a number bigger than 0 to start: ");
        int n, counter;
        n = int.Parse(Console.ReadLine());
        for (counter = 1; counter <= n;)
        {
            Console.WriteLine("{0} ",counter);
            counter++;
        }
    }
}
