using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HelloCSharp004_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 내풀이

            /*//1. 삼각형 모양 피라미드를 만드시오.
           
            int height = 5;
            // 삼각형 피라미드 출력
            for (int i = 0; i < height; i++)
            {
                // 왼쪽 공백 출력
                for (int j = 0; j < height - i - 1; j++)
                {
                    Console.Write(" ");
                }

                // 별표 출력
                for (int k = 0; k < 2 * i + 1; k++)
                {
                    Console.Write("*");
                }

                // 줄 바꿈
                Console.WriteLine();*/

     

            /*//2. 5개의 숫자를 입력받은 뒤 가장 작은 수와 가장 큰 수를 출력하는 프로그램을 작성하시오.
            int[] num = new int[5]; // 5개의 숫자를 담을 배열 선언
            Console.WriteLine("숫자를 입력하세요:");
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"{i + 1}번째 숫자: ");
                num[i] = int.Parse(Console.ReadLine());
            }
            // 가장 작은 수와 가장 큰 수 초기화
            int min = num[0];
            int max = num[0];
            // 최솟값과 최댓값 찾기
            for (int i = 1; i < 5; i++)
            {
                if (num[i] < min)
                    min = num[i];

                if (num[i] > max)
                    max = num[i];
            }
            // 결과 출력
            Console.WriteLine("가장 작은 수: " + min);
            Console.WriteLine("가장 큰 수: " + max);*/

          

            //3. 아래의 규칙을 따르는 수열의 20번째 숫자를 프로그램을 만들어 찾으시오.
            // 1, 11, 12, 1121, 122111, 112213
            // (규칙)첫번째 숫자는 1이다.
            // 두번째 숫자는 "한 숫자의 개수 숫자" 로 표현한다. 예를 들어, 첫번째 숫자는 1이므로 두번째 숫자는 "1이 한개"이므로 11이 된다.
            // 이 과정을 반복한다.


            /*  //4. for 반복문으로 덧셈하기
              //출력값: 5050

              int sum = 0;
                  for (int i = 1; i < 101; i++) 
                  {
                  sum += i;
              }
              Console.WriteLine(sum);*/


            //5. 한글 전부 출력하기
           
            


            /*//6. A~Z, a~z 모두 출력
            // 대문자
            for (int i = 'A'; i < 'Z'; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            // 소문자
            for (char j = 'a'; j <= 'z'; j++)
            {
                Console.Write(j + " ");
            }
            Console.WriteLine();*/
        }
    }
}
    

   


