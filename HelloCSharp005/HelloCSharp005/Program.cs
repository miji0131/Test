using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloCSharp005
{
    public class Program
    {
        static void Main(string[] args)
        {
            Car c1 = new Car();
            c1.carNum = "8512";
            c1.kg = 1123.554;
            c1.length = 210;
            c1.category = "세단";

            Car c2 = new Car();
            c2.carNum = "7722";
            c2.kg = 1523.554;
            c2.length = 150;
            c2.category = "SUV";

            Student s1 = new Student();
            s1.hackbeon = "033";
            s1.name = "이동준";
            s1.car = c1;

            Student s2 = new Student();
            s2.hackbeon = "001";
            s2.name = "박상신";
            s2.car = c2;

            Student s3 = new Student();
            s3.hackbeon = "002";
            s3.name = "이유나";
            Console.WriteLine(s3.car);

            Random r = new Random();
            Console.WriteLine(r.Next(1, 10)); // 1~9까지 출력
            Console.WriteLine(new Random().Next(1, 10));
            Console.WriteLine(Math.PI);//3.14159265358979
        }
    }
}
