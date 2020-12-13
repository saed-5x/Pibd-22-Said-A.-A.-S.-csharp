using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsMonorail
{
    public class Monorail : Locomotive
    {
        public Monorail(int maxSpeed, float weight, Color bodycolor, Color sidestrip, bool window, bool doors, bool railway) : base(maxSpeed, weight, bodycolor, sidestrip, window, doors, railway)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            Window = window;
            BodyColor = bodycolor;
            SideStrip = sidestrip;
            Doors = doors;
            Railway = railway;
        }

        public override void DrawMonorail(Graphics g)
        {
            Pen pen = new Pen(Color.Black);
            Brush wire = new SolidBrush(Color.Black);
            Brush monorail = new SolidBrush(BodyColor);
            Brush window = new SolidBrush(Color.White);
            Brush strip = new SolidBrush(SideStrip);

            float resize = 1.1f;
            base.DrawMonorail(g);
            g.FillRectangle(wire, Xstart - 400 / resize, Ystart + 60 / resize, 600 / resize, 25 / resize);
            g.FillRectangle(monorail, Xstart - 30 / resize, Ystart, 180 / resize, 60 / resize);
            g.FillEllipse(monorail, Xstart + 120 / resize, Ystart, 60 / resize, 50 / resize);
            g.FillEllipse(monorail, Xstart + 100 / resize, Ystart + 15 / resize, 100 / resize, 45 / resize);
            g.FillRectangle(strip, Xstart - 30 / resize, Ystart + 35 / resize, 220 / resize, 12 / resize);
            g.FillEllipse(strip, Xstart + 180 / resize, Ystart + 35 / resize, 20 / resize, 12 / resize);

            if (Window)
            {
                g.DrawRectangle(pen, Xstart - 20 / resize, Ystart + 10 / resize, 40 / resize, 20 / resize);
                g.DrawRectangle(pen, Xstart + 30 / resize, Ystart + 10 / resize, 40 / resize, 20 / resize);
                g.DrawRectangle(pen, Xstart + 80 / resize, Ystart + 10 / resize, 40 / resize, 20 / resize);
                g.DrawRectangle(pen, Xstart + 130 / resize, Ystart + 10 / resize, 30 / resize, 20 / resize);
                g.DrawEllipse(pen, Xstart + 140 / resize, Ystart + 10 / resize, 30 / resize, 20 / resize);

                g.FillRectangle(window, Xstart - 20 / resize, Ystart + 10 / resize, 40 / resize, 20 / resize);
                g.FillRectangle(window, Xstart + 30 / resize, Ystart + 10 / resize, 40 / resize, 20 / resize);
                g.FillRectangle(window, Xstart + 80 / resize, Ystart + 10 / resize, 40 / resize, 20 / resize);
                g.FillRectangle(window, Xstart + 130 / resize, Ystart + 10 / resize, 30 / resize, 20 / resize);
                g.FillEllipse(window, Xstart + 140 / resize, Ystart + 10 / resize, 30 / resize, 20 / resize);
            }
        }
    }
}