using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloCSharp006_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            List<Student> students = new List<Student>();
            students.Add(new Student() { name = "이동준", grade = 1 });
            students.Add(new Student() { name = "동준이", grade = 2 });
            students.Add(new Student() { name = "준동이", grade = 3 });
            students.Add(new Student() { name = "준준이", grade = 4 });
            students.Add(new Student() { name = "동동이", grade = 1 });
            students.Add(new Student() { name = "이이이", grade = 2 });

            for(int i = 0; i < students.Count; i++) 
            {
                Label label = new Label();
                label.Text = $"{students[i].grade}학년 {students[i].name} 학생";
                label.AutoSize = true;
                label.Location = new Point(13, 13 + (23 + 3) * i);
                Controls.Add(label);
            }
            // 뭔가를 제거하기 위해선 역 for문을 쓰는 게 좋다.
            for(int i = students.Count - 1; i >= 0; i--) 
            {
                if (students[i].grade > 1) // 2, 3, 4 학년 제거
                {
                    students.RemoveAt(i);   // i번째 거 지우겠다! 
                   /* Remove = 특정 값 찾아서 하나를 지움
                    Remove("12") 하면 string List 중에 문자열 "12"를 지움

                    ex. ["12", "34", "99"]-> ["34", "99"]

                    RemoveAt = 특정 인덱스를 찾아서 그 인덱스 부분을 지움
                    RemoveAt(1)

                    ex. ["12", "34", "99"]-> ["12", "99"]*/
                }
            }

            for (int i = 0;i < students.Count;i++) 
            {
                Label label = new Label();
                label.Text = $"{students[i].grade}학년 {students[i].name} 학생";
                label.AutoSize = true;
                label.Location = new Point(130, 13 + (23 + 3) * i);
                Controls.Add(label);
            }
        }
          
        

    }
}
