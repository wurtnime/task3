using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectN2;
public class Task27
{

    private double T;
    private double A;


    public Task27(double a, double t)
    {
        T = t;
        A = a;

    }
    public double calC()
    {
        return Math.Pow(T, 4) + Math.Pow(A, 3);
    }
    public double calX()
    {
        double t = calC();
        return Math.Exp(Math.Sqrt(t + A));
    }

    public double calY()
    {
        double x = calX();
        double t = calX();
        return Math.Pow(t, 3) + Math.Pow(x, 3);
    }

    public void F2()
    {
        double t = calX();
        double x = calX();
        double y = calY();

        Console.WriteLine($"c = {x}");
        Console.WriteLine($"x = {t}");
        Console.WriteLine($"y = {y}");
    }


}
