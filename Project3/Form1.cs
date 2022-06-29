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
            
            if (isBlack)
            {
                g.FillEllipse(bBrush, dol);
                isBlack = false;
            }
            else
            {
                g.FillEllipse(wBrush, dol);
                isBlack = true;
            }
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