using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloCSharp006_03
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            // 로또를 콘솔과 Winform 모두에서 만들어보기
            // 로또란? 1~45 사이의 난수를 6개 맞추는 것(1등) 혹은 난수 5개와 보너스번호 하나를 맞추는것(2등)
            // 따라서 1~45사이의 난수 6개를 중복없이, 오름차순으로 출력해야 하고, 추가적인 보너스 번호를 출력해야 함,
            // 물론 보너스 번호 앞의 6개 번호랑 겹치면 안됨.
            // ex) 1 14 20 25 30 31(=오름차순 정렬됨) 보너스 : 7

            InitializeComponent();
            List<int> mylotto = new List<int>();
            Random r = new Random();
            int bnsNum = r.Next(45) + 1;//1~45  // 보너스 번호

            //1~6번째는 중복x, 오름차순 정렬
            //이 여섯개의 번호와 7번째 보너스 번호는 서로 겹치면 안 됨
            mylotto.Add(r.Next(45) + 1);    //1부터 45사이의 난수 중 하나를 선택
            while (mylotto.Count < 6)
            {
                int ran = r.Next(45) + 1;
                if (mylotto.Contains(ran)) //포함 여부 체크
                    mylotto.Remove(ran); //포함 되어 있다면 제거
                mylotto.Add(ran); //포함이 되어있든 안 되어 있든 유일한 값
            }
            mylotto.Sort(); //오름 차순 정렬;
            while (mylotto.Contains(bnsNum)) //포함되어 있다면 무한 반복, 없으면 끝
                bnsNum = r.Next(45) + 1;
            foreach (var item in mylotto)
              Console.WriteLine(item);
            Console.WriteLine("보너스 : " + bnsNum);

            Label label = new Label();
            label.AutoSize = true;
            label1.Text = "";
            label1.AutoSize = true;
            foreach (var item in mylotto)
            {
                label.Text += item + " ";
                label1.Text += item + " ";

            }
            label.Text += "보너스 번호 : " + bnsNum;
            label1.Text += "보너스 번호 : " + bnsNum;
            Controls.Add(label);


            // 어떻게 하면 당첨확률이 올라갈 지 고민해보고 자신만의 로또 생성기 만들어보기
            // 물론 그런 거 없긴 하지만... 그래도 한 번 생각해보고 만들어보기....


        }
    }
}
