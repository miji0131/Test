using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

//LINQ는 데이터를 쉽게 조회하고 조작할 수 있도록 지원하는 기능
namespace HelloCSharp010_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string url = "https://www.kma.go.kr/wid/queryDFSRSS.jsp?zone=2714055500";//기상청주소
            XElement xe = XElement.Load(url);//url에서 xml을 가져옴

            // LINQ를 사용하여 XML 데이터를 필터링하고 Weather 객체 리스트로 변환
                                     // LINQ에 치명적인 문제는 여기서부터
            List<Weather> weathers = (from item in xe.Descendants("data")  //데이터 태그의 하위 요소를 가져옴
                                                                        
                                      where item.Element("day").Value.Equals("0")
                                      select new Weather()//필요한 정보만 추출하여 Weather객체를 생성
                                      {
                                          hour = item.Element("hour").Value,
                                          temp = item.Element("temp").Value,
                                          wfKor = item.Element("wfKor").Value,
                                          wfEn = item.Element("wfEn").Value,
                                      }).ToList();// ToList메서드를 호출하여 결과를 List<Weather>로 변환
                                      //여기까지 한줄로 침
            //DataGridView에 데이터 표시
            dataGridView1.DataSource = null;//기존 데이터 소스를 제거
            dataGridView1.DataSource = weathers;//새로 생성한 weathers 리스트를 데이터 소스로 설정. 이를 통해 날씨 정보를 표시
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            //1000회차부터 지금까지의 정보를 dataGridView에 띄울 것
            string url = "https://www.dhlottery.co.kr/common.do?method=getLottoNumber&drwNo=";
            int count = 1000;
            List<Lotto> lottos = new List<Lotto>();
            while (true)
            {
                using (WebClient wc = new WebClient())
                {
                    var json = wc.DownloadString(url + count); //url에 있는 글자 가져오기
                    count++;
                    var jObj = JObject.Parse(json); //그 글자를 JSON 형태로 변환함
                    //if (jObj["returnValue"].ToString().Equals("success") == false)
                    if (jObj["returnValue"].ToString().Equals("fail"))
                        break;
                    lottos.Add(new Lotto()
                    {
                        drwNo = jObj["drwNo"].ToString(),
                        drwNoDate = jObj["drwNoDate"].ToString()
                    });

                }//wc는 이 중괄호 끝나면 소멸됨

            }
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = lottos;

        }
        
    }
}

