namespace Project4
{
    public partial class Form1 : Form
    {
        Graphics g;
        Rectangle racket = new Rectangle();
        Rectangle[] blocks = new Rectangle[100];
        Rectangle ball;

        Brush racketColor = new SolidBrush(Color.Red);
        Brush blockColor = new SolidBrush(Color.Orange);
        Brush ballColor = new SolidBrush(Color.Gold);
        Pen pen = new Pen(Color.Black);

        int formW = 300;
        int formH = 500;

        int nBlocks = 20;

        int racketY = 480;
        int racketW = 50;
        int racketH = 10;

        int blockY = 60;
        int blockW = 30;
        int blockH = 20;

        int ballW = 10;
        int ballH = 10;


        double slope; // 기울기
        double vDir;  // 공 수직방향 여부


        public Form1()
        {
            InitializeComponent();

            // 폼 사이즈
            this.ClientSize = new Size(formW, formH);
            this.Text = "BlockBreak v1.0";

            // 그래픽 객체 생성
            g = this.CreateGraphics();

            // 블록 초기화
            for (int i = 0; i < nBlocks; i++)
            {
                blocks[i] = new Rectangle(i % 10 * blockW,
                                          blockY + blockH * (i / 10),
                                          blockW - 1,
                                          blockH - 1);
            }

            // 라켓 초기화
            racket.X = formW / 2 - racketW / 2;
            racket.Y = racketY;
            racket.Width = racketW;
            racket.Height = racketH;

            // 공 초기화
            ball = new Rectangle();
            ball.X = formW / 2 - ballW / 2;
            ball.Y = blockY + nBlocks / 10 * blockH;
            ball.Width = ballW;
            ball.Height = ballH;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            // 벽돌 그리기
            for (int i = 0; i < nBlocks; i++)
            {
                g.FillRectangle(blockColor, blocks[i]);
            }

            // 라켓 그리기
            g.FillRectangle(racketColor, racket);

            // 공 그리기
            g.FillEllipse(ballColor, ball);
            g.DrawEllipse(pen, ball);
        }

        private void myTimer_Tick(object sender, EventArgs e)
        {
            Console.WriteLine("Tick!");
        }
    }
}