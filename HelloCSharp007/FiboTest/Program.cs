using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiboTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Fibonacci.Get(40));//40번째 Fibonacci 수를 계산하여 출력
            Console.WriteLine(Fibonacci.Get(100));//100번째 Fibonacci 수를 계산하여 출력
        }
    }
}
