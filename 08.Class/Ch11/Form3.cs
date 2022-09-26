//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;

//namespace Ch11
//{
//    public partial class Form3 : Form
//    {
//        private string name;

//        public string Name { get { return name; } set { this.name = value; } }

//        public Form3()
//        {
//            InitializeComponent();
//        }

//        private void Form3_Load(object sender, EventArgs e)
//        {
//            //처음 로드 시 나라 데이터 공급
//            List<string> Counties = new List<string>() { "대한민국", "미국", "일본", "중국", "대만",
//                                                         "호주", "영국", "프랑스", "독일", "스페인" };
//            cbCountry.DataSource = Counties;
//        }

//        private void btnCounrty_Click(object sender, EventArgs e)
//        {
//            lbResultCountry.Text = "가고 싶은 나라 : " + cbCountry.Text;
//            Form4 form4 = new Form4(this);
//            form4.ShowDialog();
//        }
//    }
//}
