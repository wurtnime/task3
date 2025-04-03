using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectN2;
public class Task19
{
    private double X;
    private double A;


    public Task19(double x, double a)
    {
        A = a;
        X = x;

    }
    public double calT()
    {
        return Math.Pow(X,2) + Math.Pow(A,2);
    }
    public double calP()
    {
        double t = calT();
        return Math.Pow(X, 2) - Math.Sqrt(Math.Abs(X));
    }

    public double calY()
    {
        double p = calP();
        double t = calT();
        return X * Math.Pow(p,2) + Math.Pow(t,5);
    }

    public void F2()
    {
        double P = calP();
        double t = calT();
        double y = calY();

        Console.WriteLine($"p = {P}");
        Console.WriteLine($"t = {t}");
        Console.WriteLine($"y = {y}");
    }


}
