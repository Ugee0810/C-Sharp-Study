using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    internal class DBAccess
    {
        //DB 접속 정보  
        private const string SERVER   = "127.0.0.1";
        private const string PORT     = "3306";
        private const string USERNAME = "TESTER";
        private const string PASSWORD = "1Q2W3E";
        private const string DATABASE = "testdb";
        private const string TABLE    = "user2";

        //싱글톤 -> 외부에서 DBAccess를 참조 못함 오직 get만 가능
        private static DBAccess instance = new DBAccess();
        public static DBAccess Instance { get { return instance; } }
        private DBAccess() { }

        //DB 커넥트 메서드
        public MySqlConnection Connect() // <- return할 타입을 본다.
        {
            string strConn = $"server={SERVER};port={PORT};username={USERNAME};password={PASSWORD};database={DATABASE};";
            MySqlConnection conn = new MySqlConnection(strConn);
            return conn;
        }

        public void InsertUser(string uid, string name, string hp, decimal age)
        {
            //DB 커넥트 메서드 호출
            MySqlConnection conn = Connect();

            try
            {
                conn.Open();

                //Sql 실행
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = $"INSERT INTO `{TABLE}` VALUES ('{uid}', '{name}', '{hp}', {age})";
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

        public void SelectUser()
        {

        }

        public List<User> SelectUsers()
        {
            //DB커넥트 메서드 호출
            MySqlConnection conn = Connect();

            //데이터 공급 리스트 생성
            List<User> users = new List<User>(); //User클래스 -> users를 DGV에 입력

            try
            {
                conn.Open();

                //Sql 실행
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = $"SELECT * FROM `{TABLE}`";

                MySqlDataReader reader = cmd.ExecuteReader();

                //결과 리스트 생성
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
            catch (Exception except) { Console.WriteLine(except.Message); }
            finally
            {
                conn.Close();
            }
            return users;
        }

        public void UpdateUser(string uid, string name, string hp, decimal age) 
        {
            MySqlConnection conn = Connect();

            try
            {
                conn.Open();

                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = $"UPDATE {TABLE} SET `name`='{name}', `hp`='{hp}', `age`={age} WHERE `uid`='{uid}'";
                cmd.ExecuteNonQuery();
            }
            catch (Exception except) { Console.WriteLine(except.Message); }
            finally
            {
                conn.Close();
            }
            MessageBox.Show("데이터가 수정되었습니다.", "Update 완료");
        }        

        public void DeleteUser(string uid)
        {
            MySqlConnection conn = Connect();

            try
            {
                conn.Open();

                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = $"Delete FROM {TABLE} WHERE `uid`='{uid}'";
                cmd.ExecuteNonQuery();
            }
            catch (Exception except) { Console.WriteLine(except.Message); }
            finally
            {
                conn.Close();
            }
            MessageBox.Show("데이터가 삭제되었습니다.", "Delete 완료");
        }
    }
}
