using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectN2;
public class Task7
{
    private double X;
    private double K;


    public Task7(double k, double x)
    {
        K = k;
        X = x;

    }

    public double calC()
    {

        return Math.Sqrt(Math.Abs(X));
    }

    public double calA()
    {
        double c = calC();
        return Math.Pow(c, 4) + Math.Pow(K, 3);
    }
    public double calY()
    {
        double a = calA();
        return Math.Pow(Math.Log(a), 3) + Math.Pow(Math.Cos(X), 2);
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