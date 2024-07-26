using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloCSharp003
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("안녕"[0]);
            Console.WriteLine("안녕" + "하세요");
            Console.WriteLine(1 + 2 + 3); // ctrl d 코드 한 줄 복사&붙여넣기
            Console.WriteLine(1 + 2 + "3");
            Console.WriteLine("1" + 2 + 3);
            Console.WriteLine('1' + 2 + 3); // '1'은 아스키코드로 49
            Console.WriteLine("안녕 내 나이는 " + 1989 + "년 생이야");
            Console.WriteLine($"안녕 내 나이는 {2024 - 1989}살이야");
            Console.WriteLine(string.Format("내 나이는 {0}살이야, {1}년생!", 2024 - 1989, 1989));

            int a = int.MaxValue;    //2147483647;
            Console.WriteLine(a);
            a = a + 1;
            Console.WriteLine(a);// 오버 플로우
            long b = 2147483647;
            b = b + 1;
            Console.WriteLine(b);

            Console.WriteLine("당신의 이름은?");
            string name = Console.ReadLine();
            Console.WriteLine("당신이 태어난 달은?");
            int month = int.Parse(Console.ReadLine());
            Console.WriteLine($"내 이름은 {name}, 나는 {month}월에 태어남");

            /*//1. Inch 단위를 입력받아 cm 단위를 구하는 코드를 작성하시오.
            Console.WriteLine("Inch 값을 입력하세요:");
            double inch = Convert.ToDouble(Console.ReadLine());
            double cm = inch * 2.54;
            Console.WriteLine($"{inch} 인치는 {cm} 센티미터입니다.");

            //2. 킬로그램(kg) 단위를 입력받아 파운드(pound)단위를 구하는 코드를 작성하시오.
            Console.WriteLine("킬로그램(kg) 값을 입력하세요:");
            double kg = Convert.ToDouble(Console.ReadLine());
            double pound = kg * 2.20462262;
            Console.WriteLine($"{kg} kg는 {pound} 파운드입니다.");

            //3. 원의 반지름을 입력받아 원의 둘레와 넓이를 구하는 코드를 작성하시오.
            Console.WriteLine("원의 반지름을 입력하세요:");
            double r=Convert.ToDouble(Console.ReadLine());
            double cir = 2 * 3.14 * r;
            double area = 3.14 * r * r;
            Console.WriteLine($"반지름이 {r}인 원의 둘레는 {cir}이고, 넓이는 {area}입니다.");

            //4. 정수 a와 b를 입력받는다.
            //  ex) a = 472, b = 385
            // 출력
            // 2360
            // 3776
            // 1416
            // 181720
            Console.WriteLine("정수 a를 입력하세요:");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("정수 b를 입력하세요:");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine(a * (b % 10)); // 일의 자리 숫자 곱하기
            Console.WriteLine (a * ((b / 100) % 10));   // 십의 자리 숫자 곱하기
            Console.WriteLine(a * (b / 100));  // 백의 자리 숫자 곱하기
            Console.WriteLine(a * b);   // 두 정수 전체를 곱한 결과 출력

            //5. "5 4 6 2 3 1"
            // 5 4 6 2 3 1 5 4 6 2 3 1
            // 입력과 출력 예시
            // 입력: 4
            // 출력 [4 6 2 3 1 5]
            // 입력: 5
            // 출력[5 4 6 2 3 1]
            // 조건문, 반복문, 배열 쓰지 말고 
            Console.WriteLine("5 4 6 2 3 1 중 하나를 입력하세요: ");*/



        }
    }
}
