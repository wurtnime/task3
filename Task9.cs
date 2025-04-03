using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectN2;
public class Task9
{
    private double K;
    private double M;


    public Task9(double k, double m)
    {
        K = k; M = m;

    }

    public double calX()
    {

        return Math.Pow(Math.Exp(1), M * K);
    }

    public double calC()
    {
        
        return Math.Pow(Math.Cos(M), 2) + Math.Pow(K, 2);
    }
    public double calY()
    {
        double c = calC();
        double x = calX();
        return  Math.Sqrt(Math.Pow(x, 2) + Math.Pow(c, 2));
    }



    public void G1()
    {
        double x = calX();
        double c = calC();
        double y = calY();

        Console.WriteLine($"x = {x}");
        Console.WriteLine($"c = {c}");
        Console.WriteLine($"y = {y}");
    }


}