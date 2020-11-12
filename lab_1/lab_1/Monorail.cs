using lab_1;
using System.Drawing;

namespace WindowsFormsMonorail
{
    class Monorail
    {
        private float _startPosX;
        private float _startPosY;
        private int _pictureWidth;
        private int _pictureHeight;
        private const int monorailWidth = 200;
        private const int monorailHeight = 150;
        public int MaxSpeed { private set; get; }
        public float Weight { private set; get; }
        public Color MainColor { private set; get; }
        public Color SideLineColor { private set; get; }
        public Color Windows { private set; get; }

        public Color WireColor { private set; get; }

        public bool Window { private set; get; }
        public bool SingelRail { private set; get; }

        public bool Doors { private set; get; }

       

        
        public Monorail(int maxSpeed, float weight, Color mainColor, Color linecolor, Color windows, bool window, bool singelrail, bool doors)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
            SideLineColor = linecolor;
            Window = window;
            SingelRail = singelrail;
            Windows = windows;
            Doors = doors;
           
           

        }
        public void SetPosition(int x, int y, int width, int height)
        {
            _startPosX = x;
            _startPosY = y;
            _pictureWidth = width;
            _pictureHeight = height;
        }
        public void MoveTransport(Direction direction)
        {
            float step = MaxSpeed * 200 / Weight;
            switch (direction)
            {
                case Direction.Right:
                    if (_startPosX + step < _pictureWidth - monorailWidth)
                    {
                        _startPosX += step;
                    }
                    break;
                case Direction.Left:
                    if (_startPosX - step > monorailWidth*2)
                    {
                        _startPosX -= step;
                    }
                    break;
                case Direction.Up:
                    if (_startPosY - step > 0)
                    {
                        _startPosY -= step;
                    }
                    break;
                case Direction.Down:
                    if (_startPosY + step < _pictureHeight - monorailHeight)
                    {
                        _startPosY += step;
                    }
                    break;
            }
        }
        public void DrawMonorail(Graphics g)
        {
            Pen pen = new Pen(Color.Black);



            if (SingelRail)
            {
                Brush wire = new SolidBrush(Color.Black);
                g.FillRectangle(wire, _startPosX - 400, _startPosY + 50, 600, 20);

            }

            Brush monorail = new SolidBrush(SideLineColor);
  
            Brush clip = new SolidBrush(Color.RoyalBlue);

            Brush window = new SolidBrush(Windows);

            Brush strip = new SolidBrush(MainColor);


            g.FillRectangle(monorail, _startPosX-30, _startPosY, 180, 60);
            g.FillEllipse(monorail, _startPosX+120, _startPosY, 60, 50);
            g.FillEllipse(monorail, _startPosX + 100, _startPosY + 15, 100, 45);

            g.FillRectangle(clip, _startPosX - 55, _startPosY + 5, 25, 55);
            g.FillRectangle(monorail, _startPosX - 150, _startPosY, 105, 60);

            g.FillRectangle(clip, _startPosX - 55 - 120, _startPosY + 5, 25, 55);
            g.FillRectangle(monorail, _startPosX - 150 - 120, _startPosY, 105, 60);


            g.FillRectangle(clip, _startPosX - 55 - 240, _startPosY + 5, 25, 55);
            g.FillRectangle(monorail, _startPosX - 150 - 240, _startPosY, 105, 60);


            g.FillRectangle(strip, _startPosX - 30, _startPosY + 35, 220, 12);
            g.FillEllipse(strip, _startPosX + 180, _startPosY + 35, 20, 12);

            g.FillRectangle(strip, _startPosX - 150 - 120, _startPosY + 35, 105, 12);
            g.FillRectangle(strip, _startPosX - 150 - 240, _startPosY + 35, 105, 12);

            g.FillRectangle(strip, _startPosX - 150, _startPosY + 35, 105, 12);

            if (Doors)
            {
                Brush door1 = new SolidBrush(Color.Green);
                g.DrawRectangle(pen, _startPosX - 115, _startPosY + 10, 30, 45);
                
                g.FillRectangle(door1, _startPosX - 115, _startPosY + 10, 30, 45);
                g.DrawRectangle(pen, _startPosX - 115+15, _startPosY + 10, 30-15, 45);

                Brush door2 = new SolidBrush(Color.Yellow);
                g.DrawRectangle(pen, _startPosX - 115 - 120, _startPosY + 9, 31, 45);
                g.FillRectangle(door2, _startPosX - 115 - 120, _startPosY + 10, 30, 45);
                g.DrawRectangle(pen, _startPosX - 115 - 120 +15, _startPosY + 9, 31-15, 45);

                Brush door3 = new SolidBrush(Color.Fuchsia);
                g.DrawRectangle(pen, _startPosX - 115 - 240, _startPosY + 10, 30, 45);
                g.FillRectangle(door3, _startPosX - 115 - 240, _startPosY + 10, 30, 45);
                g.DrawRectangle(pen, _startPosX - 115 - 240 +15, _startPosY + 10, 30-15, 45);

            }




            if (Window)
            {

                g.DrawRectangle(pen, _startPosX - 20, _startPosY + 10, 40, 20);
                g.DrawRectangle(pen, _startPosX + 30, _startPosY + 10, 40, 20);
                g.DrawRectangle(pen, _startPosX + 80, _startPosY + 10, 40, 20);
                g.DrawRectangle(pen, _startPosX + 130, _startPosY + 10, 30, 20);
                g.DrawEllipse(pen, _startPosX + 140, _startPosY + 10, 30, 20);



                g.FillRectangle(window, _startPosX - 20, _startPosY + 10, 40, 20);
                g.FillRectangle(window, _startPosX + 30, _startPosY + 10, 40, 20);
                g.FillRectangle(window, _startPosX + 80, _startPosY + 10, 40, 20);
                g.FillRectangle(window, _startPosX + 130, _startPosY + 10, 30, 20);
                g.FillEllipse(window, _startPosX + 140, _startPosY + 10, 30, 20);


            }

            

        }
    }
}
