using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

//API: 프로그래밍할 때나 데이터 분석 시 활용하는 데이터나 라이브러리를 활용하기 위한 규칙
//인터페이스: 정보를 주고 받기 위한 규칙, 규약을 의미
//ex) 특정 키를 눌렀을 때 정해진 동작을 하는 것이 모두 인터페이스에 속함
// ?: 쿼리스트링


namespace HelloCSharp010_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //https://www.kma.go.kr/wid/queryDFSRSS.jsp?zone=2714055500
            string url = "https://www.kma.go.kr/wid/queryDFSRSS.jsp?zone=2714055500";
            //using System.Xml.Linq;
            XElement xe = XElement.Load(url);//url에서 xml을 가져옴 //public static XElement Load(string uri) 클래스 메서드
            Console.WriteLine(xe); //url의 xml 결과물을 출력 함
            Console.WriteLine("-----");
            //Descendants = 자손들
            //데이터태그 하위요소

            //데이터 태그의 하위 요소를 출력
            var xQ = from item in xe.Descendants("data") select item;
            foreach (var item in xQ)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("----");
            foreach (var item in xQ) //<data> 태그 안에 있는 <temp> 태그랑 <wdKor> 태그에 있는 것만 출력
            {
                if (item.Element("day").Value.Equals("0")) //오늘에 대해서만 출력하고 싶다면...
                {
                    Console.WriteLine(item.Element("temp"));
                    Console.WriteLine(item.Element("hour").Value);
                    Console.WriteLine(item.Element("wfKor").Value);
                }
            }
        }
    }
}
