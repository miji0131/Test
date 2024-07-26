using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//6. 보물 찾기 게임 만들기(지뢰 찾기랑 유사함)
namespace HelloCSharp007_01
{
    public partial class Form1 : Form
    {
        int answer;
        public Form1()
        {
            InitializeComponent();
        }


        int cout = 1;//count 변수
        private void button1_Click(object sender, EventArgs e)
        {
            answer = new Random().Next(25) + 1;
            Console.WriteLine(answer);  // 콘솔창에 답의 띄워짐

            for(int i = 0; i < 5; i++) 
            {
                for(int j = 0; j < 5; j++) 
                {
                    Button button = new Button();
                    Point point = new Point();//좌표
                    point.X = 13 + 100 * j;
                    point.Y = 13 + 13 + (23 + 3) * i;
                    button.Location = point; // 지정
                    button.Text = cout.ToString(); 
                    button.Click += Button_Click;  // 버튼을 클릭했을 때 어떤 것을 실행할 지 지정해줌
                    cout++;
                    Controls.Add(button);//필수. 안할 시 버튼이 화면에 보이지 않음
                }
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            //sender = 이벤트를 발생시키는 주체
            //(sender as Button) = Button으로 형변환
            int mychoice = int.Parse((sender as Button).Text);
            if (mychoice == answer)
                MessageBox.Show("정답");
        }
    }
}
