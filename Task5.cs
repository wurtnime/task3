using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectN2;
public class Task5
{
    private double X;
    private double B;


    public Task5(double b, double x)
    {
        B = b;
        X = x;

    }
    public double calA()
    {
        return Math.Log10(X);
    }
    public double calC()
    {
        double a = calA();
        return Math.Pow(a, 2) + Math.Sqrt(B * X);
    }

    public double calY()
    {
        double c = calC();
        return Math.Exp(2 * X) + 9.7 * c;
    }

    public void G1()
    {
        double a = calA();
        double c = calC();
        double y = calY();

        Console.WriteLine($"a = {a}");
        Console.WriteLine($"c = {c}");
        Console.WriteLine($"y = {y}");
    }


}