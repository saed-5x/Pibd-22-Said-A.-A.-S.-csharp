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


    public partial class FormTrainStation : Form
    {

        private readonly TrainStation<ITransport> trainStation;
        public FormTrainStation()
        {
            InitializeComponent();
            trainStation = new TrainStation<ITransport>( 20,PicBoxStation.Width,PicBoxStation.Height);
            Draw();
        }

        private void Draw()
        {
            Bitmap bmp = new Bitmap(PicBoxStation.Width, PicBoxStation.Height);
            Graphics gr = Graphics.FromImage(bmp);
            trainStation.Draw(gr);
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
                    var train = new Monorail(100, 1000, Color.White, dialog.Color, dialogDop.Color, true, true);
                    bool Depot = trainStation + train;
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

                    var train = new Locomotive(100, 1000, dialog.Color, dialogDop.Color, true, true);
                    bool Depot = trainStation + train;
                    Draw();
                }
            }

        }
        


        private void buttonTake_Click(object sender, EventArgs e)
        {
            if (MaskTexBoxTrainStation.Text != "")
            {
                var train = trainStation - Convert.ToInt32(MaskTexBoxTrainStation.Text);
                if (train != null)
                {
                    FormMonorail form = new FormMonorail();
                    form.SetTrain(train);
                    form.ShowDialog();
                }
                Draw();
            }
        }
    }
}
