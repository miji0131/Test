using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloCSharp004_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5];
            numbers[0] = 10;
            numbers[1] = 2;
            for (int i = 2; i < 5; i++)
                numbers[i] = i * 10;
            for (int i = 0; i < numbers.Length; i++)
                Console.WriteLine(numbers[i]);
            foreach (var item in numbers)
                Console.WriteLine(item);
        }
    }
}
