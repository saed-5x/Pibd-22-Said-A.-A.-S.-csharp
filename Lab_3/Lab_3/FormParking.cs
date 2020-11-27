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


    public partial class FormParking : Form
    {

        private readonly Parking<ITransport> parking;
        public FormParking()
        {
            InitializeComponent();
            parking = new Parking<ITransport>( 20,pictureBoxParking.Width,pictureBoxParking.Height);
            Draw();
        }

        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxParking.Width, pictureBoxParking.Height);
            Graphics gr = Graphics.FromImage(bmp);
            parking.Draw(gr);
            pictureBoxParking.Image = bmp;
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
                    bool place = parking + train;
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
                    bool place = parking + train;
                    Draw();
                }
            }

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if( maskedTextBoxParking.Text != "")
            {
                var car = parking - Convert.ToInt32(maskedTextBoxParking.Text);
                if (car != null)
                {
                    FormMonorail form = new FormMonorail();
                    form.SetCar(car);
                    form.ShowDialog();
                }
                Draw();
            }
        }

        private void maskedTextBoxParking_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBoxParking_Click(object sender, EventArgs e)
        {

        }
    }
}
