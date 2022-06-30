namespace Project4
{
    public partial class Form1 : Form
    {
        Graphics g;
        Rectangle   racket = new Rectangle();
        Rectangle[] blocks = new Rectangle[100];

        bool[] ballVisible = new bool[100]; // 벽돌이 공과 충돌 시 삭제시킬 상태변수

        Rectangle ball;

        Brush racketColor = new SolidBrush(Color.Red);
        Brush blockColor  = new SolidBrush(Color.Orange);
        Brush ballColor   = new SolidBrush(Color.Gold);
        Pen   pen         = new Pen(Color.Black);

        //폼 사이즈
        int formW = 300;
        int formH = 500;

        // 블럭 갯수
        int nBlocks = 20;

        // 라켓
        int racketY = 480;
        int racketW = 50;
        int racketH = 10;

        // 블럭
        int blockY = 60;
        int blockW = 30;
        int blockH = 20;

        int ballW = 10;
        int ballH = 10;


        double slope = 1; // 기울기
        double vDir = 1;  // 공 수직방향 여부

        Random rand = new Random();


        public Form1()
        {
            InitializeComponent();

            // 폼 사이즈
            this.ClientSize = new Size(formW, formH);
            this.Text = "BlockBreak v1.0";

            // 그래픽 객체 생성
            g = this.CreateGraphics();

            // 블럭 초기화
            InitBlocks();

            // 라켓 초기화
            InitRacket();

            // 공 초기화
            InitBall();
        }

        // 블록 초기화 메서드
        public void InitBlocks() 
        {
            for (int i = 0; i < nBlocks; i++)
            {
                blocks[i] = new Rectangle(i % 10 * blockW,
                                          blockY + blockH * (i / 10),
                                          blockW - 1,
                                          blockH - 1);
                // 블록 Visible 값 초기화
                ballVisible[i] = true;
            }
        }

        // 라켓 초기화 메서드
        public void InitRacket()
        {
            racket.X = formW / 2 - racketW / 2;
            racket.Y = racketY;
            racket.Width = racketW;
            racket.Height = racketH;
        }

        // 볼 관련 초기화 메서드
        public void InitBall()
        {
            ball = new Rectangle();
            ball.X = formW / 2 - ballW / 2;
            ball.Y = blockY + nBlocks / 10 * blockH;
            ball.Width = ballW;
            ball.Height = ballH;

            // 기울기값 초기화
            slope = rand.Next(1, 20) / 10.0;

            if (rand.Next(2) % 2 == 1)
            {
                slope = -slope;
            }
            vDir = 1;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            // 벽돌 그리기
            for (int i = 0; i < nBlocks; i++)
            {
                // ballVisible값이 true일 때만 그린다.
                if (ballVisible[i]) 
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
            //Console.WriteLine("Tick!");
            double dx = 0;
            double unit = ballW;

            dx = unit / slope;

            ball.X += (int) dx;
            ball.Y += (int) (vDir * slope * dx);

            // ball이 좌우 벽에 충돌 했는지 체크
            if (ball.X < 0 || ball.X > formW - ballW)
            {
                slope = -slope;
            }

            // ball이 라켓에 맞았는지 체크
            //IntersectsWith() : Rectangle내장 함수 - 같은 Rectangle가 충돌할 때 이벤트
            if (ball.Y < 0 || racket.IntersectsWith(ball)) 
            {
                vDir = -vDir;
            }

            // ball이 벽돌을 맞았는지 체크
            for (int i = 0; i < nBlocks; i++)
            {
                if (ball.IntersectsWith(blocks[i]))
                {
                    // 충돌 방향을 반사 시킨다.
                    vDir = -vDir;
                    // 벽돌을 비활성화
                    ballVisible[i] = false;
                }
            }

            // 공이 클라이언트 세로축을 초과할 때 :: 게임오버
            if (ball.Y > ClientSize.Height)
            {
                // 화면 로딩 멈춤 :: ticker 멈춤
                myTimer.Stop();

                DialogResult result = MessageBox.Show("다시 시작하시겠습니까?", "확인", MessageBoxButtons.YesNo);

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