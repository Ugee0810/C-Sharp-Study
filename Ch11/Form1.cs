namespace Ch11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Button ��Ʈ��
        private void btn1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("�޽����ڽ�1");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("����� ������ �ִ� �޽����ڽ�", "�޽����ڽ�2");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("�ΰ��� ��ư�� ���� �޽����ڽ�", "�޽����ڽ�3", MessageBoxButtons.YesNo);
        }

        private void btn4_Click(object sender, EventArgs e)
        {

        }

        //TextBox ��Ʈ��
        private void btnUid_Click(object sender, EventArgs e)
        {
            string uid = txtUid.Text;
            lbUid.Text = "��� : " + uid;
        }

        private void btnName_Click(object sender, EventArgs e)
        {
            lbName.Text = "��� : " + txtName.Text;
        }

        private void btnHp_Click(object sender, EventArgs e)
        {
            lbHp.Text = "��� : " + txtHp.Text;
        }

        //CheckBox ��Ʈ��
        private void btnFruit_Click(object sender, EventArgs e)
        {
            CheckBox[] chbfruits = { chbFruit1, chbFruit2, chbFruit3, chbFruit4, chbFruit5 };

            List<string> fruits = new List<string>();

            foreach (CheckBox chb in chbfruits)
            {
                if (chb.Checked) //üũ�ڽ��� üũ
                {
                    fruits.Add(chb.Text);
                }
            }
            lbResultFruit.Text = "������ ���� : " + String.Join(", ", fruits);
        }

        //RadioButton ��Ʈ��
        private void btnGender_Click(object sender, EventArgs e)
        {
            if (rdMale.Checked)
            {
                lbResultGender.Text = "��� : ����";
            }
            else
            {
                lbResultGender.Text = "��� : ����";
            }
        }

        private void btnYear_Click(object sender, EventArgs e)
        {
            if (rdYear1.Checked)
            {
                lbResultYear.Text = "��� : 1�г�";
            }
            else if (rdYear2.Checked)
            {
                lbResultYear.Text = "��� : 2�г�";
            }
            else if (rdYear3.Checked)
            {
                lbResultYear.Text = "��� : 3�г�";
            }
            else
            {
                lbResultYear.Text = "��� : 4�г�";
            }
        }

        //Form2 ������ ���� <- �ҷ�����
        //���� ���� ShowDialog()
        private void btnForm2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void btnForm5_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.ShowDialog();
        }

    }
}