using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



           

            5. 3번에 타이머를 이용해서 시간 제한 추가해보기

            6. 보물 찾기 게임 만들기(지뢰 찾기랑 유사함)

            7. 6번을 하되, 타이머를 추가하여 시간 제한 추가하기*/

namespace HelloCSharp006_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle r1 = new Rectangle();
            r1.width = 10;
            r1.height = 3;

            Rectangle r2 = new Rectangle() { width = 5, height = 7 };
            Console.WriteLine(r1.getArea());
            Console.WriteLine(r2.getArea());
            Console.WriteLine(Rectangle.getArea(8, 4));
        }
    }
}
