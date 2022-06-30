namespace Project4
{
    public partial class Form1 : Form
    {
        // 그래픽
        Graphics g;
        Brush blockColor  = new SolidBrush(Color.Orange);
        Brush ballColor   = new SolidBrush(Color.Gold);
        Brush racketColor = new SolidBrush(Color.Red);
        Pen   pen         = new Pen(Color.Black);

        Rectangle[] blocks = new Rectangle[100];
        Rectangle   ball;
        Rectangle   racket = new Rectangle();

        // 폼 사이즈
        int formW = 300;
        int formH = 500;

        // 블럭 갯수
        int    nBlocks      = 20;
        bool[] blockVisible = new bool[100]; // 벽돌과 공의 충돌 여부를 나타내는 상태변수

        // 블럭
        int blockY = 40;
        int blockW = 30;
        int blockH = 20;

        // 공
        int    ballW = 10;
        int    ballH = 10;
        double slope = 1; // 기울기
        double vDir  = 1; // 공 수직방향 여부
        Random rand  = new Random(); // 시작할 때 떨어질 방향을 랜덤으로 주기 위한 난수

        // 라켓
        int racketY = 480;
        int racketW = 100;
        int racketH = 10;

        public Form1()
        {
            InitializeComponent();
            FormSize();           // 폼 사이즈
            g = CreateGraphics(); // 그래픽 객체 생성
            InitBlocks();         // 초기화-블럭 
            InitRacket();         // 초기화-라켓 
            InitBall();           // 초기화-공
        }

        // 폼 사이즈
        public void FormSize()
        {
            ClientSize = new Size(formW, formH);
            Text = "BlockBreak v1.1";
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
                blockVisible[i] = true;
            }
        }

        // 라켓 초기화 메서드
        public void InitRacket()
        {
            racket.X      = formW / 2 - racketW / 2;
            racket.Y      = racketY;
            racket.Width  = racketW;
            racket.Height = racketH;
        }

        // 볼 관련 초기화 메서드
        public void InitBall()
        {
            ball        = new Rectangle();
            ball.X      = formW / 2 - ballW / 2;
            ball.Y      = blockY + nBlocks / 10 * blockH;
            ball.Width  = ballW;
            ball.Height = ballH;

            // 기울기값 초기화
            slope = rand.Next(1, 20) / 10.0;

            if (rand.Next(2) % 2 == 1) slope = -slope;

            vDir = 1;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            // 벽돌 그리기
            for (int i = 0; i < nBlocks; i++)
            {
                // blockVisible값이 true일 때만 그린다.
                if (blockVisible[i]) 
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

            // 공과 벽돌이 충돌시 체크
            for (int i = 0; i < nBlocks; i++)
            {
                if (ball.IntersectsWith(blocks[i]))
                {
                    // 충돌 방향과 반대 방향 진행
                    vDir = -vDir;
                    // 벽돌은 안 보이게 비활성화
                    blockVisible[i] = false;
                }
            }

            // 게임오버 :: 공이 클라이언트 세로축을 초과할 때
            if (ball.Y > ClientSize.Height)
            {
                // 화면 로딩 멈춤 :: ticker 멈춤
                myTimer.Stop();

                DialogResult result = MessageBox.Show("다시 시작하시겠습니까?",
                                                      "확인",
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

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if      (e.KeyCode == Keys.Left)  racket.X -= 20;
            else if (e.KeyCode == Keys.Right) racket.X += 20;

            Invalidate();
        }
    }
}

// 앞으로의 필수 구현 목록
// ＃깨진 벽돌은 충돌 무효화 (특정 좌표 배열 삭제?)
// ＃모든 벽돌 제거 시 안내, 효과
// ＃라켓 화면 밖으로 사리지지 않게 하기
// 추가 고려할 점
// ＃클리어 후 레벨 추가
// ＃아이디 입력 후 스코어 기록 기능(실시 시간, 이름, 스코어, 레벨)
// ＃모듈화