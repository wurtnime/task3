using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectN2;
public class Task3
{
    private double X;
    private double P;


    public Task3(double x3, double p3)
    {
        P = p3;
        X = x3;

    }
    public double calA()
    {
        return Math.Exp(Math.Sqrt(Math.Abs(X)));
    }
    public double calB()
    {
        double a = calA();
        return (Math.Sin(Math.Pow(P, 2)) + Math.Pow(X, 3));
    }

    public double calY()
    {
        double b = calB();
        double a = calA();
        return Math.Pow(a, 3) / Math.Pow(b, 2);
    }

    public void U3()
    {
        double a = calA();
        double b = calB();
        double y = calY();

        Console.WriteLine($"a = {a}");
        Console.WriteLine($"b = {b}");
        Console.WriteLine($"y = {y}");
    }


}
