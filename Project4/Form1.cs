namespace Project4
{
    public partial class Form1 : Form
    {
        // �׷���
        Graphics g;
        Brush blockColor         = new SolidBrush(Color.Orange);
        Brush obstacleBlockColor = new SolidBrush(Color.Gray);
        Brush ballColor          = new SolidBrush(Color.Gold);
        Brush racketColor        = new SolidBrush(Color.Red);
        Pen   pen                = new Pen(Color.Black);

        Rectangle[]  rBlocks         = new Rectangle[100];
        Rectangle[]  rObstacleBlocks = new Rectangle[10];
        Rectangle    rBall;
        Rectangle    rRacket         = new Rectangle();

        // �� ������
        int formW = 300;
        int formH = 500;

        // ���
        int blockY  = 50;
        int blockW  = 30;
        int blockH  = 20;
        int nBlocks = 1;
        int clearedBlocks = 0; // �ı��� ��� ī��Ʈ
        bool[] blockVisible = new bool[100]; // ������ ���� �浹 ���θ� ��Ÿ���� ���º���

        // ��ֹ� ���
        int    levelBlockW          = 20;
        int    levelBlockH          = 15;
        int    nObstacleBlocks      = 1; // ��ֹ� ��� ���� ī��Ʈ
        double xMoveDirectionNSpeed = 1; // ��ֹ� ��� ���� ����
        Random randomBlockXY        = new Random();
        Random randomMoveSpeed      = new Random();
        Random randomBlockDirection = new Random();
        // ��
        int    ballW = 10;
        int    ballH = 10;
        double slope = 1; // ����
        double vDir  = 1; // �� �������� ����
        Random randomBall  = new Random(); // ������ �� ������ ������ �������� �ֱ� ���� ����

        // ����
        int racketY = 480;
        int racketW = 250;
        int racketH = 10;

        public Form1()
        {
            InitializeComponent();
            FormSize();           // �� ������
            g = CreateGraphics(); // �׷��� ��ü ����
            InitBlocks();         // �ʱ�ȭ-��
            InitObstacleBlocks(); // �ʱ�ȭ-��ֹ� ���
            InitBall();           // �ʱ�ȭ-�� ����
            InitRacket();         // �ʱ�ȭ-����
        }

        
        public void FormSize() 
        {
            ClientSize = new Size(formW, formH);
            Text       = "BlockBreak v1.2";
        } // �� ������

        public void InitBlocks() 
        {
            for (int i = 0; i < nBlocks; i++)
            {
                rBlocks[i] = new Rectangle(i % 10 * blockW,
                                           blockY + blockH * (i / 10),
                                           blockW - 1,
                                           blockH - 1);
                blockVisible[i] = true;
                clearedBlocks = 0;
            }
        } // ��� �ʱ�ȭ �޼���

        public void InitObstacleBlocks() 
        {
            for (int i = 0; i < nObstacleBlocks; i++)
            {
                rObstacleBlocks[i] = new Rectangle(randomBlockXY.Next(50, 250),
                                                   randomBlockXY.Next(150, 250),
                                                   levelBlockW,
                                                   levelBlockH);
                //�̵� �ӵ�
                xMoveDirectionNSpeed = randomMoveSpeed.Next(50, 100) / 10.0;
                // �̵� ���� �ʱ�ȭ
                if (randomBlockDirection.Next(2) % 2 == 1) xMoveDirectionNSpeed = -xMoveDirectionNSpeed;
            }
        } // ��ֹ� ��� �ʱ�ȭ �޼���

        public void InitBall() 
        {
            rBall        = new Rectangle();
            rBall.X      = formW / 2 - ballW / 2;
            rBall.Y      = blockY + nBlocks / 10 * blockH;
            rBall.Width  = ballW;
            rBall.Height = ballH;

            // ���Ⱚ �ʱ�ȭ
            slope = randomBall.Next(10, 20) / 10.0;
            if (randomBall.Next(2) % 2 == 1) slope = -slope;
            vDir = 1;
        } // �� ���� �ʱ�ȭ �޼���

        public void InitRacket() // ���� �ʱ�ȭ �޼���
        {
            rRacket.X      = formW / 2 - racketW / 2;
            rRacket.Y      = racketY;
            rRacket.Width  = racketW;
            rRacket.Height = racketH;
            
        }

        public void LevelUp()
        {
            nObstacleBlocks++;
            racketW -= 20;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            for (int i = 0; i < nBlocks; i++)
            {
                // blockVisible���� true�� ���� ��� �׸���
                if (blockVisible[i] == true) 
                    g.FillRectangle(blockColor, rBlocks[i]);
            } // �Ű����� nBlocks�� ��ŭ ���� ����

            for (int k = 0; k < nObstacleBlocks; k++)
            {
                //��ֹ� ��� �׸���
                g.FillRectangle(obstacleBlockColor, rObstacleBlocks[k]);
                g.DrawRectangle(pen, rObstacleBlocks[k]);
            } // �Ű����� nObstacleBlocks�� ��ŭ ��ֹ� ���� ����

            // ���� �׸���
            g.FillRectangle(racketColor, rRacket);

            // �� �׸���
            g.FillEllipse(ballColor, rBall);
            g.DrawEllipse(pen, rBall);
        }

        private void myTimer_Tick(object sender, EventArgs e)
        {
            double dx = 0;
            dx = ballW / slope;
            rBall.X += (int)dx;
            rBall.Y += (int)(vDir * slope * dx);
            if (rBall.X < 0 || rBall.X > formW - ballW) slope = -slope;     // ���� �¿� ���� �浹(���� ���� ����)
            if (rBall.Y < 0 || rRacket.IntersectsWith(rBall)) vDir = -vDir; // ���� õ���̳� ���Ͽ� �浹(���� ���� ����) | Rectangle.IntersectsWith() :: ���� Rectangle ��ü�� �浹�� �� �̺�Ʈ

            double bx = 0;
            bx = levelBlockW / xMoveDirectionNSpeed;
            
            for (int i = 0; i < nObstacleBlocks; i++)
            {
                rObstacleBlocks[i].X += (int)bx;
                
                if (rObstacleBlocks[i].X < 0 || rObstacleBlocks[i].X > formW - levelBlockW)
                {
                    xMoveDirectionNSpeed = -xMoveDirectionNSpeed;
                }
                
                if (rObstacleBlocks[i].IntersectsWith(rBall))
                {
                    vDir = -vDir;
                } // ���� ��ֹ� ������ �浹(�ݴ� ���� ����)

            } // ��ֹ� ��� Ʈ����

            for (int i = 0; i <= nBlocks; i++)
            {
                if (blockVisible[i] == true && rBlocks[i].IntersectsWith(rBall))
                {
                    blockVisible[i] = false; // ������ �� ���̰� ��Ȱ��ȭ
                    vDir = -vDir;            // �浹 ����� �ݴ� ���� ����

                    if (++clearedBlocks >= nBlocks)
                    {
                        myTimer.Stop(); // ȭ�� �ε� ���� :: ticker ����
                        DialogResult result = MessageBox.Show("Ŭ���� �ϼ̽��ϴ�. ���� ������ �����Ͻðڽ��ϱ�?",
                                                              "Ȯ��",
                                                              MessageBoxButtons.YesNo);
                        if (result == DialogResult.Yes)
                        {
                            LevelUp();
                            InitBlocks();
                            InitObstacleBlocks();
                            InitRacket();
                            InitBall();
                            myTimer.Start();
                        }
                        else Close();
                    }
                }
            } // ��/���� ��ȣ�ۿ�, ���� Ŭ����

            if (rBall.Y > ClientSize.Height)
            {
                myTimer.Stop(); // ȭ�� �ε� ���� - ticker ����
                DialogResult result = MessageBox.Show("�ٽ� �����Ͻðڽ��ϱ�?",
                                                      "Ȯ��",
                                                      MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    InitBlocks();
                    InitObstacleBlocks();
                    InitRacket();
                    InitBall();
                    myTimer.Start();
                }
                else Close();
            } // ���ӿ��� - ���� Ŭ���̾�Ʈ �������� �ʰ��� ��

            Invalidate();
        }
        
        private void Form1_KeyDown(object sender, KeyEventArgs e) // Ű���� ����
        {
            if (e.KeyCode == Keys.Left)
                rRacket.X -= 40;                                              // �� �̵� ��
                if (rRacket.X < 0) rRacket.X = 0;                             // �� ȭ�� �ʰ� ����
            else if (e.KeyCode == Keys.Right)
                rRacket.X += 40;                                              // �� �̵� ��
                if (rRacket.X > formW - racketW) rRacket.X = formW - racketW; // �� ȭ�� �ʰ� ����
            else if (e.KeyCode == Keys.Space) myTimer.Stop();                 // ����
            else if (e.KeyCode == Keys.Enter) myTimer.Start();                // �簳
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
// ��[��]Ŭ���� �� ���� �߰�(Ŭ���� �� �� ���� ������ �۾���, �����̴� ��ֹ� �߰�)
// ��[ڱ]���� ���� -> Die -> ��� ����� ���(�ð�(�ڵ�), ���ھ�(�ڵ�), ����(�ڵ�), �̸�)
// ��[ڱ]�ǽ� �ð�(1s = -10��) / ���� ���ʽ�(+1,000, +3,000, +5,000) / ��� �� �� ����(+100) / ��� ���� �ı� ����(100 + 20 *= 2)
// ��[ڱ]�����ͺ��̽� ����