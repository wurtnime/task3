using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectN2;
public class Task8
{
    private double B;
    private double C;


    public Task8(double b, double c)
    {
        B = b; C = c;

    }

    public double calA()
    {

        return Math.Sin(B);
    }

    public double calX()
    {
        double a = calA();
        return a + (B + Math.Pow(C, 3));
    }
    public double calY()
    {
        double x = calX();
        return  Math.Exp(7) + Math.Pow(Math.Cos(x), 5);
    }



    public void G1()
    {
        double a = calA();
        double x = calX();
        double y = calY();

        Console.WriteLine($"a = {a}");
        Console.WriteLine($"c = {x}");
        Console.WriteLine($"y = {y}");
    }


}