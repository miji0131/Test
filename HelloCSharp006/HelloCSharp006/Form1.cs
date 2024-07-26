using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloCSharp006
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();  // 디자인 창에서 디자인 된 걸 화면에 뿌림

            mybutton.Text = "코드에서 변경!";  //버튼 위에 적힌 테스트 지정
            mybutton.Width = 100;    // 버튼의 너비 임의 조정
            for (int i = 0; i < 5; i++)
            {
                Button button = new Button();
                Point point = new Point();// 위치 저장하는 구조체
                point.X = 13;
                point.Y = 100 + 13 + (23 + 3) * i;
                button.Location = point;
                button.Text = "동작 생성" + (i + 1) + "번째";
                Controls.Add(button);
            }

        }


    }

    
}
