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

        Rectangle[]  blocks = new Rectangle[100];
        Rectangle    ball;
        Rectangle    racket = new Rectangle();

        // 폼 사이즈
        int formW = 300;
        int formH = 500;

        // 블럭 갯수
        int    nBlocks      = 1;
        bool[] blockVisible = new bool[100]; // 벽돌과 공의 충돌 여부를 나타내는 상태변수

        // 블럭
        int blockY = 50;
        int blockW = 30;
        int blockH = 20;
        int clearedBlocks = 0;

        // 공
        int    ballW = 15;
        int    ballH = 15;
        double slope = 1; // 기울기
        double vDir  = 1; // 공 수직방향 여부
        Random rand  = new Random(); // 시작할 때 떨어질 방향을 랜덤으로 주기 위한 난수

        // 라켓
        int racketY = 480;
        int racketW = 150;
        int racketH = 10;

        public Form1()
        {
            InitializeComponent();
            FormSize();           // 폼 사이즈
            g = CreateGraphics(); // 그래픽 객체 생성
            InitBlocks();         // 초기화-블럭 
            InitBall();           // 초기화-공 관련
            InitRacket();         // 초기화-라켓
        }

        // 폼 사이즈
        public void FormSize()
        {
            ClientSize = new Size(formW, formH);
            Text       = "BlockBreak v1.2";
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
                blockVisible[i] = true; // 블록 Visible 값 초기화
                clearedBlocks = 0;
            }
        }

        // 공 관련 초기화 메서드
        public void InitBall()
        {
            ball        = new Rectangle();
            ball.X      = formW / 2 - ballW / 2;
            ball.Y      = blockY + nBlocks / 10 * blockH;
            ball.Width  = ballW;
            ball.Height = ballH;

            // 기울기값 초기화
            slope = rand.Next(5, 20) / 10.0;
            if (rand.Next(2) % 2 == 1) slope = -slope;
            vDir = 1;
        }

        // 라켓 초기화 메서드
        public void InitRacket()
        {
            racket.X      = formW / 2 - racketW / 2;
            racket.Y      = racketY;
            racket.Width  = racketW;
            racket.Height = racketH;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            // 매개변수 nBlocks값 만큼 벽돌 생성
            for (int i = 0; i < nBlocks; i++)
            {
                // blockVisible값이 true일 때만 그린다.
                if (blockVisible[i] == true) 
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
            double dx = 0;
            double unit = ballW;

            dx = unit / 5 / slope;

            ball.X += (int)dx;
            ball.Y += (int)(vDir * slope * dx);

            // 공과 좌우 벽이 충돌(가로 방향 굴절)
            if (ball.X < 0 || ball.X > formW - ballW) // x : 1 ~ 489 범위 제한
                slope = -slope;

            // 공이 천장이나 라켓에 충돌(세로 방향 굴절)
            if (ball.Y < 0 || racket.IntersectsWith(ball)) // Rectangle.IntersectsWith() :: 같은 Rectangle 객체가 충돌할 때 이벤트
                vDir = -vDir;

            // 공과 벽돌이 충돌시 체크
            for (int i = 0; i <= nBlocks; i++)
            {
                if (blockVisible[i] == true && blocks[i].IntersectsWith(ball))
                {
                    vDir = -vDir;            // 충돌 방향과 반대 방향 굴절
                    blockVisible[i] = false; // 벽돌은 안 보이게 비활성화

                    if (++clearedBlocks >= nBlocks)
                    {
                        myTimer.Stop(); // 화면 로딩 멈춤 :: ticker 멈춤
                        DialogResult result = MessageBox.Show("클리어 하셨습니다. 다음 레벨을 진행하시겠습니까?",
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
                    //Console.WriteLine(clearedBlocks);
                }
            }

            // 게임오버 :: 공이 클라이언트 세로축을 초과할 때
            if (ball.Y > ClientSize.Height)
            {
                myTimer.Stop(); // 화면 로딩 멈춤 :: ticker 멈춤
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

        // 키보드 조작
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
                racket.X -= 40;                                             // ← 이동 폭
                if (racket.X < 0) racket.X = 0;                             // ← 화면 초과 금지
            else if (e.KeyCode == Keys.Right)
                racket.X += 40;                                             // → 이동 폭
                if (racket.X > formW - racketW) racket.X = formW - racketW; // → 화면 초과 금지
            else if (e.KeyCode == Keys.Space) myTimer.Stop();               // 정지
            else if (e.KeyCode == Keys.Enter) myTimer.Start();              // 재개
                
            Invalidate();
        }
    }
}

// 앞으로의 필수 구현 목록
// ＃[★]라켓 화면 밖으로 사리지지 않게 하기 
// ＃[★]깨진 벽돌은 충돌 무효화
// ＃[★]모든 벽돌 제거 시 안내, 효과
// 추가 고려할 점
// ＃[★]모듈화
// ＃[★]일시정지, 재개 버튼 추가 (대신 정지 상태에서 바가 움직임)
// ＃[未]클리어 후 레벨 추가(클리어 할 때 마다 라켓이 작아짐, 움직이는 장애물 추가)
// ＃[未]게임 시작 -> Die -> 기록 저장란 출력(시간(자동), 스코어(자동), 레벨(자동), 이름)
// ＃[未]실시 시간(1s = -10점) / 라운드 보너스(+1,000, +3,000, +5,000) / 블록 한 개 제거(+100) / 블록 연속 파괴 점수(100 + 20 *= 2)
// ＃[未]데이터베이스 연동