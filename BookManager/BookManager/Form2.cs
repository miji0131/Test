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
    public partial class Form2 : Form, IRefresh
    {
        public Form2()
        {
            InitializeComponent();
            RefreshScreen();
        }

        public void RefreshScreen()//인터페이스 구현
        {

            //bookBindingSource = Book에 바인딩됨
            //바인딩 = 묶였음 = 연결됨 혹은 연동됨 이렇게 이해하면 됨
            //즉 서로 밀접한 연관이 있다.
            bookBindingSource.DataSource = null;//화면을 갱신하기 위해서 데이터 바인딩을 리셋하는 역할
            if(DataManager.books.Count > 0 ) // 데이터가 있을 때만 데이터 소스를 설정
            {
                bookBindingSource.DataSource = DataManager.books;//데이터를 표시
            }
        }

        private void button1_Click(object sender, EventArgs e)//추가
        {
            bool existBook = false;
            //1. 입력된 ISBN이 기존의 ISBN 목록에 중복되지 않는지 확인
            foreach (var item in DataManager.books)
            {
                if (item.isbn.Equals(textBox1.Text))
                {
                    existBook = true;
                    break;
                }
            }
            // 2. 중복일 때
            if (existBook)
                MessageBox.Show("ISBN 중복! 해당 책 이미 있음!");
            //3. 중복되지 않을 때
            else
            {
                //새 책 객체 생성 및 데이터 입력
                Book newBook = new Book();
                newBook.isbn = textBox1.Text;
                newBook.name = textBox2.Text;
                DataManager.books.Add(newBook); //새로운 책을 추가
                RefreshScreen();//화면을 다시 갱신
                DataManager.Save(); //xml 파일에 저장하기 위함
            }
        }

        private void button2_Click(object sender, EventArgs e)//수정
        {
            Book book = null;
            for(int i = 0; i < DataManager.books.Count; i++)
            {
                if (DataManager.books[i].isbn.Equals(textBox1.Text))
                {
                    book = DataManager.books[i];//얕은 복사 수행
                    book.name = textBox2.Text;
                    RefreshScreen();
                    DataManager.Save();
                    break;
                }
            }

            if (book == null)
                MessageBox.Show("해당 책 없으니 수정 불가능");
        }



        private void button3_Click(object sender, EventArgs e)//삭제
        {
            bool existBook = false;//책이 목록에 존재하는지 여부를 추적
            for(int i = 0;i < DataManager.books.Count; i++)//목록에서 책찾기
            {
                if (DataManager.books[i].isbn.Equals(textBox1.Text))//ISBN이 입력된 텍스트와 일치할 때
                {
                    DataManager.books.RemoveAt(i);//책을 목록에서 제거
                    existBook = true;
                    break;
                }
            }

            if (existBook)//책존재
            {
                RefreshScreen();
                DataManager.Save();
            }
            else//책 존재하지 않음
                MessageBox.Show("해당 책이 없으므로 삭제 불가능");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Book book = dataGridView1.CurrentRow.DataBoundItem as Book;
            textBox1.Text = book.isbn;
            textBox2.Text = book.name;
        }
    }
}
