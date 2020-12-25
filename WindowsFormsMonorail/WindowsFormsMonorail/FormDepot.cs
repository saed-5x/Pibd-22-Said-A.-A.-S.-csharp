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

        private readonly DepotCollection depotCollection;
        public FormDepot()
        {
            InitializeComponent();
            depotCollection = new DepotCollection(PicBoxStation.Width,PicBoxStation.Height);
            Draw();
        }

        private void ReloadLevels()
        {
            int index = ListBoxDepot.SelectedIndex;
            ListBoxDepot.Items.Clear();
            for (int i = 0; i < depotCollection.Keys.Count; i++)
            {
                ListBoxDepot.Items.Add(depotCollection.Keys[i]);
            }
            if (ListBoxDepot.Items.Count > 0 && (index == -1 || index >= ListBoxDepot.Items.Count))
            {
                ListBoxDepot.SelectedIndex = 0;
            }
            else if (ListBoxDepot.Items.Count > 0 && index > -1 && index < ListBoxDepot.Items.Count)
            {
                ListBoxDepot.SelectedIndex = index;
            }
        }
/*all is well*/
        private void Draw()
        {
            if (ListBoxDepot.SelectedIndex > -1)
            {
                Bitmap bmp = new Bitmap(PicBoxStation.Width, PicBoxStation.Height);
                Graphics gr = Graphics.FromImage(bmp);
                depotCollection[ListBoxDepot.SelectedItem.ToString()].Draw(gr);
                PicBoxStation.Image = bmp;
            }
        }

        private void ParkingMonorail_Click(object sender, EventArgs e)
        {
            if (ListBoxDepot.SelectedIndex > -1)
            {
                ColorDialog dialog = new ColorDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    ColorDialog dialogDop = new ColorDialog();
                    if (dialogDop.ShowDialog() == DialogResult.OK)
                    {
                        var train = new Monorail(100, 1000,dialog.Color, dialogDop.Color, true, true,false);
                        if (depotCollection[ListBoxDepot.SelectedItem.ToString()] + train)
                        {
                            Draw();
                        }
                        else
                        {
                            MessageBox.Show("Нет свободных мест", "Ошибка",MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void ParkingLocomotive_Click(object sender, EventArgs e)
        {

            if (ListBoxDepot.SelectedIndex > -1)
            {
                ColorDialog dialog = new ColorDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    ColorDialog dialogDop = new ColorDialog();
                    if (dialogDop.ShowDialog() == DialogResult.OK)
                    {
                        var train = new Locomotive(100, 1000,  dialog.Color, dialogDop.Color, true, true,true);
                      
                        if (depotCollection[ListBoxDepot.SelectedItem.ToString()] + train)
                        {
                            Draw();
                        }
                        else
                        {
                            MessageBox.Show("Нет свободных мест", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }

        }

        private void buttonTake_Click(object sender, EventArgs e)
        {
            if (ListBoxDepot.SelectedIndex > -1 && MaskTexBoxTrainStation.Text != "")
            {
                var train = depotCollection[ListBoxDepot.SelectedItem.ToString()] - Convert.ToInt32(MaskTexBoxTrainStation.Text);
                if (train != null)
                {
                    FormMonorail form = new FormMonorail();
                    form.SetTrain(train);
                    form.ShowDialog();
                }
                Draw();
            }
        }

        private void buttonDelDepot_Click(object sender, EventArgs e)
        {
            if (ListBoxDepot.SelectedIndex > -1)
            {
                if (MessageBox.Show($"Удалить парковку {ListBoxDepot.SelectedItem.ToString()}?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    depotCollection.DelParking(TextBoxStationName.Text);
                    ReloadLevels();
                }
            }
        }

        private void buttonAddDepot_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TextBoxStationName.Text))
            {
                MessageBox.Show("Введите название парковки", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            depotCollection.AddParking(TextBoxStationName.Text);
            ReloadLevels();
        }

        private void ListBoxDepot_SelectedIndexChanged(object sender, EventArgs e)
        {
            Draw();
        }

    }
}
