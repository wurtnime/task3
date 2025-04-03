using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectN2;
public class Task10
{
    private double X;
    private double B;


    public Task10(double b, double x)
    {
        B = b; 
        X = x;

    }

    public double calA()
    {

        return  Math.Pow(2, X) + Math.Pow(5.8, X);
    }

    public double calC()
    {

        return Math.Pow(X, 2) + Math.Sqrt(B);
    }
    public double calY()
    {

        return Math.Pow(B, 3) + Math.Log(Math.Abs(B));
    }



    public void G1()
    {
        double a = calA();
        double c = calC();
        double y = calY();

        Console.WriteLine($"a = {a}");
        Console.WriteLine($"c = {c}");
        Console.WriteLine($"y = {y}");
    }


}