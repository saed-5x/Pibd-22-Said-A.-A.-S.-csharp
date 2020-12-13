﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsMonorail;

namespace lab_1
{
    public partial class FormMonorail : Form
    {
        private ITransport monorail;
        public FormMonorail()
        {
            InitializeComponent();
        }
        private void Draw()
        {
            Bitmap bmp = new Bitmap(PicBoxMonorail.Width, PicBoxMonorail.Height);
            Graphics gr = Graphics.FromImage(bmp);
            monorail.DrawMonorail(gr);
            PicBoxMonorail.Image = bmp;
        }

        public void SetTrain(ITransport monorail)
        {
            this.monorail = monorail;
            Draw();
            
        }
 
        private void buttonMove_Click(object sender, EventArgs e)
        {
            string name = (sender as Button).Name;
            switch (name)
            {
                case "buttonUp":
                    monorail?.MoveMonorail(Direction.Up);
                    break;
                case "buttonDown":
                    monorail?.MoveMonorail(Direction.Down);
                    break;
                case "buttonLeft":
                    monorail?.MoveMonorail(Direction.Left);
                    break;
                case "buttonRight":
                    monorail?.MoveMonorail(Direction.Right);
                    break;
            }
            Draw();
        }
    }
}
