using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectN2;
public class Task21
{
    private double B;
    private double N;


    public Task21(double n, double b)
    {
        N = n;
        B = b;

    }
    public double calX()
    {
        return Math.Pow(N,6) + Math.Pow(B,2);
    }
    public double calA()
    {
        double x = calX();
        return Math.Sin(Math.Pow(x,2) + Math.Pow(B,2));
    }

    public double calY()
    {
        double x = calX();
        double a = calA();
        return Math.Log(a)/ Math.Log10(Math.Pow(B,3));
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
