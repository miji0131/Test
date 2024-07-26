using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloCSharp009_04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

          
            for (int i = 0; i < Controls.Count; i++)//모든 폼 컨트롤에 대해 반복
            {
                if (Controls[i] is GroupBox)// 현재 컨트롤이 그룹 박스인지 확인
                {
                    var innerGroup = Controls[i] as GroupBox; // 현재 그룹 박스에 대한 참조를 가져옴
                    foreach (var item in innerGroup.Controls)// 그룹 박스 내의 각 컨트롤에 대해 반복
                    {
                        MessageBox.Show(item.ToString());// 각 컨트롤을 문자열로 변환하여 메시지 박스로 출력
                    }

                    for (int j = 0; j < innerGroup.Controls.Count; j++)// 그룹 박스 내의 각 컨트롤의 Text 속성을 출력
                    {
                        MessageBox.Show(innerGroup.Controls[j].Text);
                    }
                }
            }
        }
    }
}
