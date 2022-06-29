namespace Project3
{
    public partial class Form1 : Form
    {
        private int margin = 40;
        private int sizeNun = 30;
        private int sizeDol = 28;

        Graphics g;
        Pen pen;
        Brush wBrush, bBrush;

        //���� �����ϱ� ���� ���º���
        bool isBlack = true;

        enum STONE { none, black, white };
        STONE[,] dataSet = new STONE[19, 19];


        public Form1()
        {
            InitializeComponent();

            //�׷��� ���� ��ü �ʱ�ȭ
            g = this.CreateGraphics();
            pen = new Pen(Color.Black);
            wBrush = new SolidBrush(Color.White);
            bBrush = new SolidBrush(Color.Black);

            //�ٵ��� ��, ũ��
            this.Text = "���� v1.0";
            this.BackColor = Color.Orange;
            this.ClientSize = new Size(2 * margin + 18 * sizeNun, 2 * margin + 18 * sizeNun); //18�� ���� ���� : ������ ����
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            //��ǥ����
            int x = (e.X - margin + sizeNun / 2) / sizeNun;
            int y = (e.Y - margin + sizeNun / 2) / sizeNun;
            //Console.WriteLine("x : {0}, y : {1}", x, y);

            Rectangle dol = new Rectangle(margin + sizeNun * x - sizeNun / 2,
                                          margin + sizeNun * y - sizeNun / 2,
                                          sizeDol,
                                          sizeDol);

            if (dataSet[x, y] != STONE.none)//������ x,y �ȿ� ȭ��Ʈ�� ���� �ִٸ�
            {
                MessageBox.Show("�ش� ��ǥ�� �̹� ���� �ֽ��ϴ�..");
                return; // ��ȯ�� ���� �޼��带 ���� ���� ��Ŵ
            }

            if (isBlack)
            {
                g.FillEllipse(bBrush, dol);  //�ٵϵ� �׸���
                dataSet[x, y] = STONE.black; //������ �� 2���� �迭 ��ǥ �����͸� �ش� �迭�� �ε����� �߰�

                isBlack = false;
            }
            else
            {
                g.FillEllipse(wBrush, dol);
                dataSet[x, y] = STONE.white;

                isBlack = true;
            }

            //���� ���� ����
            CheakOmok(x, y);
        }

        //8���� üũ
        public void CheakOmok(int x, int y)
        {
            int cBlack = 1;
            int cWhite = 1;

            /*
            // ��
            for (int i = y - 1; i >= 0; i--)
            {
                if (dataSet[i, y] == dataSet[x, y])
                    count++;
                else
                    break;
            }

            // ��
            for (int i = y + 1; i <= 18; i++)
            {
                if (dataSet[i, y] == dataSet[x, y])
                    count++;
                else
                    break;
            }

            //ī��Ʈ 5 �޼� �� ����
            if (count >= 5)
            {
                MessageBox.Show("�����Դϴ�.");
                return;
            }
            count = 1;

            // ��
            for (int i = x + 1; i <= 18; i++)
            {
                if (dataSet[i, y] == dataSet[x, y])
                    count++;
                else
                    break;
            }

            // ��
            for (int i = x - 1; i >= 0; i--)
            {
                if (dataSet[i, y] == dataSet[x, y])
                    count++;
                else
                    break;
            }

            //ī��Ʈ 5 �޼� �� ����
            if (count >= 5)
            {
                MessageBox.Show("�����Դϴ�.");
                return;
            }
            count = 1;

            // ��
            for (int i = x + 1, j = y - 1; i <= 18 && j >= 0; i++, j--)
            {
                if (dataSet[i, y] == dataSet[x, y])
                    count++;
                else
                    break;
            }

            // ��
            for (int i = x + 1, j = y + 1; i <= 18 && j <= 18; i++, j++)
            {
                if (dataSet[i, y] == dataSet[x, y])
                    count++;
                else
                    break;
            }

            //ī��Ʈ 5 �޼� �� ����
            if (count >= 5)
            {
                MessageBox.Show("�����Դϴ�.");
                return;
            }
            count = 1;

            // ��
            for (int i = x - 1, j = y + 1; i >= 0 && j <= 18; i--, j++)
            {
                if (dataSet[i, y] == dataSet[x, y])
                    count++;
                else
                    break;
            }

            // ��
            for (int i = x - 1, j = y - 1; i >= 0 && j >= 0; i--, j--)
            {
                if (dataSet[i, y] == dataSet[x, y])
                    count++;
                else
                    break;
            }

            //ī��Ʈ 5 �޼� �� ����
            if (count >= 5)
            {
                MessageBox.Show("�����Դϴ�.");
                return;
            }
            count = 1;
            */
        }

        public void NewGame()
        {
            //ȭ�� ���� -> OnPaint()ȣ��
            this.Invalidate(); 
            //�����ͼ� �ʱ�ȭ
            for (int x = 0; x < 19; x++)
                for (int y = 0; y < 19; y++)
                    dataSet[x, y] = STONE.none;
            //���º��� �ʱ�ȭ
            isBlack = true;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            //�ٵ��� ���� �׸���
            for (int i = 0; i < 19; i++)
            {
                g.DrawLine(pen, new Point(margin + sizeNun * i, margin), new Point(margin + sizeNun * i, margin + 18 * sizeNun));
            }

            for (int k = 0; k < 19; k++)
            {
                g.DrawLine(pen, new Point(margin, margin + sizeNun * k), new Point(margin + 18 * sizeNun, margin + sizeNun * k));
            }
        }
    }
}