using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Worms2
{
    public partial class Form1 : Form
    {
        //the boi
        Boi[] bois;
        int BOISIZE = 4, TURNSPEED = 15, MAG = 4, TRAILLENGTH = 100, NUMBER = 25;
        readonly double RADIAN = 0.0174533;

        public Form1()
        {
            InitializeComponent();
        }

        private void PB_main_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            //draw boi
            foreach (Boi boi in bois)
            {
                g.FillRectangle(Brushes.Blue, boi.boi);
                int counter = 255;
                foreach (Rectangle trailRect in boi.trail)
                {
                    if (!(trailRect == null))
                    {
                        g.FillRectangle(new SolidBrush(Color.FromArgb(counter, counter, 255)), trailRect);
                    }
                    counter -= 255 / TRAILLENGTH;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TB_zoom.Value = BOISIZE;
            TB_turn.Value = TURNSPEED;
            TB_trail.Value = TRAILLENGTH;
            TB_no.Value = NUMBER;
            TB_speed.Value = (MAG / BOISIZE) * 10;
            Init();
        }

        private void Init()
        {
            PB_main.BackColor = Color.White;

            PB_main.Height = Height - PNL_constEditor.Height - 50;

            bois = new Boi[NUMBER];
            //to position boi
            Random rng = new Random();
            for (int i = 0; i <= bois.Length - 1; i++)
            {
                Point start = new Point(rng.Next(0, PB_main.Width - BOISIZE + 1), rng.Next(0, PB_main.Height - BOISIZE + 1));
                bois[i] = new Boi(start.X, start.Y, new Size(BOISIZE, BOISIZE), TRAILLENGTH, rng.Next(0, 360));
            }
        }

        private void TIM_animate_Tick(object sender, EventArgs e)
        {
            Random rng = new Random();
            foreach (Boi boi in bois)
            {
                if (rng.Next(0, 2) == 0)
                {
                    boi.angle += TURNSPEED;
                }
                else
                {
                    boi.angle -= TURNSPEED;
                }
                Point speed = GetXY(boi.angle, MAG);
                boi.ShiftBack();
                boi.boi.X += speed.X; boi.boi.Y += speed.Y;
                if (boi.boi.Left < 0)
                {
                    boi.boi.X = 0;
                    boi.angle = rng.Next(0, 181);
                }
                else if (boi.boi.Right > PB_main.Width)
                {
                    boi.boi.X = PB_main.Width - BOISIZE;
                    boi.angle = rng.Next(180, 360);
                }
                if (boi.boi.Top < 0)
                {
                    boi.boi.Y = 0;
                    boi.angle = rng.Next(90, 271);
                }
                else if (boi.boi.Bottom > PB_main.Height)
                {
                    boi.boi.Y = PB_main.Height - BOISIZE;
                    boi.angle = rng.Next(0, 1);
                    if (boi.angle == 0)
                    {
                        boi.angle = rng.Next(0, 91);
                    }
                    else
                    {
                        boi.angle = rng.Next(270, 360);
                    }
                }
            }
            PB_main.Refresh();
        }

        private void TB_zoom_Scroll(object sender, EventArgs e)
        {
            double speed = TB_speed.Value / 10.0;
            BOISIZE = TB_zoom.Value;
            MAG = Convert.ToInt32(BOISIZE * speed);
            Init();
        }
        private void TB_turn_Scroll(object sender, EventArgs e)
        {
            TURNSPEED = TB_turn.Value;
            Init();
        }
        private void TB_no_Scroll(object sender, EventArgs e)
        {
            NUMBER = TB_no.Value;
            Init();
        }
        private void TB_speed_Scroll(object sender, EventArgs e)
        {
            double speed = TB_speed.Value / 10.0;
            MAG = Convert.ToInt32(BOISIZE * speed);
        }

        private void Form1_ResizeEnd(object sender, EventArgs e)
        {
            PB_main.Height = Height - PNL_constEditor.Height - 50;
        }

        private void TB_trail_Scroll(object sender, EventArgs e)
        {
            TRAILLENGTH = TB_trail.Value;
            Init();
        }

        private Point GetXY(double angle, double magnitude)
        {
            int x = Convert.ToInt32(magnitude * Math.Sin(GetRads(angle)));
            int y = Convert.ToInt32(magnitude * Math.Cos(GetRads(angle)));
            return new Point(x, y);
        }

        private double GetRads(double angle)
        {
            return angle * RADIAN;
        }



        private Rectangle Clone(Rectangle input)
        {
            return new Rectangle(input.X, input.Y, input.Width, input.Height);
        }
    }
    public class Boi
    {
        public Rectangle[] trail;
        public Rectangle boi;
        public int angle { get; set; }
        public Boi(int x, int y, Size size, int trailLength, int angleIn)
        {
            trail = new Rectangle[trailLength];
            boi = new Rectangle(x, y, size.Width, size.Height);
            angle = angleIn;
        }
        public void ShiftBack()
        {
            Rectangle[] output = new Rectangle[trail.Length];
            for (int i = 0; i <= trail.Length - 2; i++)
            {
                output[i] = trail[i + 1];
            }
            output[trail.Length - 1] = boi;
            trail = output;
        }
    }
}