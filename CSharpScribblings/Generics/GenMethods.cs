using System;
namespace Generics
{
    public class GenMethods
    {
        // Method can operate on multiple data types
        public static void Swap<T>(ref T x, ref T y)
        {
            T temp = x;
            // Save x
            x = y;
            // Assign y to x
            y = temp;
            // Assign original value to x back to y
        }

        // The function has a contraint, so it can operate on values
        // that can be compared
        public static string Compare<T>(T x, T y) where T : IComparable
        {
            // CompareTo retrun < 0, =0, or > 0, depending on the relationship
            // between x and y
            if (x.CompareTo(y) < 0)
            {
                return $"{x}<{y}";
            }
            else
            {
                return $"{x}>{y}";
            }
        } 
    }
}
