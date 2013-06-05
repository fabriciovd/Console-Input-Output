/*Write a program that reads the coefficients a, b and c of 
 * a quadratic equation ax2+bx+c=0 and solves it (prints its real roots).
*/
using System;


class QuadraticEquation
{
    static void Main()
    {
        Console.Title = "Cuadratic Equation";
        Console.WriteLine(Convert.ToString("Cuadratic Equation Calculator").PadLeft(50,' '));
        Console.WriteLine("ax^2+bx+c=0");
        Console.WriteLine("Insert value for A different than 0:");
        double a = double.Parse(Console.ReadLine());
        if (a == 0)
        {
            Console.WriteLine("First \"A\" parameter must be different than 0");
        }
        else
        {
            Console.WriteLine("Insert value for B:");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Insert value for C:");
            double c = double.Parse(Console.ReadLine());
            double discr=((Math.Pow(b,2))-(4*a*c));

            if (discr == 0)
            {
                double x1=((b/2*a)*(-1));
                Console.WriteLine("There only one root: {0}",x1);
            }
            else 
            {
                if (discr > 0)
                {
                    double x1 = ((-b) + (Math.Sqrt(discr))) / 2 * a;
                    double x2 = ((-b) - (Math.Sqrt(discr))) / 2 * a;
                    Console.WriteLine("There are two roots: {0} and {1}",x1,x2);
                }
                else
                    Console.WriteLine("There no real roots");
            }
           
        }
    }
}
