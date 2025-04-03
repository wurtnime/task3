using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectN2;
public class Task24
{
    private double T;
    private double B;


    public Task24(double b, double t)
    {
        B = b; T = t;

    }
    public double calA()
    {
        return Math.Pow(T,2)*B;
    }
    public double calX()
    {
        double a = calA();
        return Math.Pow(a,3) + Math.Sqrt(T + B);
    }

    public double calY()
    {
        double x = calX();
        double a = calA();
        return Math.Sin(Math.Pow(x,4)) - B* Math.Pow(Math.Sin(x),2);
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