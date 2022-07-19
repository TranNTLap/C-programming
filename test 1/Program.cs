using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_1
{
    internal class Program
    {
        static int Tong(int a,int b)
        {
            return a + b;  
        }
        static int TimMax(int[] A)
        {
            int max = A[0];
            for(int i = 1; i < A.Length; i++)
            {
                if (A[i] > max)
                {
                    max = A[i];
                }
            }
            return max;

        }
        static void Main(string[] args)
        {
            int[] myNum = { 10, 20, 30, 40, 100 };
            Console.WriteLine( TimMax(myNum));

        }
    }
}
