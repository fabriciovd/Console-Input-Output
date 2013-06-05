/*Write a program to print the first 100 members of the sequence of 
 * Fibonacci: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, …
*/
using System;


class FibonacciNumbers
{
    static void Main()
    {
        Console.Title = "Fibonacci Numbers from 1 to 100";
        Console.WriteLine("For Fibonacci numbers from 1 to 100 press 1.\r\n");
        Console.WriteLine("For Fibonacci numbers from 1 to  N  press 2.\r\n");
        Console.Write("Your choise: ");
        byte n = byte.Parse(Console.ReadLine());
        if (n == 1)
        {
            decimal n1 = -1, n2 = 0, n3;
            for (int count = 0; count < 100; count++)
            {
                n3 = n1 + n2;
                n1 = n2;
                n2 = n3;
                Console.WriteLine("{1:d3}: {0}", n2 * -1, count + 1);
            }
        }
        else if (n==2)
        {
            Console.WriteLine("Insert number (max 139) for the max member in the sequence of Fibonacci to proseed");
            int c = int.Parse(Console.ReadLine());
            double n1 = -1, n2 = 0, n3;
            for (int count = 0; count < c; count++)
            {
                n3 = n1 + n2;
                n1 = n2;
                n2 = n3;
                Console.WriteLine("No:{1:000}: {0}", n2 * -1, count + 1);
            }
        }
    }
}
