using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1
{

    public class Locomotive : Vehicle
    {
        protected const int monorailWidth = 200;
        protected const int monorailHeight = 150;



        

  
        public Locomotive(int maxSpeed, float weight, Color bodycolor,Color sidecolor, bool window, bool doors)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;

            
            Doors = doors;


            
            sideColor = sidecolor;
            BodyColor = bodycolor;

        }



        public override void MoveTransport(Direction direction)
        {
            float step = MaxSpeed * 200 / Weight;
            switch (direction)
            {
                // вправо
                case Direction.Right:
                    if (_startPosX + step < _pictureWidth - monorailWidth)
                    {
                        _startPosX += step;
                    }
                    break;
                //влево
                case Direction.Left:
                    if (_startPosX - step > monorailWidth+150)
                    {
                        _startPosX -= step;
                    }
                    break;
                //вверх
                case Direction.Up:
                    if (_startPosY - step > 0)
                    {
                        _startPosY -= step;
                    }
                    break;
                //вниз
                case Direction.Down:
                    if (_startPosY + step < _pictureHeight - monorailHeight)
                    {
                        _startPosY += step;
                    }
                    break;
            }
        }

        public override void DrawMonorail(Graphics g)
        {
            Pen pen = new Pen(Color.Black);

            float resize = 1.1f;

          
            


                Brush Locomotive = new SolidBrush(BodyColor);

                Brush clip = new SolidBrush(Color.Orange);

                Brush window = new SolidBrush(Color.White);

                Brush strip = new SolidBrush(Color.DarkGreen);

                Brush wire = new SolidBrush(Color.Black);

                Brush wires = new SolidBrush(Color.White);


                g.FillRectangle(wire, _startPosX - (400 / resize), _startPosY + (90 / resize), 550 / resize, 4 / resize);

                int j = 0;
                while (j < 500)
                {
                    
                    j = j + 40;
                    g.FillEllipse(wire, _startPosX - (390 -j / resize), _startPosY + (63 / resize), 25  / resize, 25 / resize);
                    g.FillEllipse(wires, _startPosX - (387 - j / resize), _startPosY + (66 / resize), 19  / resize, 19 / resize);
                    g.FillEllipse(wire, _startPosX - (380 -j  / resize), _startPosY + (73 / resize), 5  / resize, 5 / resize);


                }

                int l = 0;
                while (l < 460)
                {

                    l = l + 80;
                    g.FillRectangle(wire, _startPosX - (430 - l / resize), _startPosY + (70 / resize), 60 / resize, 4 / resize);


                }






            g.FillRectangle(Locomotive, _startPosX - (30 / resize), _startPosY, 80 / resize, 60 / resize);
       
            g.FillRectangle(Locomotive, _startPosX + (120 / resize), _startPosY + (20 / resize), 10 / resize, 50 / resize);


            g.FillRectangle(Locomotive, _startPosX + (100 / resize), _startPosY , 20 / resize, 20 / resize);


            g.FillRectangle(Locomotive, _startPosX + (30 / resize), _startPosY + (20 / resize), 100 / resize, 40 / resize);


            g.FillRectangle(clip, _startPosX - (55 / resize), _startPosY + (5 / resize), 25 / resize, 55 / resize);
            g.FillRectangle(clip, _startPosX - (166 / resize), _startPosY + (5 / resize), 25 / resize, 55 / resize);
            g.FillRectangle(clip, _startPosX - (295 / resize), _startPosY + (5 / resize), 25 / resize, 55 / resize);


            g.FillRectangle(Locomotive, _startPosX - (150 / resize), _startPosY, 105 / resize, 60 / resize);
            g.FillRectangle(Locomotive, _startPosX - (270 / resize), _startPosY, 105 / resize, 60 / resize);



            g.FillRectangle(Locomotive, _startPosX - (390 / resize), _startPosY, 105 / resize, 60 / resize);


            g.FillRectangle(strip, _startPosX - (30 / resize), _startPosY + (35 / resize), 160 / resize, 12 / resize);
           // g.FillEllipse(strip, _startPosX + (180 / resize), _startPosY + (35 / resize), 20 / resize, 12 / resize);

            g.FillRectangle(strip, _startPosX - (270 / resize), _startPosY + (35 / resize), 105 / resize, 12 / resize);
            g.FillRectangle(strip, _startPosX - (390 / resize), _startPosY + (35 / resize), 105 / resize, 12 / resize);

            g.FillRectangle(strip, _startPosX - (150 / resize), _startPosY + (35 / resize), 105 / resize, 12 / resize);


            if (Doors)
            {
                Brush door1 = new SolidBrush(Color.Green);
                g.DrawRectangle(pen, _startPosX - (115 / resize), _startPosY + (10 / resize), 30 / resize, 45 / resize);

                g.FillRectangle(door1, _startPosX - (115 / resize), _startPosY + (10 / resize), 30 / resize, 45 / resize);
                g.DrawRectangle(pen, _startPosX - (100 / resize), _startPosY + (10 / resize), 15 / resize, 45 / resize);

                Brush door2 = new SolidBrush(Color.Yellow);
                g.DrawRectangle(pen, _startPosX - (235 / resize), _startPosY + (9 / resize), 31 / resize, 45 / resize);
                g.FillRectangle(door2, _startPosX - (235 / resize), _startPosY + (10 / resize), 30 / resize, 45 / resize);
                g.DrawRectangle(pen, _startPosX - (220 / resize), _startPosY + (9 / resize), 16 / resize, 45 / resize);

                Brush door3 = new SolidBrush(Color.Fuchsia);
                g.DrawRectangle(pen, _startPosX - (355 / resize), _startPosY + (10 / resize), 30 / resize, 45 / resize);
                g.FillRectangle(door3, _startPosX - (355 / resize), _startPosY + (10 / resize), 30 / resize, 45 / resize);
                g.DrawRectangle(pen, _startPosX - (340 / resize), _startPosY + (10 / resize), 15 / resize, 45 / resize);

            }




            if (Window)
            {

                g.DrawRectangle(pen, _startPosX - (20 / resize), _startPosY + (10 / resize), 40 / resize, 20 / resize);
                g.FillRectangle(window, _startPosX - (20 / resize), _startPosY + (10 / resize), 40 / resize, 20 / resize);


            }



            


        }
    }
    
}
