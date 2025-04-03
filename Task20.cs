using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectN2;
public class Task20
{
    private double X;
    private double P;


    public Task20(double p, double x)
    {
        P = p;
        X = x;

    }
    public double calA()
    {
        return Math.Log(Math.Abs(X));
    }
    public double calB()
    {
        double a = calA();
        return Math.Pow(X, 4) + Math.Log10(Math.Pow(P, 3));
    }

    public double calY()
    {
        double b = calB();
        double a = calA();
        return X * Math.Sin(a * X) + Math.Sqrt(b)* Math.Cos(X);
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