using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Recursion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Factorial(8000));
            Console.ReadLine();
        }
        static BigInteger Factorial(int n)
        {
            if(n == 0 || n == 1)
            {
                return 1;
            }else
            {
                return n * Factorial(n - 1);
            }
        }
    }
}
