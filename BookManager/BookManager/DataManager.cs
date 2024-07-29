using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

//Controller 역할
// Form1, Form2, Form3에서 중복되는 코드를 여기에 작성 
namespace BookManager
{

    public class DataManager//정적클래스:
                            //한번만 인스턴스화되며, 어디서든지 접근가능한 클래스
    {
        //정적 변수
        public static List<Book> books = new List<Book>();//책정보를 저장하는 리스트
        public static List<User> users = new List<User>();//사용자정보를 저장하는 리스트
        //상수 정의(가독성, 정확도를 위함)
        const string ISBN = "isbn";
        const string NAME = "name";
        const string USERID = "userId";
        const string USERNAME = "userName";
        const string ISBORROWED = "isBorrowed";
        const string BORROWEDAT = "borrowedAt";

        const string ID = "id";
        const string UNAME = "uName";
       
        const string BFILE = "./Books.xml";
        const string UFILE = "./Users.xml";

        
        static bool checkBorrow(string isBorrowed)
        {
            return isBorrowed.Equals("1") ? true : false;
        }
        static int checkBorrow(bool isBorrowed)
        {
            return isBorrowed ? 1 : 0;
        }
        static string makeTag(string tag, string contents)
        {
            return $"<{tag}>{contents}</{tag}>";
        }
        //딱 한번만 호출됨
        //해당 클래스를 불러올 때 한 번만 호출됨  ex1) DataManager.books
        //쉽게 말하면 프로그램 시작되고 나서 ex2) DataManager a = new DataManager();
        //DataManager라는 글자 보이면 호출되며
        //그 뒤로는 호출되지 않음
        static DataManager() //정적 생성자
                             
        {
            Load();
        }
        public static void Load()
        {
            try
            {   
                string bOutput = File.ReadAllText(BFILE); //using System.IO;
                XElement bx = XElement.Parse(bOutput);
                //책에선 LINQ쓰나 이 부분에선 LINQ 안 쓸 거임...
                books.Clear(); //books 초기화
                foreach (var item in bx.Descendants("book"))
                {
                    Book b = new Book();
                    b.isbn = item.Element(ISBN).Value;
                    b.name = item.Element(NAME).Value;
                    b.userId = item.Element(USERID).Value;
                    b.userName = item.Element(USERNAME).Value;
                    b.isBorrowed = checkBorrow(item.Element(ISBORROWED).Value);
                    b.borrowedAt = DateTime.Parse(item.Element(BORROWEDAT).Value);
                    books.Add(b);
                }
                string uOutput = File.ReadAllText(UFILE);
                XElement ux = XElement.Parse(uOutput);
                users = (from user in ux.Descendants("user")
                         select new User()
                         {
                             id = user.Element(ID).Value,
                             name = user.Element(UNAME).Value,
                         }).ToList();
            }
            catch (Exception e)
            {
                Save();
                Load();
            }
        }
        public static void Save()
        {

            // 책 정보를 XML 형식으로 변환
            //\t = 들여쓰기
            string booksOutput = "";
            booksOutput += "<books>\n";
            foreach (var item in books)
            {
                booksOutput += "\t<book>" + Environment.NewLine; //Environment.NewLine=\n
                booksOutput += "\t\t" + makeTag(ISBN, item.isbn);
                booksOutput += "\t\t" + makeTag(NAME, item.name);
                booksOutput += "\t\t" + makeTag(USERID, item.userId);
                booksOutput += "\t\t" + makeTag(USERNAME, item.userName);
                booksOutput += "\t\t" + makeTag(ISBORROWED, checkBorrow(item.isBorrowed).ToString());
                booksOutput += "\t\t" + makeTag(BORROWEDAT, item.borrowedAt.ToString());
                booksOutput += "\t</book>" + Environment.NewLine;
            }
            booksOutput += "</books>\n";

            // XML 파일에 책 정보 저장
            File.WriteAllText(BFILE, booksOutput); //기존 내용 다 지우고 새로운 내용으로 다 채워넣음

            // 사용자 정보를 XML 형식으로 변환
            string usersOutput = "";
            usersOutput += "<users>\n";
            foreach (var item in users)
            {
                usersOutput += "\t<user>\n";
                usersOutput += "\t\t" + makeTag(ID, item.id);
                usersOutput += "\t\t" + makeTag(UNAME, item.name);
                usersOutput += "\t</user>\n";
            }
            usersOutput += "</users>\n";

            // XML 파일에 사용자 정보 저장
            File.WriteAllText(UFILE, usersOutput);
        }

    }
}
