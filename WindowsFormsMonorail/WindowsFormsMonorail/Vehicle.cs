﻿using System.Drawing;

namespace lab_1
{
    public abstract class Vehicle : ITransport
    {
        protected float Xstart;
        protected float Ystart;
        protected int PicMonorsilWidth;
        protected int PicMonorailHeight;
        public int MaxSpeed { protected set; get; }
        public float Weight { protected set; get; }
        public Color BodyColor { protected set; get; }
        public Color SideStrip { protected set; get; }
        public bool Window { protected set; get; }
        public bool Doors { protected set; get; }
        public bool Railway { protected set; get; }

        public void SetPosition(int x, int y, int width, int height)
        {
            Xstart = x;
            Ystart = y;
            PicMonorsilWidth = width;
            PicMonorailHeight = height;
        }
        public abstract void DrawMonorail(Graphics g);
        public abstract void MoveMonorail(Direction direction);
    }
}
