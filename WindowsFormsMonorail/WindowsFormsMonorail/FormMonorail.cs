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

        private Monorail monorail;
        public FormMonorail()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Метод отрисовки машины
        /// </summary>
        private void Draw()
        {
            Bitmap bmp = new Bitmap(PicBox.Width, PicBox.Height);
            Graphics gr = Graphics.FromImage(bmp);
            monorail.DrawMonorail(gr);
            PicBox.Image = bmp;
        }
        /// <summary>///
        /// Обработка нажатия кнопки "Создать"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 

        private void buttonCreateMonorail_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            monorail = new Monorail(rnd.Next(150, 300), rnd.Next(1000, 2000), Color.Gold, Color.DarkGreen, true, true, true);
            monorail.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100), PicBox.Width, PicBox.Height);
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

    }
}
