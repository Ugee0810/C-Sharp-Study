using MySql.Data.MySqlClient;

namespace Project2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //DB 접속 정보
            string server = "127.0.0.1";
            string port = "3306";
            string username = "TESTER";
            string password = "1Q2W3E";
            string database = "testdb";

            //DB 커넥션
            string strconn = $"server={server};port={port};username={username};password={password};database={database};";
            MySqlConnection conn = new MySqlConnection(strconn);

            //데이터 공급 리스트 생성
            List<User> users = new List<User>(); //User클래스 -> users를 DGV에 입력

            try
            {
                //DB 접속
                conn.Open();

                //Sql 실행
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT * FROM `user1`";

                MySqlDataReader reader = cmd.ExecuteReader();

                //결과 출력
                while (reader.Read()) //열 개 수만큼 반복
                {
                    User user = new User();
                    user.Uid = reader[0].ToString(); //reader배열은 데이터베이스의 행
                    user.Name = reader[1].ToString();
                    user.Hp = reader[2].ToString();
                    user.Age = Convert.ToInt32(reader[3]);

                    users.Add(user);
                }
            }
            catch (Exception except)
            {
                Console.WriteLine(except.Message);
            }
            finally
            {
                //접속 종료
                conn.Close();
            }

            //데이터 그리드 뷰 데이터 공급
            dataGridView1.DataSource = users;
        }

        //조회
        private void btnSelect_Click(object sender, EventArgs e)
        {
            
        }

        //추가
        private void btnInsert_Click(object sender, EventArgs e)
        {
            string uid = txtUid.Text.ToString();
            string name = txtName.Text.ToString();
            string hp = txtHp.Text.ToString();
            string age = nAge.Text.ToString();

            //DB 접속 정보
            string server = "127.0.0.1";
            string port = "3306";
            string username = "TESTER";
            string password = "1Q2W3E";
            string database = "testdb";

            //DB 커넥션
            string strconn = $"server={server};port={port};username={username};password={password};database={database};";
            MySqlConnection conn = new MySqlConnection(strconn);

            try
            {
                //DB 접속
                conn.Open();

                //Sql 실행
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = $"INSERT INTO `user1` VALUES ('{uid}', '{name}', '{hp}', {age})";
                cmd.ExecuteNonQuery();

            }
            catch (Exception except)
            {
                Console.WriteLine(except.Message);
            }
            finally
            {
                conn.Close();
            }
            MessageBox.Show("데이터가 저장되었습니다.", "Insert 완료");
        }


        //수정
        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }


        //삭제
        private void btnDelete_Click(object sender, EventArgs e)
        {

        }


        //리셋
        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        public void Reset()
        {
            txtUid.Text = "";
            txtName.Text = "";
            txtHp.Text = "";
            nAge.Text = "0";
        }
    }
}