using System;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            GenericsClass<int> ints = new GenericsClass<int>(new int[] { 1, 2, 3, 4, 5 });
            Console.WriteLine(ints.DisplayValues());

            GenericsClass<double> dubs = new GenericsClass<double>(new double[] { 1.0, -2.3, 3, 4, 5 });
            Console.WriteLine(dubs.DisplayValues());

            GenericsClass<decimal> decs = new GenericsClass<decimal>(new decimal[] { 1, 2.0M, 3, 4, 5.79M });
            Console.WriteLine(decs.DisplayValues());
        }
    }
}
