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

        private readonly DepotCollection stationCollection;
        public FormDepot()
        {
            InitializeComponent();
            stationCollection = new DepotCollection(PicBoxStation.Width, PicBoxStation.Height);
            Draw();
        }
        private void ReloadLevels()
        {
            int index = ListBoxStation.SelectedIndex;
            ListBoxStation.Items.Clear();
            for (int i = 0; i < stationCollection.Keys.Count; i++)
            {
                ListBoxStation.Items.Add(stationCollection.Keys[i]);
            }
            if (ListBoxStation.Items.Count > 0 && (index == -1 || index >= ListBoxStation.Items.Count))
            {
                ListBoxStation.SelectedIndex = 0;
            }
            else if (ListBoxStation.Items.Count > 0 && index > -1 && index < ListBoxStation.Items.Count)
            {
                ListBoxStation.SelectedIndex = index;
            }
        }

        private void Draw()
        {
            if (ListBoxStation.SelectedIndex > -1)
            {
                Bitmap bmp = new Bitmap(PicBoxStation.Width, PicBoxStation.Height);
                Graphics gr = Graphics.FromImage(bmp);
                stationCollection[ListBoxStation.SelectedItem.ToString()].Draw(gr);
                PicBoxStation.Image = bmp;
            }
        }

        private void buttonTake_Click(object sender, EventArgs e)
        {
            if (ListBoxStation.SelectedIndex > -1 && MaskTexBoxTrainStation.Text != "")
            {
                var train = stationCollection[ListBoxStation.SelectedItem.ToString()] - Convert.ToInt32(MaskTexBoxTrainStation.Text);
                if (train != null)
                {
                    FormMonorail form = new FormMonorail();
                    form.SetTrain(train);
                    form.ShowDialog();
                }
                Draw();
            }


        }

        private void buttonDelStation_Click(object sender, EventArgs e)
        {
            if (ListBoxStation.SelectedIndex > -1)
            {
                if (MessageBox.Show($"Удалить парковку {ListBoxStation.SelectedItem.ToString()}?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    stationCollection.DelParking(TextBoxStationName.Text);
                    ReloadLevels();
                }
            }
        }

        private void buttonAddStation_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TextBoxStationName.Text))
            {
                MessageBox.Show("Введите название парковки", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            stationCollection.AddParking(TextBoxStationName.Text);
            ReloadLevels();
        }

        private void ListBoxStation_SelectedIndexChanged(object sender, EventArgs e)
        {
            Draw();
        }
        
        private void AddTrain(Vehicle train)
        {   
            if (train != null && ListBoxStation.SelectedIndex > -1)
            {
                if ((stationCollection[ListBoxStation.SelectedItem.ToString()]) + train)
                {
                    Draw();
                }
            }
        }

        private void buttonSetTrain_Click(object sender, EventArgs e)
        {
            var formTrainConfig = new FormMonorailConfig();
            formTrainConfig.AddEvent(AddTrain);
            formTrainConfig.Show();
        }

    }
}

