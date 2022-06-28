using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch11
{
    public partial class Form5 : Form
    {
        Graphics graphics;

        Rectangle myRect = new Rectangle();

        Brush bluebrush = new SolidBrush(Color.Blue);
        Pen   blackpen = new Pen(Color.Black);

        public Form5()
        {
            InitializeComponent();

            graphics = this.CreateGraphics();
            myRect.X = 360;
            myRect.Y = 10;

            myRect.Width  = 10;
            myRect.Height = 10;
        }

        //폼에 저장되어 있는 메서드
        protected override void OnPaint(PaintEventArgs e)
        {
            Console.WriteLine("onPaint!!!");
            graphics.DrawRectangle(blackpen, myRect);
            graphics.FillRectangle(bluebrush, myRect);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();

            Brush redbrush = new SolidBrush(Color.Red);
            Pen   blackpen = new Pen(Color.Black);

            Rectangle rect = new Rectangle(10, 10, 100, 100); //x, y, w, h

            //도형 그리기
            g.DrawRectangle(blackpen, rect);

            //색 채우기
            g.FillRectangle(redbrush, rect);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();

            Pen blackpen = new Pen(Color.Black);

            //선 긋기
            g.DrawLine(blackpen, new Point(10, 120), new Point(200, 120));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();

            Brush greenbrush = new SolidBrush(Color.Green);
            Pen   blackpen   = new Pen(Color.Black);

            Rectangle rect = new Rectangle(120, 10, 100, 100); //x, y, w, h

            g.DrawRectangle(blackpen, rect);
            g.FillEllipse(greenbrush, rect);
        }

        //인터벌만큼 실행되는 메서드(1s)
        private void myTimer_Tick_1(object sender, EventArgs e)
        {
            Console.WriteLine("아하");
            myRect.Y += 10;

            //윈도우의 특성에 의해 변화된 특성을 다시 올려줘야 함
            Invalidate();
        }
    }
}
