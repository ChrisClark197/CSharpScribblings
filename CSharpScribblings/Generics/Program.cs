using Generics.Generics;
using System;
using System.Collections.Generic;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1
            GenericsClass<int> ints = new GenericsClass<int>(new int[] { 1, 2, 3, 4, 5 });
            Console.WriteLine(ints.DisplayValues());

            GenericsClass<double> dubs = new GenericsClass<double>(new double[] { 1.0, -2.3, 3, 4, 5 });
            Console.WriteLine(dubs.DisplayValues());

            GenericsClass<decimal> decs = new GenericsClass<decimal>(new decimal[] { 1, 2.0M, 3, 4, 5.79M });
            Console.WriteLine(decs.DisplayValues());

            // 2
            double x = 25, y = 34;
            GenMethods.Swap<double>(ref x, ref y);

            Console.WriteLine(GenMethods.Compare<double>(x, y));

            int x2 = 25, y2 = 34;
            GenMethods.Swap<int>(ref x2, ref y2);

            Console.WriteLine(GenMethods.Compare<int>(x2, y2));

            // 3

            Quad sqr = new Square("John", 4);
            Quad rect = new Rectangle("Bob", 2, 5);
            Quad rect2 = new Rectangle("Jerry", 4, 5);
            List<Quad> lst = new List<Quad>(new Quad[] { sqr, rect, rect2 });
            lst.Sort();

            if (lst[0] is Square)
            {
                Console.WriteLine(((Square)lst[0]).Perimeter());
            }
            else if (lst[0] is Rectangle)
            {
                Console.WriteLine(((Rectangle)lst[0]).Perimeter());
            }
        }
    }
}
