/*Write a program that gets a number n and after that gets more n numbers and calculates and prints their sum. 
*/
using System;


class NNumberCalculator
{
    static void Main()
    {
        Console.Title = "N Sum Calculator";
        Console.WriteLine("Two versions is present in this App\r\n");
        Console.WriteLine("1: This version is restricted by given exact how much numbers will calcualte.\r\n");
        Console.WriteLine("2: This version is for unlimited sum calculations.\r\n");
        Console.Write("Enter 1 or 2 for version: ");
        byte a = byte.Parse(Console.ReadLine());
        {
            if (a == 1)
            {
                //First Version
                int inputcount, sum = 0, n, count = 0;
                Console.Write("Insert how many number you want to calculate: ");
                inputcount = int.Parse(Console.ReadLine());
                {
                    for (count = 0; count < inputcount; count++)
                    {
                        Console.Write("\r\nInsert number {0} :", count + 1);
                        n = int.Parse(Console.ReadLine());
                        sum += n;
                    }
                }
                Console.WriteLine("\r\nTotal sum is: {0}", sum);
            }
            else if (a == 2)
            {

                //Second version
                int number1 = 0, sum1 = 0;
                while (true)
                {
                    number1 = int.Parse(Console.ReadLine());
                    sum1 += (int)number1;
                    Console.WriteLine("The Sum is {0}", sum1);
                }
            }
        }
    }
}