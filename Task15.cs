using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectN2;
public class Task15
{
    private double A;
    private double P;


    public Task15(double a, double p)
    {
        A = a;
        P = p;

    }

    public double calX()
    {

        return Math.Pow(2, P) - Math.Pow(2, A);
    }

    public double calB()
    {

        return Math.Pow(P, 2) + Math.Sqrt(A);
    }
    public double calY()
    {

        return Math.Pow(A, 3) + Math.Log(Math.Abs(P));
    }



    public void G1()
    {
        double b = calB();
        double x = calX();
        double y = calY();

        Console.WriteLine($"x = {x}");
        Console.WriteLine($"b = {b}");
        Console.WriteLine($"y = {y}");
    }


}