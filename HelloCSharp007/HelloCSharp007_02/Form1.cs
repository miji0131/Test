using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//7. 6번을 하되, 타이머를 추가하여 시간 제한 추가하기 
namespace HelloCSharp007_02
{
    public partial class Form1 : Form
    { 
        int answer;//정답
        int cout = 1;
        int now = 0;//현재시간
        const int LIMIT = 10;

        public Form1()
        {
            InitializeComponent();
            label1.Text = "";
            timer1.Interval = 1000;//1000ms = 1s = 1초
            timer1.Enabled = false;//타이머 일단 동작하고 있지 않음
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 타이머를 멈추고 0으로 되돌림
            timer1.Stop();//timer1.Enabled = false; 
            now = 0;

            answer = new Random().Next(25) + 1;
            Console.WriteLine(answer);  // 콘솔창에 답의 띄워짐

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
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
            timer1.Start();//timer1.Enabled = true; 
        }

        private void Button_Click(object sender, EventArgs e)
        {
            int mychoice = int.Parse((sender as Button).Text);
            if (mychoice == answer)
            {
                timer1.Stop();
                now = 0;
                MessageBox.Show("정답!");
                answer = new Random().Next(25) + 1;
                timer1.Start();
            }
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            now++;
            if (now > LIMIT)
            {
                (sender as Timer).Stop(); //timer1.Stop();
                MessageBox.Show("타임 오버");
                return; //메서드 종료
            }
            label1.Text = now + "/" + LIMIT;
        }
    }
}

