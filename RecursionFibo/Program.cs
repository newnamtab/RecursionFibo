using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursionFibo
{
    class Program
    {
        static void Main(string[] args)
        {
            Fibo myFibo = new Fibo();
            Console.WriteLine(myFibo.FiboLoop(10));
            Console.WriteLine(myFibo.CalcFibo(10));

        }
    }
}
