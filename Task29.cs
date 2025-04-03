using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectN2;
public class Task29
{

    private double P;
    private double A;


    public Task29(double a, double b)
    {
        P = b;
        A = a;

    }
    public double calT()
    {
        return Math.Pow(P, 3) + Math.Pow(A, 4);
    }
    public double calX()
    {
        double t = calT();
        return Math.Exp(Math.Sqrt(P + A));
    }

    public double calY()
    {
        double x = calX();
        double t = calT();
        return Math.Pow(t, 3) + Math.Pow(x, 2);
    }

    public void F2()
    {
        double t = calT();
        double x = calX();
        double y = calY();

        Console.WriteLine($"x = {t}");
        Console.WriteLine($"p = {x}");
        Console.WriteLine($"y = {y}");
    }


}
