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

        /// <summary>
        /// Объект от класса-коллекции парковок
        /// </summary>
        private readonly StationCollection stationCollection;
        public FormTrainStation()
        {
            InitializeComponent();
            stationCollection = new StationCollection(PicBoxStation.Width,PicBoxStation.Height);
            Draw();
        }

        /// <summary>
        /// Заполнение listBoxLevels
        /// </summary>
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

        /// <summary>
        /// Метод отрисовки парковки
        /// </summary>
        private void Draw()
        {
            if (ListBoxStation.SelectedIndex > -1)
            {//если выбран один из пуктов в listBox (при старте программы ни один пункт не будет выбран и может возникнуть ошибка, если мы попытаемся обратиться к элементу listBox)
                Bitmap bmp = new Bitmap(PicBoxStation.Width, PicBoxStation.Height);
                Graphics gr = Graphics.FromImage(bmp);
                stationCollection[ListBoxStation.SelectedItem.ToString()].Draw(gr);
                PicBoxStation.Image = bmp;
            }
        }


        private void ParkingMonorail_Click(object sender, EventArgs e)
        {
            if (ListBoxStation.SelectedIndex > -1)
            {
                ColorDialog dialog = new ColorDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    ColorDialog dialogDop = new ColorDialog();
                    if (dialogDop.ShowDialog() == DialogResult.OK)
                    {
                        var train = new Monorail(100, 1000, Color.White, dialog.Color, dialogDop.Color, true, true);
                        if (stationCollection[ListBoxStation.SelectedItem.ToString()] + train)
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

            if (ListBoxStation.SelectedIndex > -1)
            {
                ColorDialog dialog = new ColorDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    ColorDialog dialogDop = new ColorDialog();
                    if (dialogDop.ShowDialog() == DialogResult.OK)
                    {
                        var train = new Locomotive(100, 1000,  dialog.Color, dialogDop.Color, true, true);
                      
                        if (stationCollection[ListBoxStation.SelectedItem.ToString()] + train)
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

        /// <summary>
        /// Метод обработки выбора элемента на listBoxLevels
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

    }
}
