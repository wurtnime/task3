using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectN2;
public class Task26
{

    private double T;
    private double B;


    public Task26(double t, double b)
    {
        T= t; B = b;

    }
    public double calA()
    {
        return Math.Pow(T, 3) + Math.Pow(B, 3);
    }
    public double calX()
    {
        double t = calA();
        return Math.Exp(Math.Sqrt(T + B));
    }

    public double calY()
    {
        double x = calX();
        double t = calA();
        return Math.Pow(t, 3) + Math.Pow(x, 3);
    }

    public void F2()
    {
        double a = calA();
        double x = calX();
        double y = calY();

        Console.WriteLine($"a = {a}");
        Console.WriteLine($"x = {x}");
        Console.WriteLine($"y = {y}");
    }


}
