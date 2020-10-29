using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursiveMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 1;
            int m = 3;
            int sum = CalculateSumRecursive(n,m);
            Console.WriteLine($"The sum of given range is {sum} ");
        }

        static int CalculateSumRecursive(int n, int m)
        {
            int sum = n;
            if(n<m)
            { 
             n++;
             return sum+=CalculateSumRecursive(n, m);
            }
            return sum;
        }
    }
}
