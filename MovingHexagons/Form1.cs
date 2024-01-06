using System.Xml;

namespace MovingHexagons
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();





        }

        System.Timers.Timer timer1;
        int radius = 100;
        int hexRadius = 40;
        bool increase = false;

        private Point rotate(Point center, Point p, int angle)
        {
            double angleRad = angle * Math.PI / 180;
            int xcenter = center.X, ycenter = center.Y;
            int x = p.X - xcenter, y = p.Y - ycenter;
            int newX, newY;
            newX = (int)(x * Math.Cos(angleRad) - y * Math.Sin(angleRad) + xcenter);
            newY = (int)(x * Math.Sin(angleRad) + y * Math.Cos(angleRad) + ycenter);
            return new Point(newX, newY);
        }

        private void drawHexagons(Graphics g, Point intPoint, Point center)
        {
            Pen drawingPen = new Pen(Color.Black, 2);
            Point nextPoint;
            for (int i = 0; i < 6; i++)
            {
                nextPoint = rotate(center, intPoint, 60);
                g.DrawLine(drawingPen, nextPoint, intPoint);
                intPoint = nextPoint;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            int height = panel1.Height;
            int width = panel1.Width;

            Graphics g = e.Graphics;
            Point centerHex = new Point(width / 2 + radius, height / 2);
            Point intPoint = new Point(centerHex.X + hexRadius, centerHex.Y);
            Point centerPanel = new Point(width / 2, height / 2);
            for (int i = 0; i < 6; i++)
            {
                drawHexagons(g, intPoint, centerHex);
                centerHex = rotate(centerPanel, centerHex, 60);
                intPoint = new Point(centerHex.X + hexRadius, centerHex.Y);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1 = new System.Timers.Timer();
            timer1.Interval = 300;
            timer1.Elapsed += Timer1_Elapsed;
            timer1.Start();

        }

        private void Timer1_Elapsed(object? sender, System.Timers.ElapsedEventArgs e)
        {
            if (increase)
                radius += 1;
            else radius -= 1;
            if (radius > 200)
                increase = false;
            else if (radius < hexRadius)
                increase = true;
            panel1.Invalidate();

        }
    }
}
