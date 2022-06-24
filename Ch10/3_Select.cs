using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜 : 2022/06/21
 * 이름 : 송환욱
 * 내용 : 데이터베이스 프로그래밍 실습
 */

// 접속 정보 -> 커넥션 생성 -> 접속 후 실행 -> 종료
namespace Ch10
{
    internal class _3_Select
    {
        static void Main1(string[] args)
        {
            //데이터베이스 접속 정보
            string server = "127.0.0.1";
            string port = "3306";
            string username = "TESTER";
            string password = "1Q2W3E";
            string database = "testdb";

            //데이터베이스 커넥션 생성
            string strConn = $"server={server};port={port};username={username};password={password};database={database}";
            MySqlConnection conn = new MySqlConnection(strConn);

            try
            {
                //데이터베이스 접속
                conn.Open();
                Console.WriteLine("성공...");

                //Sql 실행
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT * FROM `user1`";

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Console.WriteLine("{0}, {1}, {2}, {3}", reader[0], reader[1], reader[2], reader[3]);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("실패 : " + e.Message);
            }
            finally
            {
                conn.Close();
                Console.WriteLine("종료...");
            }
        }
    }
}
