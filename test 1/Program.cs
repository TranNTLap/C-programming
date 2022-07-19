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
        static void Main(string[] args)
        {
            int x = 2;
            int y = 3;
            Console.WriteLine(Tong(x,y));

        }
    }
}
