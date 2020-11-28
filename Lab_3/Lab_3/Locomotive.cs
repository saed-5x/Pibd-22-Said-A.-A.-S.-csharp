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
        protected const int MonorailWidth = 200;
        protected const int MonorailHeight = 150;


  
        public Locomotive(int maxSpeed, float weight, Color bodycolor,Color sidestrip, bool window, bool doors)
           
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            Window = window;
            SideStrip = sidestrip;
            BodyColor = bodycolor;
            Doors = doors;    


        }



        public override void MoveMonorail(Direction direction)
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

        public override void DrawMonorail(Graphics g)
        {
            Pen pen = new Pen(Color.Black);
            Brush Locomotive = new SolidBrush(BodyColor);
            Brush clip = new SolidBrush(Color.Orange);
            Brush window = new SolidBrush(Color.White);
            Brush strip = new SolidBrush(SideStrip);
            Brush wire = new SolidBrush(Color.Black);
            Brush wires = new SolidBrush(Color.White);


            float resize = 1.1f;

 
                g.FillRectangle(wire, Xstart - (400 / resize), Ystart + (90 / resize), 600 / resize, 4 / resize);

                int j = 0;
                while (j < 500)
                {
                    
                    j = j + 40;
                    g.FillEllipse(wire, Xstart - (390 -j / resize), Ystart + (63 / resize), 25  / resize, 25 / resize);
                    g.FillEllipse(wires, Xstart - (387 - j / resize), Ystart + (66 / resize), 19  / resize, 19 / resize);
                    g.FillEllipse(wire, Xstart - (380 -j  / resize), Ystart + (73 / resize), 5  / resize, 5 / resize);


                }

                int l = 0;
                while (l < 460)
                {

                    l = l + 80;
                    g.FillRectangle(wire, Xstart - (430 - l / resize), Ystart + (70 / resize), 60 / resize, 4 / resize);


                }       



            g.FillRectangle(Locomotive, Xstart - (30 / resize), Ystart, 80 / resize, 60 / resize);
            g.FillRectangle(Locomotive, Xstart + (120 / resize), Ystart + (20 / resize), 10 / resize, 50 / resize);
            g.FillRectangle(Locomotive, Xstart + (100 / resize), Ystart , 20 / resize, 20 / resize);
            g.FillRectangle(Locomotive, Xstart + (30 / resize), Ystart + (20 / resize), 100 / resize, 40 / resize);


            g.FillRectangle(clip, Xstart - (55 / resize), Ystart + (5 / resize), 25 / resize, 55 / resize);
            g.FillRectangle(clip, Xstart - (166 / resize), Ystart + (5 / resize), 25 / resize, 55 / resize);
            g.FillRectangle(clip, Xstart - (295 / resize), Ystart + (5 / resize), 25 / resize, 55 / resize);


            g.FillRectangle(Locomotive, Xstart - (150 / resize), Ystart, 105 / resize, 60 / resize);
            g.FillRectangle(Locomotive, Xstart - (270 / resize), Ystart, 105 / resize, 60 / resize);



            g.FillRectangle(Locomotive, Xstart - (390 / resize), Ystart, 105 / resize, 60 / resize);


            g.FillRectangle(strip, Xstart - (30 / resize), Ystart + (35 / resize), 160 / resize, 12 / resize);
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
                g.FillRectangle(window, Xstart - (20 / resize), Ystart + (10 / resize), 40 / resize, 20 / resize);


            }
            


        }
    }
    
}
