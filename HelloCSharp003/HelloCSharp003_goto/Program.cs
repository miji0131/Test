using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace HelloCSharp003_goto
{
    internal class Program
    {
        static void Main(string[] args)
        {
           /* Console.WriteLine("프로그램 시작");
            START:
            string text = Console.ReadLine();
            Console.WriteLine(text);
            goto START; // 무한 반복되는 코드
            // 문자열을 입력받고 그 것을 출력하는 동작을 무한 반복*/

            //1. 1부터 100까지의 합을 구해보세요.(참고 1부터 n까지의 합 공식 n(n+1)/2)
            Console.WriteLine("1부터 100까지의 합:");

       
            int n = 100;
            int sum = 1;
            START:
            Console.WriteLine();
            Console.WriteLine(sum);
            goto START;

            //2. a부터 b까지의 합을 구해보세요.
            Console.WriteLine("a를 입력하세요:");
            Console.WriteLine("b를 입력하세요:");
        }
    }
}
