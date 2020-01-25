using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    public class GenericsClass<T>
    {
        // generic array instance variable
        private T[] vals;

        public GenericsClass(T[] input)
        {
            vals = input;
        }

        public string DisplayValues()
        {
            string str = null;

            foreach (T t in vals)
            {
                str += $"Value={t} "; 
            }

            return str;
        }
    }
}
