using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectN2;
public class Task4
{
    private double X;
    private double T;


    public Task4(double x, double t)
    {
        X= x;T=t;

    }
    public double calA()
    {
        return Math.Log(X);
    }
    public double calB()
    {
        double a = calA();
        return Math.Sqrt(Math.Pow(X,2)+ Math.Pow(T,2));
    }

    public double calY()
    {
        double a = calA();
        double b = calB();
        return Math.Sqrt(Math.Abs(a - b * X));
    }

    public void G4()
    {
        double a = calA();
        double b = calB();
        double y = calY();

        Console.WriteLine($"a = {a}");
        Console.WriteLine($"c = {b}");
        Console.WriteLine($"y = {y}");
    }


}
