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

        /// <summary>
        /// Объект от класса-коллекции парковок
        /// </summary>
        private readonly ParkingCollection parkingCollection;
        public FormParking()
        {
            InitializeComponent();
            parkingCollection = new ParkingCollection(pictureBoxParking.Width, pictureBoxParking.Height);
         
        }
        /// <summary>
        /// Заполнение listBoxLevels
        /// </summary>
        private void ReloadLevels()
        {
            int index = listBoxParkings.SelectedIndex;
            listBoxParkings.Items.Clear();
            for (int i = 0; i < parkingCollection.Keys.Count; i++)
            {
                listBoxParkings.Items.Add(parkingCollection.Keys[i]);
            }
            if (listBoxParkings.Items.Count > 0 && (index == -1 || index >= listBoxParkings.Items.Count))
            {
                listBoxParkings.SelectedIndex = 0;
            }
            else if (listBoxParkings.Items.Count > 0 && index > -1 && index < listBoxParkings.Items.Count)
            {
                listBoxParkings.SelectedIndex = index;
            }
        }
        /// <summary>
        /// Метод отрисовки парковки
        /// </summary>
        private void Draw()
        {
            if (listBoxParkings.SelectedIndex > -1)
            {//если выбран один из пуктов в listBox (при старте программы ни один пункт не будет выбран и может возникнуть ошибка, если мы попытаемся обратиться к элементу listBox)
                Bitmap bmp = new Bitmap(pictureBoxParking.Width, pictureBoxParking.Height);
                Graphics gr = Graphics.FromImage(bmp);
                parkingCollection[listBoxParkings.SelectedItem.ToString()].Draw(gr);
                pictureBoxParking.Image = bmp;

                if(listBoxParkings.SelectedIndex > -1)
                {
                    parkingCollection[listBoxParkings.SelectedItem.ToString()].Draw(gr);
                }else
                {
                    MessageBox.Show("Автовокзал переполнен");
                    gr.FillRectangle(new SolidBrush(Color.Transparent), 0, 0, pictureBoxParking.Width,pictureBoxParking.Height);
                }
                pictureBoxParking.Image = bmp;
            }
        }


        private void buttonDelParkin_Click_Click(object sender, EventArgs e)
        {
            if (listBoxParkings.SelectedIndex > -1)
            {
                if (MessageBox.Show($"Удалить автовокзал {listBoxParkings.SelectedItem.ToString()}?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    parkingCollection.DelParking(listBoxParkings.SelectedItem.ToString());
                    ReloadLevels();
                }
            }
        }

        private void buttonAddParkin_Click_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxNewLevelName.Text))
            {
                MessageBox.Show("Введите название парковки", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            parkingCollection.AddParking(textBoxNewLevelName.Text);
            ReloadLevels();
        }

        private void ParkingMonorail_Click(object sender, EventArgs e)
        {
            if (listBoxParkings.SelectedIndex > -1)
            {
                ColorDialog dialog = new ColorDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    ColorDialog dialogDop = new ColorDialog();
                    if (dialogDop.ShowDialog() == DialogResult.OK)
                    {
                        var train = new Monorail(100, 1000, Color.White, dialog.Color, dialogDop.Color, true, true);
                      
                        if (parkingCollection[listBoxParkings.SelectedIndex.ToString()] +train)
                        {
                            Draw();
                        }
                        else
                        {
                            MessageBox.Show("Нет свободных мест", "Ошибка",
                           MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                       
                    }
                }
            }
        }

        private void ParkingLocomotive_Click(object sender, EventArgs e)
        {

            if (listBoxParkings.SelectedIndex > -1)
            {
                ColorDialog dialog = new ColorDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    ColorDialog dialogDop = new ColorDialog();
                    if (dialogDop.ShowDialog() == DialogResult.OK)
                    {
                        var train = new Locomotive(100, 1000, dialog.Color, dialogDop.Color, true, true);

                        if (parkingCollection[listBoxParkings.SelectedIndex.ToString()] + train)
                        {
                            Draw();
                        }
                        else
                        {
                            MessageBox.Show("Автовокзал переполнен", "Ошибка",
                           MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }

                    }
                }
            }

        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (listBoxParkings.SelectedIndex > -1)
            {
                if (maskedTextBoxParking.Text != "")
                {
                    var train = parkingCollection[listBoxParkings.SelectedIndex.ToString()] -Convert.ToInt32(maskedTextBoxParking.Text);
                    if (train != null)
                    {
                        FormMonorail form = new FormMonorail();
                        form.SetMonorail(train);
                        form.ShowDialog();
                    }
                    else
                    {
                        Bitmap bmp = new Bitmap(pictureBoxTake.Width,
                       pictureBoxTake.Height);
                        pictureBoxTake.Image = bmp;
                    }
                    Draw();
                }

            }
  
        }

        private void buttonAddParking_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Обработка нажатия кнопки "Удалить парковку"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDelParking_Click(object sender, EventArgs e)
        {

        }

        private void listBoxParkings_SelectedIndexChanged(object sender, EventArgs e)
        {
            Draw();
        }

        private void textBoxNewLevelName_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBoxParkings_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

    }
}
