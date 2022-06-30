namespace Project4
{
    public partial class Form1 : Form
    {
        // �׷���
        Graphics g;
        Brush blockColor  = new SolidBrush(Color.Orange);
        Brush ballColor   = new SolidBrush(Color.Gold);
        Brush racketColor = new SolidBrush(Color.Red);
        Pen   pen         = new Pen(Color.Black);

        Rectangle[]  blocks = new Rectangle[100];
        Rectangle    ball;
        Rectangle    racket = new Rectangle();

        // �� ������
        int formW = 300;
        int formH = 500;

        // �� ����
        int    nBlocks      = 1;
        bool[] blockVisible = new bool[100]; // ������ ���� �浹 ���θ� ��Ÿ���� ���º���

        // ��
        int blockY = 50;
        int blockW = 30;
        int blockH = 20;
        int clearedBlocks = 0;

        // ��
        int    ballW = 15;
        int    ballH = 15;
        double slope = 1; // ����
        double vDir  = 1; // �� �������� ����
        Random rand  = new Random(); // ������ �� ������ ������ �������� �ֱ� ���� ����

        // ����
        int racketY = 480;
        int racketW = 150;
        int racketH = 10;

        public Form1()
        {
            InitializeComponent();
            FormSize();           // �� ������
            g = CreateGraphics(); // �׷��� ��ü ����
            InitBlocks();         // �ʱ�ȭ-�� 
            InitBall();           // �ʱ�ȭ-�� ����
            InitRacket();         // �ʱ�ȭ-����
        }

        // �� ������
        public void FormSize()
        {
            ClientSize = new Size(formW, formH);
            Text       = "BlockBreak v1.2";
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
                blockVisible[i] = true; // ��� Visible �� �ʱ�ȭ
                clearedBlocks = 0;
            }
        }

        // �� ���� �ʱ�ȭ �޼���
        public void InitBall()
        {
            ball        = new Rectangle();
            ball.X      = formW / 2 - ballW / 2;
            ball.Y      = blockY + nBlocks / 10 * blockH;
            ball.Width  = ballW;
            ball.Height = ballH;

            // ���Ⱚ �ʱ�ȭ
            slope = rand.Next(5, 20) / 10.0;
            if (rand.Next(2) % 2 == 1) slope = -slope;
            vDir = 1;
        }

        // ���� �ʱ�ȭ �޼���
        public void InitRacket()
        {
            racket.X      = formW / 2 - racketW / 2;
            racket.Y      = racketY;
            racket.Width  = racketW;
            racket.Height = racketH;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            // �Ű����� nBlocks�� ��ŭ ���� ����
            for (int i = 0; i < nBlocks; i++)
            {
                // blockVisible���� true�� ���� �׸���.
                if (blockVisible[i] == true) 
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
            double dx = 0;
            double unit = ballW;

            dx = unit / 5 / slope;

            ball.X += (int)dx;
            ball.Y += (int)(vDir * slope * dx);

            // ���� �¿� ���� �浹(���� ���� ����)
            if (ball.X < 0 || ball.X > formW - ballW) // x : 1 ~ 489 ���� ����
                slope = -slope;

            // ���� õ���̳� ���Ͽ� �浹(���� ���� ����)
            if (ball.Y < 0 || racket.IntersectsWith(ball)) // Rectangle.IntersectsWith() :: ���� Rectangle ��ü�� �浹�� �� �̺�Ʈ
                vDir = -vDir;

            // ���� ������ �浹�� üũ
            for (int i = 0; i <= nBlocks; i++)
            {
                if (blockVisible[i] == true && blocks[i].IntersectsWith(ball))
                {
                    vDir = -vDir;            // �浹 ����� �ݴ� ���� ����
                    blockVisible[i] = false; // ������ �� ���̰� ��Ȱ��ȭ

                    if (++clearedBlocks >= nBlocks)
                    {
                        myTimer.Stop(); // ȭ�� �ε� ���� :: ticker ����
                        DialogResult result = MessageBox.Show("Ŭ���� �ϼ̽��ϴ�. ���� ������ �����Ͻðڽ��ϱ�?",
                                                              "Ȯ��",
                                                              MessageBoxButtons.YesNo);
                        if (result == DialogResult.Yes)
                        {
                            InitBlocks();
                            InitRacket();
                            InitBall();
                            myTimer.Start();
                        }
                        else Close();
                    }
                    //Console.WriteLine(clearedBlocks);
                }
            }

            // ���ӿ��� :: ���� Ŭ���̾�Ʈ �������� �ʰ��� ��
            if (ball.Y > ClientSize.Height)
            {
                myTimer.Stop(); // ȭ�� �ε� ���� :: ticker ����
                DialogResult result = MessageBox.Show("�ٽ� �����Ͻðڽ��ϱ�?",
                                                      "Ȯ��",
                                                      MessageBoxButtons.YesNo);
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

        // Ű���� ����
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
                racket.X -= 40;                                             // �� �̵� ��
                if (racket.X < 0) racket.X = 0;                             // �� ȭ�� �ʰ� ����
            else if (e.KeyCode == Keys.Right)
                racket.X += 40;                                             // �� �̵� ��
                if (racket.X > formW - racketW) racket.X = formW - racketW; // �� ȭ�� �ʰ� ����
            else if (e.KeyCode == Keys.Space) myTimer.Stop();               // ����
            else if (e.KeyCode == Keys.Enter) myTimer.Start();              // �簳
                
            Invalidate();
        }
    }
}

// �������� �ʼ� ���� ���
// ��[��]���� ȭ�� ������ �縮���� �ʰ� �ϱ� 
// ��[��]���� ������ �浹 ��ȿȭ
// ��[��]��� ���� ���� �� �ȳ�, ȿ��
// �߰� ����� ��
// ��[��]���ȭ
// ��[��]�Ͻ�����, �簳 ��ư �߰� (��� ���� ���¿��� �ٰ� ������)
// ��[ڱ]Ŭ���� �� ���� �߰�(Ŭ���� �� �� ���� ������ �۾���, �����̴� ��ֹ� �߰�)
// ��[ڱ]���� ���� -> Die -> ��� ����� ���(�ð�(�ڵ�), ���ھ�(�ڵ�), ����(�ڵ�), �̸�)
// ��[ڱ]�ǽ� �ð�(1s = -10��) / ���� ���ʽ�(+1,000, +3,000, +5,000) / ��� �� �� ����(+100) / ��� ���� �ı� ����(100 + 20 *= 2)
// ��[ڱ]�����ͺ��̽� ����