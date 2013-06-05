/*Write a program that reads the radius r of a circle and prints its perimeter and area.
*/
using System;


class CircleCalculaor
{
    static void Main()
    {
        Console.Title = "Circle Calculator";
        Console.WriteLine("Hello, I am circle calculator\r\nInsert radius R to calculate:");
        double r = double.Parse(Console.ReadLine());
        double p = 2 * (Math.PI) * r;
        double a=((Math.PI)*(Math.Pow(r,2)));
        Console.WriteLine("Perimeter of the circle is: {0:.######} units",p);/*{0:.######} is six digits after decimal point*/
        Console.WriteLine("Area of the circle is {0:.######} squareunits",a);/*{0:.######} is six digits after decimal point*/
    }
}
