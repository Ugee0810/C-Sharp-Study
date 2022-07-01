namespace Project4
{
    public partial class Form1 : Form
    {
        // 그래픽
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

        // 폼 사이즈
        int formW = 300;
        int formH = 500;

        // 블록
        int blockY  = 50;
        int blockW  = 30;
        int blockH  = 20;
        int nBlocks = 1;
        int clearedBlocks = 0; // 파괴된 블록 카운트
        bool[] blockVisible = new bool[100]; // 벽돌과 공의 충돌 여부를 나타내는 상태변수

        // 장애물 블록
        int    levelBlockW          = 20;
        int    levelBlockH          = 15;
        int    nObstacleBlocks      = 1; // 장애물 블록 갯수 카운트
        double xMoveDirectionNSpeed = 1; // 장애물 블록 진행 방향
        Random randomBlockXY        = new Random();
        Random randomMoveSpeed      = new Random();
        Random randomBlockDirection = new Random();
        // 공
        int    ballW = 10;
        int    ballH = 10;
        double slope = 1; // 기울기
        double vDir  = 1; // 공 수직방향 여부
        Random randomBall  = new Random(); // 시작할 때 떨어질 방향을 랜덤으로 주기 위한 난수

        // 라켓
        int racketY = 480;
        int racketW = 250;
        int racketH = 10;

        public Form1()
        {
            InitializeComponent();
            FormSize();           // 폼 사이즈
            g = CreateGraphics(); // 그래픽 객체 생성
            InitBlocks();         // 초기화-블럭
            InitObstacleBlocks(); // 초기화-장애물 블록
            InitBall();           // 초기화-공 관련
            InitRacket();         // 초기화-라켓
        }

        
        public void FormSize() 
        {
            ClientSize = new Size(formW, formH);
            Text       = "BlockBreak v1.2";
        } // 폼 사이즈

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
        } // 블록 초기화 메서드

        public void InitObstacleBlocks() 
        {
            for (int i = 0; i < nObstacleBlocks; i++)
            {
                rObstacleBlocks[i] = new Rectangle(randomBlockXY.Next(50, 250),
                                                   randomBlockXY.Next(150, 250),
                                                   levelBlockW,
                                                   levelBlockH);
                //이동 속도
                xMoveDirectionNSpeed = randomMoveSpeed.Next(50, 100) / 10.0;
                // 이동 방향 초기화
                if (randomBlockDirection.Next(2) % 2 == 1) xMoveDirectionNSpeed = -xMoveDirectionNSpeed;
            }
        } // 장애물 블록 초기화 메서드

        public void InitBall() 
        {
            rBall        = new Rectangle();
            rBall.X      = formW / 2 - ballW / 2;
            rBall.Y      = blockY + nBlocks / 10 * blockH;
            rBall.Width  = ballW;
            rBall.Height = ballH;

            // 기울기값 초기화
            slope = randomBall.Next(10, 20) / 10.0;
            if (randomBall.Next(2) % 2 == 1) slope = -slope;
            vDir = 1;
        } // 공 관련 초기화 메서드

        public void InitRacket() // 라켓 초기화 메서드
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
                // blockVisible값이 true일 때만 블록 그리기
                if (blockVisible[i] == true) 
                    g.FillRectangle(blockColor, rBlocks[i]);
            } // 매개변수 nBlocks값 만큼 벽돌 생성

            for (int k = 0; k < nObstacleBlocks; k++)
            {
                //장애물 블록 그리기
                g.FillRectangle(obstacleBlockColor, rObstacleBlocks[k]);
                g.DrawRectangle(pen, rObstacleBlocks[k]);
            } // 매개변수 nObstacleBlocks값 만큼 장애물 벽돌 생성

            // 라켓 그리기
            g.FillRectangle(racketColor, rRacket);

            // 공 그리기
            g.FillEllipse(ballColor, rBall);
            g.DrawEllipse(pen, rBall);
        }

        private void myTimer_Tick(object sender, EventArgs e)
        {
            double dx = 0;
            dx = ballW / slope;
            rBall.X += (int)dx;
            rBall.Y += (int)(vDir * slope * dx);
            if (rBall.X < 0 || rBall.X > formW - ballW) slope = -slope;     // 공이 좌우 벽에 충돌(가로 방향 굴절)
            if (rBall.Y < 0 || rRacket.IntersectsWith(rBall)) vDir = -vDir; // 공이 천장이나 라켓에 충돌(세로 방향 굴절) | Rectangle.IntersectsWith() :: 같은 Rectangle 객체가 충돌할 때 이벤트

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
                } // 공이 장애물 벽돌과 충돌(반대 방향 굴절)

            } // 장애물 블록 트리거

            for (int i = 0; i <= nBlocks; i++)
            {
                if (blockVisible[i] == true && rBlocks[i].IntersectsWith(rBall))
                {
                    blockVisible[i] = false; // 벽돌은 안 보이게 비활성화
                    vDir = -vDir;            // 충돌 방향과 반대 방향 굴절

                    if (++clearedBlocks >= nBlocks)
                    {
                        myTimer.Stop(); // 화면 로딩 멈춤 :: ticker 멈춤
                        DialogResult result = MessageBox.Show("클리어 하셨습니다. 다음 레벨을 진행하시겠습니까?",
                                                              "확인",
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
            } // 공/벽돌 상호작용, 게임 클리어

            if (rBall.Y > ClientSize.Height)
            {
                myTimer.Stop(); // 화면 로딩 멈춤 - ticker 멈춤
                DialogResult result = MessageBox.Show("다시 시작하시겠습니까?",
                                                      "확인",
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
            } // 게임오버 - 공이 클라이언트 세로축을 초과할 때

            Invalidate();
        }
        
        private void Form1_KeyDown(object sender, KeyEventArgs e) // 키보드 조작
        {
            if (e.KeyCode == Keys.Left)
                rRacket.X -= 40;                                              // ← 이동 폭
                if (rRacket.X < 0) rRacket.X = 0;                             // ← 화면 초과 금지
            else if (e.KeyCode == Keys.Right)
                rRacket.X += 40;                                              // → 이동 폭
                if (rRacket.X > formW - racketW) rRacket.X = formW - racketW; // → 화면 초과 금지
            else if (e.KeyCode == Keys.Space) myTimer.Stop();                 // 정지
            else if (e.KeyCode == Keys.Enter) myTimer.Start();                // 재개
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
// ＃[★]클리어 후 레벨 추가(클리어 할 때 마다 라켓이 작아짐, 움직이는 장애물 추가)
// ＃[未]게임 시작 -> Die -> 기록 저장란 출력(시간(자동), 스코어(자동), 레벨(자동), 이름)
// ＃[未]실시 시간(1s = -10점) / 라운드 보너스(+1,000, +3,000, +5,000) / 블록 한 개 제거(+100) / 블록 연속 파괴 점수(100 + 20 *= 2)
// ＃[未]데이터베이스 연동