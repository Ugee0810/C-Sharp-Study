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
            //DB ���� ����
            string server = "127.0.0.1";
            string port = "3306";
            string username = "TESTER";
            string password = "1Q2W3E";
            string database = "testdb";

            //DB Ŀ�ؼ�
            string strconn = $"server={server};port={port};username={username};password={password};database={database};";
            MySqlConnection conn = new MySqlConnection(strconn);

            //������ ���� ����Ʈ ����
            List<User> users = new List<User>(); //UserŬ���� -> users�� DGV�� �Է�

            try
            {
                //DB ����
                conn.Open();

                //Sql ����
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT * FROM `user1`";

                MySqlDataReader reader = cmd.ExecuteReader();

                //��� ���
                while (reader.Read()) //�� �� ����ŭ �ݺ�
                {
                    User user = new User();
                    user.Uid = reader[0].ToString(); //reader�迭�� �����ͺ��̽��� ��
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
                //���� ����
                conn.Close();
            }

            //������ �׸��� �� ������ ����
            dataGridView1.DataSource = users;
        }

        //��ȸ
        private void btnSelect_Click(object sender, EventArgs e)
        {
            
        }

        //�߰�
        private void btnInsert_Click(object sender, EventArgs e)
        {
            string uid = txtUid.Text.ToString();
            string name = txtName.Text.ToString();
            string hp = txtHp.Text.ToString();
            string age = nAge.Text.ToString();

            //DB ���� ����
            string server = "127.0.0.1";
            string port = "3306";
            string username = "TESTER";
            string password = "1Q2W3E";
            string database = "testdb";

            //DB Ŀ�ؼ�
            string strconn = $"server={server};port={port};username={username};password={password};database={database};";
            MySqlConnection conn = new MySqlConnection(strconn);

            try
            {
                //DB ����
                conn.Open();

                //Sql ����
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
            MessageBox.Show("�����Ͱ� ����Ǿ����ϴ�.", "Insert �Ϸ�");
        }


        //����
        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }


        //����
        private void btnDelete_Click(object sender, EventArgs e)
        {

        }


        //����
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