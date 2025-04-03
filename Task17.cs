using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectN2;
public class Task17
{
    private double X;
    private double T;


    public Task17(double x, double t)
    {
        T = t;
        X = x;

    }
    public double calB()
    {
        return Math.Pow(Math.Log10(Math.Abs(X)),2);
    }
    public double calA()
    {
        double b = calB();
        return Math.Abs(Math.Sqrt(b));
    }

    public double calY()
    {
        double b = calB();
        double a = calA();
        return Math.Pow(Math.Cos(a + Math.Pow(b,3)),3);
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