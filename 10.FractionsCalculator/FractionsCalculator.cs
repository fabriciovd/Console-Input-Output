using System;


class FractionsCalculator
{
    static void Main()
    {
        Console.Title = "Fractor calculator";
        decimal a = 1, fr = 1, sum = 1;
        Console.Write("How many fractions do you want to sum: ");
        decimal b = decimal.Parse(Console.ReadLine());
        {
            for (decimal c = 2; c <= b; c++)
                if (c % 2 == 0)
                {
                    fr = a / c;
                    sum += fr;
                }
                else
                {
                    fr = (a / c) * (-1);
                    sum += fr;
                }
            Console.WriteLine("Total Sum is : {0:0.000}", sum);
        }
    }
}
