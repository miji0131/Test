using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace HelloCSharp004_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // f5: 디버금 모드. 바로 종료된느 건 
            // alt shift, alt ctrl 키 이용해서 여러 곳 선택가능
            // for문으로 1부터 100까지 더하기


            // T 풀이
            // 1. 문제
            /*
     int floor = 5;
     // Console.Write, Console.WriteLine
     for (int i = 0; i < floor; i++)
     {
         for (int j = floor - i - 1; j > 0; j--)
             Console.Write(" ");
         for (int j = 0; j < 2 * i + 1; j++)
             Console.Write("*");
         Console.WriteLine();
     }*/
            // 2. 문제
            /*
          int[] numbers = new int[5];
          for (int i = 0; i < numbers.Length; i++)
          {
              Console.WriteLine("정수 입력");
              numbers[i] = int.Parse(Console.ReadLine());
          }
          int max = numbers[0];
          int min = numbers[0];
          for (int i = 1; i < numbers.Length; i++)
          {
              //if (max < numbers[i])
              //    max = numbers[i];
              max = numbers[i] > max ? numbers[i] : max;
              //if (min > numbers[i])
              //    min = numbers[i];
              min = numbers[i] < min ? numbers[i] : min;
          }
          Console.WriteLine("최댓값:" +  max + ",최솟값:" + min);*/

            // 3. 문제
            // 개미수열
            // 1, 11, 12, 1121, 122111, 112213
            // 두번째 수열: "1이 한개"
            // "1" = start(string)
            // end = 누적값

            string start = "1"; // 처음에 주어지는 읽을 수열(문자열이라봐도)
            for(int i = 0; i < 20; i++) // 20번째 숫자까지 반복
            {
                Console.WriteLine(start);   // 현재 수열 출력

                String end = "";    // 새로운 수열을 저장할 변수 (누적 변수)
                int count = 0;  // 현재 읽은 숫자의 개수를 세는 변수
                char num = start[0];     // 현재 숫자 (첫 번째 문자)

                // 주어진 수열을 읽어가면서 규칙에 따라 새로운 수열 생성
                for (int j = 0; j < start.Length; j++) 
                {
                    if (num == start[j])
                        count++;    // 현재 숫자와 같은 경우 개수 증가
                    else
                    {
                        // 다른 숫자를 만나면 이전 숫자와 그 개수를 end에 추가
                        end = end + num + count;
                        // 다음 숫자로 초기화
                        count = 1;
                        num = start[j];
                    }
                }

                // 마지막 숫자와 개수를 end에 추가
                end = end + num + count;
                // 다음 수열로 업데이트
                start = end;
            }



            /*// 4. 문제
            // 1부터 n구하는 공식, n(n+1)/2
            Console.WriteLine(100 * 101 / 2);
            int sum = 0;
            for (int i = 0; i <= 100; i++)
                sum += i;
            Console.WriteLine(sum);

            // 5. 문제
            // 한글 전부 출력 // alt키 누르고 화살표 위 아래
            for (char c = '가'; c <= '힣'; c++)
                Console.Write(c);

            // 6. 문제
            //A~Z, a~z 출력
            for (char a = 'A'; a <= 'z'; a++)
            {
                if ('Z' > a && a < 'a') 
                    continue;   // 현재 반복을 중지하고 다음 반복으로 넘어감
                Console.Write(a);   // 원하지 않는 특수문자까지 나옴
        }*/

        }
    }
}
