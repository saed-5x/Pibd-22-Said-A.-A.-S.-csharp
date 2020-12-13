using lab_1;
using System.Drawing;

namespace WindowsFormsMonorail
{
    class Monorail
    {
        private float Xstart;
        private float Ystart;
        private int PicWidth;
        private int PicHeight;
        private const int MonorailWidth = 200;
        private const int MonorailHeight = 150;
        public int MaxSpeed { private set; get; }
        public float Weight { private set; get; }
        public Color BodyColor { private set; get; }
        public Color SideStrip { private set; get; }
        public bool Window { private set; get; }
        public bool Doors { private set; get; }
        public bool Railway { private set; get; }


        public Monorail(int maxSpeed, float weight, Color bodycolor, Color sidestrip, bool window, bool doors, bool railway)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            Window = window;
            BodyColor = bodycolor;
            SideStrip = sidestrip;
            Doors = doors;
            Railway = railway;
        }
        public void SetPosition(int x, int y, int width, int height)
        {
            Xstart = x;
            Ystart = y;
            PicWidth = width;
            PicHeight = height;
        }
        public void MoveMonorail(Direction direction)
        {
            float step = MaxSpeed * 200 / Weight;
            switch (direction)
            {
                case Direction.Right:
                    if (Xstart + step < PicWidth - MonorailWidth)
                    {
                        Xstart += step;
                    }
                    break;
                case Direction.Left:
                    if (Xstart - step > MonorailWidth*2)
                    {
                        Xstart -= step;
                    }
                    break;
                case Direction.Up:
                    if (Ystart - step > 0)
                    {
                        Ystart -= step;
                    }
                    break;
                case Direction.Down:
                    if (Ystart + step < PicHeight - MonorailHeight)
                    {
                        Ystart += step;
                    }
                    break;
            }
        }
        public void DrawMonorail(Graphics g)
        {
            Pen pen = new Pen(Color.Black);

            float resize = 1.1f;
            Brush wire = new SolidBrush(Color.Black);
            Brush monorail = new SolidBrush(BodyColor);
            Brush clip = new SolidBrush(Color.Orange);
            Brush window = new SolidBrush(Color.White);
            Brush strip = new SolidBrush(SideStrip);

            g.FillRectangle(wire, Xstart - (400 / resize), Ystart + (50 / resize), 600 / resize, 20 / resize);
            g.FillRectangle(clip, Xstart - (55 / resize), Ystart + (5 / resize), 25 / resize, 55 / resize);
            g.FillRectangle(clip, Xstart - (166 / resize), Ystart + (5 / resize), 25 / resize, 55 / resize);
            g.FillRectangle(clip, Xstart - (295 / resize), Ystart + (5 / resize), 25 / resize, 55 / resize);       
            g.FillRectangle(monorail, Xstart - (150 / resize), Ystart, 105 / resize, 60 / resize);
            g.FillRectangle(monorail, Xstart - (270 / resize), Ystart, 105 / resize, 60 / resize);
            g.FillRectangle(monorail, Xstart - (390 / resize), Ystart, 105 / resize, 60 / resize);
            g.FillRectangle(monorail, Xstart - (30 / resize), Ystart, 180 / resize, 60 / resize);
            g.FillEllipse(monorail, Xstart + (120 / resize), Ystart, 60 / resize, 50 / resize);
            g.FillEllipse(monorail, Xstart + (100 / resize), Ystart + (15 / resize), 100 / resize, 45 / resize);
            g.FillRectangle(strip, Xstart - (30 / resize), Ystart + (35 / resize), 220 / resize, 12 / resize);
            g.FillEllipse(strip, Xstart + (180 / resize), Ystart + (35 / resize), 20 / resize, 12 / resize);
            g.FillRectangle(strip, Xstart - (270 / resize), Ystart + (35 / resize), 105 / resize, 12 / resize);
            g.FillRectangle(strip, Xstart - (390 / resize), Ystart + (35 / resize), 105 / resize, 12 / resize);
            g.FillRectangle(strip, Xstart - (150 / resize), Ystart + (35 / resize), 105 / resize, 12 / resize);

            if (Doors)
            {
               
                  Brush door1 = new SolidBrush(Color.Green);
                  g.DrawRectangle(pen, Xstart - (115 / resize), Ystart + (10 / resize), 30 / resize, 45 / resize);

                  g.FillRectangle(door1, Xstart - (115 / resize), Ystart + (10 / resize), 30 / resize, 45 / resize);
                  g.DrawRectangle(pen, Xstart - (100 / resize), Ystart + (10 / resize), 15 / resize, 45 / resize);

                  Brush door2 = new SolidBrush(Color.Yellow);
                  g.DrawRectangle(pen, Xstart - (235 / resize), Ystart + (9 / resize), 31 / resize, 45 / resize);
                  g.FillRectangle(door2, Xstart - (235 / resize), Ystart + (10 / resize), 30 / resize, 45 / resize);
                  g.DrawRectangle(pen, Xstart - (220 / resize), Ystart + (9 / resize), 16 / resize, 45 / resize);

                  Brush door3 = new SolidBrush(Color.Fuchsia);
                  g.DrawRectangle(pen, Xstart - (355 / resize), Ystart + (10 / resize), 30 / resize, 45 / resize);
                  g.FillRectangle(door3, Xstart - (355 / resize), Ystart + (10 / resize), 30 / resize, 45 / resize);
                  g.DrawRectangle(pen, Xstart - (340 / resize), Ystart + (10 / resize), 15 / resize, 45 / resize); 
            }

            if (Window)
            {
                g.DrawRectangle(pen, Xstart - (20 / resize), Ystart + (10 / resize), 40 / resize, 20 / resize);
                g.DrawRectangle(pen, Xstart + (30 / resize), Ystart + (10 / resize), 40 / resize, 20 / resize);
                g.DrawRectangle(pen, Xstart + (80 / resize), Ystart + (10 / resize), 40 / resize, 20 / resize);
                g.DrawRectangle(pen, Xstart + (130 / resize), Ystart + (10 / resize), 30 / resize, 20 / resize);
                g.DrawEllipse(pen, Xstart + (140 / resize), Ystart + (10 / resize), 30 / resize, 20 / resize);

                g.FillRectangle(window, Xstart - (20 / resize), Ystart + (10 / resize), 40 / resize, 20 / resize);
                g.FillRectangle(window, Xstart + (30 / resize), Ystart + (10 / resize), 40 / resize, 20 / resize);
                g.FillRectangle(window, Xstart + (80 / resize), Ystart + (10 / resize), 40 / resize, 20 / resize);
                g.FillRectangle(window, Xstart + (130 / resize), Ystart + (10 / resize), 30 / resize, 20 / resize);
                g.FillEllipse(window, Xstart + (140 / resize), Ystart + (10 / resize), 30 / resize, 20 / resize);


            }


        }
    }
}
