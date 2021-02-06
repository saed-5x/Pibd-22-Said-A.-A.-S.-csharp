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
    public partial class FormMonorailConfig : Form
    {

        private event Action<Vehicle> eventAddTrain;
        Vehicle train = null;

        public FormMonorailConfig()
        {
            InitializeComponent();
            panelBlack.MouseDown += panelColor_MouseDown;
            panelOrange.MouseDown += panelColor_MouseDown;
            panelGray.MouseDown += panelColor_MouseDown;
            panelGreen.MouseDown += panelColor_MouseDown;
            panelRed.MouseDown += panelColor_MouseDown;
            panelWhite.MouseDown += panelColor_MouseDown;
            panelYellow.MouseDown += panelColor_MouseDown;
            panelBlue.MouseDown += panelColor_MouseDown;
            buttonCancel.Click += (object sender, EventArgs e) => { Close(); };
        }

        private void panelColor_MouseDown(object sender, MouseEventArgs e)
        {
            (sender as Control).DoDragDrop((sender as Control).BackColor, DragDropEffects.Move | DragDropEffects.Copy);
        }

        private void DrawTrain()
        {
            if (train != null)
            {
                Bitmap bmp = new Bitmap(PicBoxMonorail.Width, PicBoxMonorail.Height);
                Graphics gr = Graphics.FromImage(bmp);
                train.SetPosition(400,25, PicBoxMonorail.Width, PicBoxMonorail.Height);
                train.DrawMonorail(gr);
                PicBoxMonorail.Image = bmp;
            }
        }

        public void AddEvent(Action<Vehicle> ev)
        {
            if (eventAddTrain == null)
            {
                eventAddTrain =  ev;
            }
            else
            {
                eventAddTrain += ev;
            }
        }
        private void labelMonorail_MouseDown(object sender, MouseEventArgs e)
        {
            label_Monorail.DoDragDrop(label_Monorail.Text, DragDropEffects.Move | DragDropEffects.Copy);
        }

        private void labelLocomotive_Click(object sender, EventArgs e)
        {
            label_Locomotive.DoDragDrop(label_Locomotive.Text, DragDropEffects.Move | DragDropEffects.Copy);
        }

        private void panelMonorail_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }

        }
        private void panelMonorail_DragDrop(object sender, DragEventArgs e)
        {
            switch (e.Data.GetData(DataFormats.Text).ToString())
            {
                case "Locomotive":                
                    train = new Locomotive((int)numericUpDownMaxSpeed.Value, (int)numericUpDownWeight.Value, Color.Yellow, Color.DarkGreen, checkBoxWindows.Checked, checkBoxDoors.Checked,checkBoxRailway.Checked);
                    break;
                case "Monorail":
                    train = new Monorail((int)numericUpDownMaxSpeed.Value, (int)numericUpDownWeight.Value,  Color.Yellow, Color.DarkGreen,
                    checkBoxWindows.Checked, checkBoxDoors.Checked,checkBoxRailway.Checked);
                    break;
            }
            DrawTrain();
        }

        private void labelMainColor_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Color)))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void labelMainColor_DragDrop(object sender, DragEventArgs e)
        {
            if (train != null)
            {
                train.SetMainColor((Color)e.Data.GetData(typeof(Color)));
                DrawTrain();
            }
        }

        private void labelDopColor_DragDrop(object sender, DragEventArgs e)
        {
            if (train != null)
            {
                if (train is Monorail)
                {
                    (train as Monorail).SetSubColor((Color)e.Data.GetData(typeof(Color)));
                    DrawTrain();
                }
            }
        }

        private void labelLocomotive_MouseDown(object sender, MouseEventArgs e)
        {
            label_Locomotive.DoDragDrop(label_Locomotive.Text, DragDropEffects.Move | DragDropEffects.Copy);
        }

        private void button_Add_Train_Click(object sender, EventArgs e)
        {
            eventAddTrain?.Invoke(train);
            Close();
        }

    }
}

