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
    public partial class Form4 : Form
    {
        private Form3 form3;

        public Form4(Form3 form3)
        {
            InitializeComponent();
            this.form3 = form3;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            List<string> firstActivity = new List<string>() { "식사하기", "체크인하기", "유심발급", "관광지이동" };
            cbFirstActivity.DataSource = firstActivity;
        }

        private void btnFirstActivity_Click(object sender, EventArgs e)
        {
            form3.Name = "dfdfddf";
            Close();
        }
    }
}
