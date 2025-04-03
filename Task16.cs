using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectN2;
public class Task16
{
    private double X;
    private double C;


    public Task16(double x, double c)
    {
        C = c;
        X = x;

    }
    public double calB()
    {
        return Math.Pow(C,2) + X;
    }
    public double calA()
    {
        double b = calB();
        return 3 * Math.Sqrt(b + C);
    }

    public double calY()
    {
        double b = calB();
        double a = calA();
        return X * Math.Pow(Math.Cos(a), 2) + Math.Pow(Math.Cos(b), 4);
    }

    public void F2()
    {
        double a = calA();
        double b = calB();
        double y = calY();

        Console.WriteLine($"a = {a}");
        Console.WriteLine($"b = {b}");
        Console.WriteLine($"y = {y}");
    }


}
