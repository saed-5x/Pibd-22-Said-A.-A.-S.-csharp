using System;
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


        /// <summary>
        /// Метод отрисовки машины
        /// </summary>
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
        /// <summary>
        /// Обработка нажатия кнопки "Создать"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 


        private void buttonCreateMonorail_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            monorail = new Monorail(rnd.Next(100, 300), rnd.Next(100, 300), Color.White,Color.Red, Color.Blue, true, true);
            monorail.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100), PicBoxMonorail.Width, PicBoxMonorail.Height);
            Draw();
        }

        /// <summary>
        /// Обработка нажатия кнопок управления
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonMove_Click(object sender, EventArgs e)
        {
            //получаем имя кнопки
            string name = (sender as Button).Name;
            switch (name)
            {
                case "buttonUp":
                    monorail.MoveMonorail(Direction.Up);
                    break;
                case "buttonDown":
                    monorail.MoveMonorail(Direction.Down);
                    break;
                case "buttonLeft":
                    monorail.MoveMonorail(Direction.Left);
                    break;
                case "buttonRight":
                    monorail.MoveMonorail(Direction.Right);
                    break;
            }
            Draw();
        }

        private void buttonCreateLocomotive_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            monorail = new Locomotive(rnd.Next(150, 300), rnd.Next(100, 300), Color.White,Color.Orange, true, true);
            monorail.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100), PicBoxMonorail.Width, PicBoxMonorail.Height);
            Draw();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
