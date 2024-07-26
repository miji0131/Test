using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookManager
{
    public partial class Form1 : Form,IRefresh
    {
        public Form1()
        {
            InitializeComponent();
            RefreshScreen();
        }

        public void RefreshScreen()
        {
            label1.Text = "전체 도서 수:" + DataManager.books.Count;//이때 Load()
            label2.Text = "전체 회원 수:" + DataManager.books.Count;


        }

        private void 도서관리ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide(); //현재 창 숨김
            Form2 f = new Form2();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.ShowDialog(); //모달, 뒤에 꺼 선택 못 하고, 코드가 이 지점에 멈춤
            Show(); //현재 창 보이게 함

        }

        private void 사용자관리ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            Form3 f = new Form3();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.ShowDialog();
            Show();
        }
    }
}

