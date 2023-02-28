using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0227hw
{
    class Program
    {
        public static void Swap<T>(ref T a,ref T b)
        {
            (a, b) = (b, a);
        }


        static void Main(string[] args)
        {
            int a = 5, b = 10;

            Console.WriteLine("Before: \na: " + a + " b: " + b);

            Swap(ref a, ref b);

            Console.WriteLine("After: \na: " + a + " b: " + b);
        }
    }
}
