using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using lab_1;


namespace WindowsFormsMonorail
{
    public class Monorail : Locomotive
    {
        public Color Windows { private set; get; }
     //   public Color SideColor { private set; get; }
        public Monorail(int maxSpeed, float weight, Color windows, Color bodycolor ,Color sidestrip, bool window, bool doors):base( maxSpeed,  weight, bodycolor, sidestrip,  window, doors)     
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            Window = window;
            BodyColor = bodycolor;
            Doors = doors;
            Windows = windows;
            SideStrip = sidestrip;
        }

        public override void DrawMonorail(Graphics g)
        {
            Pen pen = new Pen(Color.Black);

            float resize = 1.1f;

        
            Brush wire = new SolidBrush(Color.Black);
                      
            Brush monorail = new SolidBrush(BodyColor); 

            Brush clip = new SolidBrush(Color.RoyalBlue);

            Brush window = new SolidBrush(Windows);

            Brush strip = new SolidBrush(SideStrip);



          ///  g.FillRectangle(wire, _startPosX - (400 / resize), _startPosY + (50 / resize), 600 / resize, 35 / resize);

            /*
            g.FillRectangle(clip, _startPosX - (55 / resize), _startPosY + (5 / resize), 25 / resize, 55 / resize);
            g.FillRectangle(clip, _startPosX - (166 / resize), _startPosY + (5 / resize), 25 / resize, 55 / resize);
            g.FillRectangle(clip, _startPosX - (295 / resize), _startPosY + (5 / resize), 25 / resize, 55 / resize);                     
                     
            g.FillRectangle(monorail, _startPosX - (150 / resize), _startPosY, 105 / resize, 60 / resize);
            g.FillRectangle(monorail, _startPosX - (270 / resize), _startPosY, 105 / resize, 60 / resize);
            g.FillRectangle(monorail, _startPosX - (390 / resize), _startPosY, 105 / resize, 60 / resize);
                     
            */

          
            base.DrawMonorail(g);

            g.FillRectangle(wire, _startPosX - (400 / resize), _startPosY + (60 / resize), 600 / resize, 25 / resize);

            g.FillRectangle(monorail, _startPosX - (30 / resize), _startPosY, 180 / resize, 60 / resize);
            g.FillEllipse(monorail, _startPosX + (120 / resize), _startPosY, 60 / resize, 50 / resize);
            g.FillEllipse(monorail, _startPosX + (100 / resize), _startPosY + (15 / resize), 100 / resize, 45 / resize);

            g.FillRectangle(strip, _startPosX - (30 / resize), _startPosY + (35 / resize), 220 / resize, 12 / resize);
            g.FillEllipse(strip, _startPosX + (180 / resize), _startPosY + (35 / resize), 20 / resize, 12 / resize);

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
                g.DrawRectangle(pen, _startPosX - (235 / resize), _startPosY + (10 / resize), 31 / resize, 45 / resize);
                g.FillRectangle(door2, _startPosX - (235 / resize), _startPosY + (10 / resize), 30 / resize, 45 / resize);
                g.DrawRectangle(pen, _startPosX - (220 / resize), _startPosY + (10 / resize), 16 / resize, 45 / resize);

                Brush door3 = new SolidBrush(Color.Fuchsia);
                g.DrawRectangle(pen, _startPosX - (355 / resize), _startPosY + (10 / resize), 30 / resize, 45 / resize);
                g.FillRectangle(door3, _startPosX - (355 / resize), _startPosY + (10 / resize), 30 / resize, 45 / resize);
                g.DrawRectangle(pen, _startPosX - (340 / resize), _startPosY + (10 / resize), 15 / resize, 45 / resize);
              
            }
            
            if (Window)
            {

                g.DrawRectangle(pen, _startPosX - (20 / resize), _startPosY + (10 / resize), 40 / resize, 20 / resize);
                g.DrawRectangle(pen, _startPosX + (30 / resize), _startPosY + (10 / resize), 40 / resize, 20 / resize);
                g.DrawRectangle(pen, _startPosX + (80 / resize), _startPosY + (10 / resize), 40 / resize, 20 / resize);
                g.DrawRectangle(pen, _startPosX + (130 / resize), _startPosY + (10 / resize), 30 / resize, 20 / resize);
                g.DrawEllipse(pen, _startPosX + (140 / resize), _startPosY + (10 / resize), 30 / resize, 20 / resize);



                g.FillRectangle(window, _startPosX - (20 / resize), _startPosY + (10 / resize), 40 / resize, 20 / resize);
                g.FillRectangle(window, _startPosX + (30 / resize), _startPosY + (10 / resize), 40 / resize, 20 / resize);
                g.FillRectangle(window, _startPosX + (80 / resize), _startPosY + (10 / resize), 40 / resize, 20 / resize);
                g.FillRectangle(window, _startPosX + (130 / resize), _startPosY + (10 / resize), 30 / resize, 20 / resize);
                g.FillEllipse(window, _startPosX + (140 / resize), _startPosY + (10 / resize), 30 / resize, 20 / resize);


            }
        }
    }
}