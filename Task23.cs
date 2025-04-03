using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectN2;
public class Task23
{
    private double X;
    private double B;


    public Task23(double x, double b)
    {
        B = b;
        X = x;

    }
    public double calT()
    {
        return Math.Pow(B,2) * X + Math.Sqrt(X);
    }
    public double calA()
    {
        double t = calT();
        return Math.Log10(t * X + Math.Pow(B,2));
    }

    public double calY()
    {
        double a = calA();
        double t = calT();
        return Math.Pow(a,3)/(a + t) ;
    }

    public void F2()
    {
        double a = calA();
        double t = calT();
        double y = calY();

        Console.WriteLine($"a = {a}");
        Console.WriteLine($"t = {t}");
        Console.WriteLine($"y = {y}");
    }


}
