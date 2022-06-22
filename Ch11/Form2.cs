using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch11
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        //Form2가 로드될 때 이 메서드 호출
        private void Form2_Load(object sender, EventArgs e)
        {
            //콤보박스 데이터 공급
            List<string> position = new List<string>() { "사원", "대리", "과장", "차장", "부장" };
            cbPosition.DataSource = position;

            string[] hobbies = { "등산하기", "운동하기", "영화보기", "독서하기", "게임하기" };
            cbHobby.DataSource = hobbies;

            //리스트박스 데이터 공급
            string[] country = { "대한민국", "미국", "일본", "중국", "대만",
                                 "호주", "영국", "프랑스", "독일", "스페인" };
            lstCountry.DataSource = country;

            //DGV 데이터 공급
            List<Member> members = new List<Member>();
            members.Add(new Member("A101", "김유신", "010-1234-1001", 24));
            members.Add(new Member("A102", "김춘추", "010-1234-1002", 21));
            members.Add(new Member("A103", "장보고", "010-1234-1003", 34));
            members.Add(new Member("A104", "강감찬", "010-1234-1004", 44));
            members.Add(new Member("A105", "이순신", "010-1234-1005", 54));

            dgvMember.DataSource = members;
        }

        private void btnPosition_Click(object sender, EventArgs e)
        {
            lbResultPosition.Text = "결과 : " + cbPosition.Text;
        }

        private void btnHobby_Click(object sender, EventArgs e)
        {
            lbResultHobby.Text = "결과 : " + cbHobby.Text;
        }

        //ListBox
        private void lstCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbResultCountry.Text = "결과 : " + lstCountry.Text;
        }

        //DGV 셀 하나 클릭할 때 이벤트
        private void dgvMember_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //Form3
        private void btnForm3_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }
    }
}
