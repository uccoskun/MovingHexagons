using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovingHexagons
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            panels = new List<Panel>();
            panels.Add(panel1);
            panels.Add(panel2);
            panels.Add(panel3);
            panels.Add(panel4);
            panels.Add(panel5);
            panels.Add(panel6);
            setPanels();
            movePanels();






        }

        List<Panel> panels;
        int radius = 40;
        int maxRadius = 80;
        int hexRadius = 40;
        bool increase = false;

        private PointF rotate(PointF center, PointF p, int angle)
        {
            double angleRad = angle * Math.PI / 180;
            float xcenter = center.X, ycenter = center.Y;
            float x = p.X - xcenter, y = p.Y - ycenter;
            float newX, newY;
            newX = (float)(x * Math.Cos(angleRad) - y * Math.Sin(angleRad) + xcenter);
            newY = (float)(x * Math.Sin(angleRad) + y * Math.Cos(angleRad) + ycenter);
            return new PointF(newX, newY);
        }

        private void drawHexagons(Graphics g, PointF intPoint, PointF center)
        {
            Pen drawingPen = new Pen(Color.Black, 2);
            PointF nextPoint;
            for (int i = 0; i < 6; i++)
            {
                nextPoint = rotate(center, intPoint, 60);
                g.DrawLine(drawingPen, nextPoint, intPoint);
                intPoint = nextPoint;
            }
        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {
            int height = (sender as Panel).Height;
            int width = (sender as Panel).Width;
            Graphics g = e.Graphics;
            
            PointF centerPanel = new PointF(width / 2, height / 2);
            PointF intPoint = new PointF(0, hexRadius);
            
            for (int i = 0; i < 6; i++)
            {
                drawHexagons(g, intPoint, centerPanel);
                centerPanel = rotate(centerPanel, intPoint, 60);
                intPoint = new PointF(centerPanel.X, centerPanel.Y);
            }
            (sender as Panel).BackColor = Color.Transparent;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            //timer1 = new System.Timers.Timer();
            //timer1.Interval = 1000;
            //timer1.Elapsed +=  moveHexagons;
            //timer1.Start();
         //   setPanels();


        }


        private void timer2_Tick(object sender, EventArgs e)
        {
            if (increase)
                radius += 1;
            else radius -= 1;
            if (radius > maxRadius)
                increase = false;
            else if (radius <= hexRadius)
                increase = true;
            movePanels();


        }
        private void setPanels()
        { foreach(Panel p in panels)
            {
                p.Width = 2 * hexRadius;
                p.Height = 2 * hexRadius;
            }
        }

        private void movePanels()
        {
            PointF hexCenters = new PointF(this.Height / 2 + radius, this.Width / 2);
            foreach (Panel p in panels)
            {
                p.Left = (int)(hexCenters.X - hexRadius);
                p.Top = (int)(hexCenters.Y - hexRadius);
                hexCenters = rotate(new PointF(this.Height / 2, this.Width / 2), hexCenters, 60);
            }
        }

    }
    public class TransparentPanel : Panel
    {
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x00000020; // WS_EX_TRANSPARENT
                return cp;
            }
        }
        protected override void OnPaintBackground(PaintEventArgs e)
        {
            //base.OnPaintBackground(e);
        }
    }
}
