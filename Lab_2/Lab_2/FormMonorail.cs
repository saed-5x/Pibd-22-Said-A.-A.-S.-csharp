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

        //private Monorail monorail;
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
            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics gr = Graphics.FromImage(bmp);
            monorail.DrawMonorail(gr);
            pictureBox1.Image = bmp;
        }
        /// <summary>
        /// Обработка нажатия кнопки "Создать"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 

        private void button_Create_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            monorail = new Monorail(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.White,Color.Red, Color.Blue, true, true);
            monorail.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100), pictureBox1.Width, pictureBox1.Height);
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
                    monorail.MoveTransport(Direction.Up);
                    break;
                case "buttonDown":
                    monorail.MoveTransport(Direction.Down);
                    break;
                case "buttonLeft":
                    monorail.MoveTransport(Direction.Left);
                    break;
                case "buttonRight":
                    monorail.MoveTransport(Direction.Right);
                    break;
            }
            Draw();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            monorail = new Locomotive(rnd.Next(150, 300), rnd.Next(1000, 2000), Color.Gold,Color.DarkGreen, true, true);
            monorail.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100), pictureBox1.Width, pictureBox1.Height);
            Draw();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
