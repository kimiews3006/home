using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tryBit
{
    class Program
    {
        static private double[] A;
        static private int n;
        static void trynBit(int i)
        {
            double[] A = new double[4];
            for(int j=0;j<=1;j++)
            {
                A[i] == j;
                if (i == n - 1)
                    Console.WriteLine(A[i]);
                else trynBit(i + 1);
            }
            
        }
                
        static void Main(string[] args)
        {
            Console.WriteLine();
            trynBit(0);
        }
    }
}
