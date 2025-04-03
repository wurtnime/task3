using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectN2;
public class Task22
{
    private double M;
    private double P;


    public Task22(double m, double p)
    {
        M = m;
        P = p;

    }
    public double calT()
    {
        return Math.Sin(Math.Pow(M,3));
    }
    public double calX()
    {
        double t = calT();
        return Math.Pow(P,2) + t;
    }

    public double calY()
    {
        double t = calT();
        double x = calX();
        return Math.Log10(x + t);
    }

    public void F2()
    {
        double x = calX();
        double t = calT();
        double y = calY();

        Console.WriteLine($"t = {t}");
        Console.WriteLine($"x = {x}");
        Console.WriteLine($"y = {y}");
    }


}
