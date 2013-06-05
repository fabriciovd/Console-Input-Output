/*Write a program that reads two positive integer numbers and prints how many numbers p 
 * exist between them such that the reminder of the division by 5 is 0 (inclusive). 
 * Example: p(17,25) = 2.
*/
using System;


class TwoIntsDivedByFive
{
    static void Main(string[] args)
    {
        Console.Title = "How many numbers divaded by 5 are in between";
        Console.WriteLine("Insert positive number A:");
        uint a = uint.Parse(Console.ReadLine());
        Console.WriteLine("Insert positive number B greater than A:");
        uint b = uint.Parse(Console.ReadLine());
        if (a > b)
        {
            Console.WriteLine("The condition is incomplete: {0} is greater than {1}\r\n\n\rPlease Restart the app\r\n\r\n", a, b);
        }
        else
        {
            uint p = 0;
            while (a != b + 1)
            {
                {
                    if (a % 5 == 0)
                    {
                        p++;
                    }
                }
                a++;
            }
            Console.WriteLine(p);
        }
    }
}
