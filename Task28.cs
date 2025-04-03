using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectN2;
public class Task28
{

    private double P;
    private double A;


    public Task28(double b, double k)
    {
        P = b;
        A = k;

    }
    public double calT()
    {
        return Math.Pow(P, 9) + Math.Pow(A, 5);
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
        return Math.Pow(t, 3) + Math.Pow(x, 3);
    }

    public void F2()
    {
        double t = calT();
        double x = calX();
        double y = calY();

        Console.WriteLine($"a = {t}");
        Console.WriteLine($"t = {x}");
        Console.WriteLine($"y = {y}");
    }


}
