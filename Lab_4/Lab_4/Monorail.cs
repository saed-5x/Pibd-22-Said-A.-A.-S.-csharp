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




          
            base.DrawMonorail(g);

            g.FillRectangle(wire, Xstart - (400 / resize), Ystart + (60 / resize), 600 / resize, 25 / resize);

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
                g.DrawRectangle(pen, Xstart - (235 / resize), Ystart + (10 / resize), 31 / resize, 45 / resize);
                g.FillRectangle(door2, Xstart - (235 / resize), Ystart + (10 / resize), 30 / resize, 45 / resize);
                g.DrawRectangle(pen, Xstart - (220 / resize), Ystart + (10 / resize), 16 / resize, 45 / resize);

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