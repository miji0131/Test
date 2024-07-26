using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*          1. Rectangle class를 만들고 width, height 멤버(=인스턴스 변수) 만든다.

            2. getArea() 메서드(=인스턴스 메서드)
            getArea(int w, int h) 메서드(=클래스 메서드) 두 개 만든다.
            둘 다 반환형은 int이다.
*/

namespace HelloCSharp006_06
{
    public class Rectangle
    {
        public int width { get; set; }
        public int height { get; set; }
        public int getArea()
        {
            return width * height;
        }
        public static int getArea(int w, int h)
        {
            return w * h;
        }
    }
}

