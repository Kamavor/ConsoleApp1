using System;

namespace ConsoleApp1
{

    public class MyOne
    {
        static void Main(string[] args)
        {
            Figures t1 = new Figures(1, 1, 1.4142135, 2);  // треугольник (катет, катет, гипотенуза)
            Console.WriteLine(t1.Square());
            Console.WriteLine(t1.Rectangular());

            Figures t2 = new Figures(2, 0, 0, 1); // круг (радиус,0,0)
            Console.WriteLine(t2.Square());
        }
    }
}