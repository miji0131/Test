using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloCSharp006_04
{
    public class Circle
    {
        public int r { get; set; }

        public double getArea()
        {
            return 3.14 * r * r;
        }
        // 여기에서의 r은 매개변수이며, 속성(11번째 줄에 있는 r)이랑
        // 관계없는 값임
        // 이 메서드는 매개 변수에 의해서만 값이 변함

        public static double getAreaWithR(int r)
        {
            return r * r * 3.14;
        }
    }
}
