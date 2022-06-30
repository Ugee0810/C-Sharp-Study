namespace Project4
{
    public partial class Form1 : Form
    {
        Graphics g;
        Rectangle   racket = new Rectangle();
        Rectangle[] blocks = new Rectangle[100];

        bool[] ballVisible = new bool[100]; // ������ ���� �浹 �� ������ų ���º���

        Rectangle ball;

        Brush racketColor = new SolidBrush(Color.Red);
        Brush blockColor  = new SolidBrush(Color.Orange);
        Brush ballColor   = new SolidBrush(Color.Gold);
        Pen   pen         = new Pen(Color.Black);

        //�� ������
        int formW = 300;
        int formH = 500;

        // �� ����
        int nBlocks = 20;

        // ����
        int racketY = 480;
        int racketW = 50;
        int racketH = 10;

        // ��
        int blockY = 60;
        int blockW = 30;
        int blockH = 20;

        int ballW = 10;
        int ballH = 10;


        double slope = 1; // ����
        double vDir = 1;  // �� �������� ����

        Random rand = new Random();


        public Form1()
        {
            InitializeComponent();

            // �� ������
            this.ClientSize = new Size(formW, formH);
            this.Text = "BlockBreak v1.0";

            // �׷��� ��ü ����
            g = this.CreateGraphics();

            // �� �ʱ�ȭ
            InitBlocks();

            // ���� �ʱ�ȭ
            InitRacket();

            // �� �ʱ�ȭ
            InitBall();
        }

        // ��� �ʱ�ȭ �޼���
        public void InitBlocks() 
        {
            for (int i = 0; i < nBlocks; i++)
            {
                blocks[i] = new Rectangle(i % 10 * blockW,
                                          blockY + blockH * (i / 10),
                                          blockW - 1,
                                          blockH - 1);
                // ��� Visible �� �ʱ�ȭ
                ballVisible[i] = true;
            }
        }

        // ���� �ʱ�ȭ �޼���
        public void InitRacket()
        {
            racket.X = formW / 2 - racketW / 2;
            racket.Y = racketY;
            racket.Width = racketW;
            racket.Height = racketH;
        }

        // �� ���� �ʱ�ȭ �޼���
        public void InitBall()
        {
            ball = new Rectangle();
            ball.X = formW / 2 - ballW / 2;
            ball.Y = blockY + nBlocks / 10 * blockH;
            ball.Width = ballW;
            ball.Height = ballH;

            // ���Ⱚ �ʱ�ȭ
            slope = rand.Next(1, 20) / 10.0;

            if (rand.Next(2) % 2 == 1)
            {
                slope = -slope;
            }
            vDir = 1;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            // ���� �׸���
            for (int i = 0; i < nBlocks; i++)
            {
                // ballVisible���� true�� ���� �׸���.
                if (ballVisible[i]) 
                    g.FillRectangle(blockColor, blocks[i]);
            }

            // ���� �׸���
            g.FillRectangle(racketColor, racket);

            // �� �׸���
            g.FillEllipse(ballColor, ball);
            g.DrawEllipse(pen, ball);
        }

        private void myTimer_Tick(object sender, EventArgs e)
        {
            //Console.WriteLine("Tick!");
            double dx = 0;
            double unit = ballW;

            dx = unit / slope;

            ball.X += (int) dx;
            ball.Y += (int) (vDir * slope * dx);

            // ball�� �¿� ���� �浹 �ߴ��� üũ
            if (ball.X < 0 || ball.X > formW - ballW)
            {
                slope = -slope;
            }

            // ball�� ���Ͽ� �¾Ҵ��� üũ
            //IntersectsWith() : Rectangle���� �Լ� - ���� Rectangle�� �浹�� �� �̺�Ʈ
            if (ball.Y < 0 || racket.IntersectsWith(ball)) 
            {
                vDir = -vDir;
            }

            // ball�� ������ �¾Ҵ��� üũ
            for (int i = 0; i < nBlocks; i++)
            {
                if (ball.IntersectsWith(blocks[i]))
                {
                    // �浹 ������ �ݻ� ��Ų��.
                    vDir = -vDir;
                    // ������ ��Ȱ��ȭ
                    ballVisible[i] = false;
                }
            }

            // ���� Ŭ���̾�Ʈ �������� �ʰ��� �� :: ���ӿ���
            if (ball.Y > ClientSize.Height)
            {
                // ȭ�� �ε� ���� :: ticker ����
                myTimer.Stop();

                DialogResult result = MessageBox.Show("�ٽ� �����Ͻðڽ��ϱ�?", "Ȯ��", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    InitBlocks();
                    InitRacket();
                    InitBall();
                    myTimer.Start();
                }
                else Close();
            }
            Invalidate();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                racket.X -= 10;
            }
            else if (e.KeyCode == Keys.Right)
            {
                racket.X += 10;
            }
            Invalidate();
        }
    }
}