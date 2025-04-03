using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectN2;
public class Task13
{
    private double X;
    private double A;


    public Task13(double x, double a)
    {
        X = x;
        A = a;

    }

    public double calZ()
    {

        return Math.Pow(2, X) + Math.Pow(5.8, A);
    }

    public double calW()
    {

        return Math.Pow(A, 2) + Math.Sqrt(X);
    }
    public double calY()
    {

        return Math.Pow(X, 3) + Math.Log(Math.Abs(X));
    }



    public void G1()
    {
        double w = calZ();
        double z = calW();
        double y = calY();

        Console.WriteLine($"z = {z}");
        Console.WriteLine($"w = {w}");
        Console.WriteLine($"y = {y}");
    }


}