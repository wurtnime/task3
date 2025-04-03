using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectN2;
public class Task2
{
    private double X;
    private double K;


    public Task2(double x2, double k2)
    {
        K = k2;
        X = x2;

    }
    public double calA()
    {
        return Math.Log10(Math.Abs(X));
    }
    public double calB()
    {
        double a = calA();
        return Math.Exp(2 * X) + a * X;
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
