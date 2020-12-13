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

    public partial class FormDepot : Form
    {

        private readonly Depot<ITransport> depot;
        public FormDepot()
        {
            InitializeComponent();
            depot = new Depot<ITransport>( 20,PicBoxStation.Width,PicBoxStation.Height);
            Draw();
        }

        private void Draw()
        {
            Bitmap bmp = new Bitmap(PicBoxStation.Width, PicBoxStation.Height);
            Graphics gr = Graphics.FromImage(bmp);
            depot.Draw(gr);
            PicBoxStation.Image = bmp;
        }

        private void ParkingMonorail_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                ColorDialog dialogDop = new ColorDialog();
                if (dialogDop.ShowDialog() == DialogResult.OK)
                {
                    var train = new Monorail(100, 1000,dialog.Color, dialogDop.Color,true, true, false);
                    bool Depot = depot + train;
                    Draw();
                }
            }
        }

        private void ParkingLocomotive_Click(object sender, EventArgs e)
        {

            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                ColorDialog dialogDop = new ColorDialog();
                if (dialogDop.ShowDialog() == DialogResult.OK)
                {

                    var train = new Locomotive(100, 1000, dialog.Color, dialogDop.Color, true, true, true);
                    bool Depot = depot + train;
                    Draw();
                }
            }

        }

        private void buttonTake_Click(object sender, EventArgs e)
        {
            if (MaskTexBoxTrainStation.Text != "")
            {
                var train = depot - Convert.ToInt32(MaskTexBoxTrainStation.Text);
                if (train != null)
                {
                    Bitmap bmp = new Bitmap(pictureBoxTake.Width,
                   pictureBoxTake.Height);
                    Graphics gr = Graphics.FromImage(bmp);
                    train.SetPosition(370, 5, pictureBoxTake.Width,pictureBoxTake.Height);
                    train.DrawMonorail(gr);
                    pictureBoxTake.Image = bmp;
                }
                else
                {
                    Bitmap bmp = new Bitmap(pictureBoxTake.Width,pictureBoxTake.Height);
                    pictureBoxTake.Image = bmp;
                }
                Draw();
            }
        }
    }
}
