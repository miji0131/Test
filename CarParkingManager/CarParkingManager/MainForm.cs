using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarParkingManager
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            label_now.Text = DateTime.Now.ToString();
            button_inParking.Click += (s, e) =>
            {
                writeLog("주차 버튼 테스트");
            };
            button_outParking.Click += (s, e) =>
            {
                writeLog("출차 버튼 테스트");
            };
        }

        private void writeLog(string v)
        {
            string contents = $"[{DateTime.Now.ToString()}]";
            contents += v;
            DataManager.printLog(contents);
            listBox_log.Items.Insert(0, contents); //최신 내용이 맨 위에 가게 됨
            //최신 내용이 맨 밑에 있게 하려면 Add를 쓰면 됨
            //listBox_log.Items.Add(contents);
        }

        private void timer_now_Tick(object sender, EventArgs e)
        {
            label_now.Text = DateTime.Now.ToString();
        }
    }
}
