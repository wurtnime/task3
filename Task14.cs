using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectN2;
public class Task14
{
    private double K;
    private double B;


    public Task14(double b, double k)
    {
        B = b;
        K = k;

    }

    public double calA()
    {

        return Math.Pow(K, 2.1) / Math.Pow(K, 3.5);
    }

    public double calT()
    {

        return Math.Pow(K, 2) + Math.Sqrt(B);
    }
    public double calY()
    {

        return Math.Pow(B, 3) + Math.Log(Math.Abs(B));
    }



    public void G1()
    {
        double t = calT();
        double a = calA();
        double y = calY();

        Console.WriteLine($"a = {a}");
        Console.WriteLine($"t = {t}");
        Console.WriteLine($"y = {y}");
    }


}