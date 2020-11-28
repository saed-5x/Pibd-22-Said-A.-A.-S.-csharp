using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1
{
    public abstract class Vehicle : ITransport
    {
        protected float Xstart;

        protected float Ystart;

        protected int PicWidth;

        protected int PicHeight;


        public int MaxSpeed { protected set; get; }
        public float Weight { protected set; get; }
        public Color BodyColor { protected set; get; }
        public Color SideStrip { protected set; get; }
        public bool Window { protected set; get; }
        public bool Doors { protected set; get; }

        public void SetPosition(int x, int y, int width, int height)
        {
            Xstart = x;
            Ystart = y;
            PicWidth = width;
            PicHeight = height;
        }

        public abstract void DrawMonorail(Graphics g);


        public abstract void MoveMonorail(Direction direction);
    }
}
