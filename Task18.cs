using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectN2;
public class Task18
{
    private double X;
    private double B;


    public Task18(double x, double b)
    {
        B = b;
        X = x;

    }
    public double calA()
    {
        return Math.Sqrt(Math.Abs(X) + Math.Exp(Math.Sqrt(B)));
    }
    public double calB()
    {
        double a = calA();
        return Math.Log(a);
    }

    public double calY()
    {
        double b = calB();
        double a = calA();
        return X * Math.Pow(a, 3) + Math.Pow(b, 2);
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
