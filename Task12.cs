using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectN2;
public class Task12
{
    private double Q;
    private double B;


    public Task12(double b, double q)
    {
        B = b;
        Q = q;

    }

    public double calX()
    {

        return Math.Pow(2, Q) + Math.Pow(5.8, Q);
    }

    public double calT()
    {

        return Math.Pow(Q, 2) + Math.Sqrt(B);
    }
    public double calY()
    {

        return Math.Pow(B, 3) + Math.Log(Math.Abs(B));
    }



    public void G1()
    {
        double t = calT();
        double x = calX();
        double y = calY();

        Console.WriteLine($"x = {x}");
        Console.WriteLine($"t = {t}");
        Console.WriteLine($"y = {y}");
    }


}