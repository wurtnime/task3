using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectN2;
public class Task25
{

    private double P;
    private double A;


    public Task25(double a, double p)
    {
        P = p;
        A = a;

    }
    public double calT()
    {
        return Math.Pow(P,3) + Math.Pow(A,3);
    }
    public double calX()
    {
        double t = calT();
        return Math.Exp(Math.Sqrt( P + A));
    }

    public double calY()
    {
        double x = calX();
        double t = calT();
        return Math.Pow(t,3) + Math.Pow(x,3);
    }

    public void F2()
    {
        double t = calT();
        double x = calX();
        double y = calY();

        Console.WriteLine($"a = {t}");
        Console.WriteLine($"b = {x}");
        Console.WriteLine($"y = {y}");
    }


}
