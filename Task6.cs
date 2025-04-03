using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectN2;
public class Task6
{
    private double X;
    private double M;


    public Task6(double m, double x)
    {
        M = m;
        X = x;

    }
    public double calA()
    {
        
        return Math.Sqrt(Math.Abs(X));
    }
    public double calB()
    {
        return Math.Pow(X, 4) + Math.Pow(M, 2);
    }

    public double calY()
    {
        double a = calA();
        double c = calB();
        return Math.Pow(Math.Sin(a + Math.Pow(Math.Tan(c), 2)), 2);
    }

    public void G1()
    {
        double a = calA();
        double c = calB();
        double y = calY();

        Console.WriteLine($"a = {a}");
        Console.WriteLine($"b = {c}");
        Console.WriteLine($"y = {y}");
    }


}