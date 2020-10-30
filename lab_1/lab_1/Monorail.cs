using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using lab_1;

namespace WindowsFormsMonorail
{
    class Monorail
    {
        private float _startPosX;
        private float _startPosY;
        private int _pictureWidth;
        private int _pictureHeight;
        private const int monorailWidth = 100;
        private const int monorailHeight = 60;
        public int MaxSpeed { private set; get; }
        public float Weight { private set; get; }
        public Color MainColor { private set; get; }
        public Color DopColor { private set; get; }

        public Color Windows { private set; get; }
        public bool Window { private set; get; }
        public bool SideStrip { private set; get; }

        public bool Door_1 { private set; get; }

        public bool Door_2 { private set; get; }

        public bool Door_3 { private set; get; }
        public Monorail(int maxSpeed, float weight, Color mainColor, Color dopColor, Color windows, bool window, bool sideStripe ,bool door_1,bool door_2,bool door_3)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
            DopColor = dopColor;
            Window = window;
            SideStrip = sideStripe;
            Windows = windows;
            Door_1 = door_1;
            Door_2 = door_2;
            Door_3 = door_3;

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
            float step = MaxSpeed * 300 / Weight;
            switch (direction)
            {
                case Direction.Right:
                    if (_startPosX + step < _pictureWidth - monorailWidth)
                    {
                        _startPosX += step;
                    }
                    break;
                case Direction.Left:
                    if (_startPosX - step > 0)
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




            Brush monorail = new SolidBrush(DopColor);
            Brush wire = new SolidBrush(Color.Black);

            g.FillRectangle(wire, _startPosX + 30 , _startPosY - 15 , 5, 20);
            g.FillRectangle(wire, _startPosX + 100, _startPosY - 15, 5, 20);
            g.FillRectangle(wire, _startPosX - 40, _startPosY - 25, 250, 20);

            g.FillRectangle(monorail, _startPosX-30, _startPosY, 180, 60);
            g.FillEllipse(monorail, _startPosX+120, _startPosY, 60, 50);
            g.FillEllipse(monorail, _startPosX + 100, _startPosY + 15, 100, 45);

            if (Window)
            {
              //  g.DrawRectangle(pen, _startPosX, _startPosY + 10, 90, 20);
                Brush window = new SolidBrush(Windows);
                 g.FillRectangle(window, _startPosX - 20, _startPosY + 10, 40, 20);
                 g.FillRectangle(window, _startPosX + 30, _startPosY + 10, 40, 20);
                 g.FillRectangle(window, _startPosX + 80, _startPosY + 10, 40, 20);
                 g.FillRectangle(window, _startPosX + 130, _startPosY + 10, 30, 20);
                 g.FillEllipse(window, _startPosX + 140, _startPosY + 10, 30, 20);
            }
            if (SideStrip)
            {

            //    g.DrawRectangle(pen, _startPosX, _startPosY + 35, 90, 10);
                Brush strip = new SolidBrush(MainColor);
             //   g.FillRectangle(strip, _startPosX, _startPosY + 35, 90, 10);



               
                g.FillRectangle(strip, _startPosX -30 , _startPosY + 35, 220, 12);
                g.FillEllipse(strip, _startPosX + 180, _startPosY + 35, 20, 12);
            }
            if (Door_1)
            {


                Brush door = new SolidBrush(MainColor);

                g.FillRectangle(door, _startPosX - 100, _startPosY, 10,60 );



            }


        }
    }
}