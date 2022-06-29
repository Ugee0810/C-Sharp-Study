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

        //돌을 구분하기 위한 상태변수
        bool isBlack = true;

        enum STONE { none, black, white };
        STONE[,] dataSet = new STONE[19, 19];


        public Form1()
        {
            InitializeComponent();

            //그래픽 관련 객체 초기화
            g = this.CreateGraphics();
            pen = new Pen(Color.Black);
            wBrush = new SolidBrush(Color.White);
            bBrush = new SolidBrush(Color.Black);

            //바둑판 색, 크기
            this.Text = "오목 v1.0";
            this.BackColor = Color.Orange;
            this.ClientSize = new Size(2 * margin + 18 * sizeNun, 2 * margin + 18 * sizeNun); //18을 더한 이유 : 눈금의 개수
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            //좌표보정
            int x = (e.X - margin + sizeNun / 2) / sizeNun;
            int y = (e.Y - margin + sizeNun / 2) / sizeNun;
            //Console.WriteLine("x : {0}, y : {1}", x, y);

            Rectangle dol = new Rectangle(margin + sizeNun * x - sizeNun / 2,
                                          margin + sizeNun * y - sizeNun / 2,
                                          sizeDol,
                                          sizeDol);

            if (dataSet[x, y] != STONE.none)//데이터 x,y 안에 화이트나 블랙이 있다면
            {
                MessageBox.Show("해당 좌표엔 이미 돌이 있습니다..");
                return; // 반환이 없는 메서드를 강제 종료 시킴
            }

            if (isBlack)
            {
                g.FillEllipse(bBrush, dol);  //바둑돌 그리기
                dataSet[x, y] = STONE.black; //검은색 돌 2차원 배열 좌표 데이터를 해당 배열의 인덱스에 추가

                isBlack = false;
            }
            else
            {
                g.FillEllipse(wBrush, dol);
                dataSet[x, y] = STONE.white;

                isBlack = true;
            }

            //오목 여부 판정
            CheakOmok(x, y);
        }

        //8방향 체크
        public void CheakOmok(int x, int y)
        {
            int cBlack = 1;
            int cWhite = 1;

            /*
            // ↑
            for (int i = y - 1; i >= 0; i--)
            {
                if (dataSet[i, y] == dataSet[x, y])
                    count++;
                else
                    break;
            }

            // ↓
            for (int i = y + 1; i <= 18; i++)
            {
                if (dataSet[i, y] == dataSet[x, y])
                    count++;
                else
                    break;
            }

            //카운트 5 달성 시 오목
            if (count >= 5)
            {
                MessageBox.Show("오목입니다.");
                return;
            }
            count = 1;

            // →
            for (int i = x + 1; i <= 18; i++)
            {
                if (dataSet[i, y] == dataSet[x, y])
                    count++;
                else
                    break;
            }

            // ←
            for (int i = x - 1; i >= 0; i--)
            {
                if (dataSet[i, y] == dataSet[x, y])
                    count++;
                else
                    break;
            }

            //카운트 5 달성 시 오목
            if (count >= 5)
            {
                MessageBox.Show("오목입니다.");
                return;
            }
            count = 1;

            // ↗
            for (int i = x + 1, j = y - 1; i <= 18 && j >= 0; i++, j--)
            {
                if (dataSet[i, y] == dataSet[x, y])
                    count++;
                else
                    break;
            }

            // ↘
            for (int i = x + 1, j = y + 1; i <= 18 && j <= 18; i++, j++)
            {
                if (dataSet[i, y] == dataSet[x, y])
                    count++;
                else
                    break;
            }

            //카운트 5 달성 시 오목
            if (count >= 5)
            {
                MessageBox.Show("오목입니다.");
                return;
            }
            count = 1;

            // ↙
            for (int i = x - 1, j = y + 1; i >= 0 && j <= 18; i--, j++)
            {
                if (dataSet[i, y] == dataSet[x, y])
                    count++;
                else
                    break;
            }

            // ↖
            for (int i = x - 1, j = y - 1; i >= 0 && j >= 0; i--, j--)
            {
                if (dataSet[i, y] == dataSet[x, y])
                    count++;
                else
                    break;
            }

            //카운트 5 달성 시 오목
            if (count >= 5)
            {
                MessageBox.Show("오목입니다.");
                return;
            }
            count = 1;
            */
        }

        public void NewGame()
        {
            //화면 갱신 -> OnPaint()호출
            this.Invalidate(); 
            //데이터셋 초기화
            for (int x = 0; x < 19; x++)
                for (int y = 0; y < 19; y++)
                    dataSet[x, y] = STONE.none;
            //상태변수 초기화
            isBlack = true;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            //바둑판 눈금 그리기
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