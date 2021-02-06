using NLog;
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

        DepotCollection stationCollection;
        private readonly Logger logger;

        public FormDepot()
        {
            InitializeComponent();
            stationCollection = new DepotCollection(PicBoxStation.Width, PicBoxStation.Height);
            logger = LogManager.GetCurrentClassLogger();
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

                try
                {
                    var train = stationCollection[ListBoxStation.SelectedItem.ToString()] - Convert.ToInt32(MaskTexBoxTrainStation.Text);
                    if (train != null)
                    {
                        FormMonorail form = new FormMonorail();
                        form.SetTrain(train);
                        form.ShowDialog();
                        Draw();
                    }
                }
                catch (DepotNotFoundException ex)
                {
                    logger.Warn($"Поезд по месту {MaskTexBoxTrainStation.Text} не найден");
                    MessageBox.Show(ex.Message, "Не найдено", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    logger.Warn("Возникла неизвестная ошибка");
                    MessageBox.Show(ex.Message, "Неизвестная ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void buttonDelStation_Click(object sender, EventArgs e)
        {
            if (ListBoxStation.SelectedIndex > -1)
            {
                if (MessageBox.Show($"Удалить депо {ListBoxStation.SelectedItem.ToString()}?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    logger.Info($"Удалили депо {ListBoxStation.SelectedItem.ToString()}");
                    stationCollection.DelParking(ListBoxStation.SelectedItem.ToString());
                    ReloadLevels();
                }
            }
        }

        private void buttonAddStation_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TextBoxStationName.Text))
            {
                logger.Warn("При добавлении депо отсутствовало название");
                MessageBox.Show("Введите название депо", "Ошибка",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            logger.Info($"Добавили депо {TextBoxStationName.Text}");
            stationCollection.AddParking(TextBoxStationName.Text);
            ReloadLevels();
        }

        private void ListBoxStation_SelectedIndexChanged(object sender, EventArgs e)
        {

            logger.Info($"Перешли в депо {ListBoxStation.SelectedItem.ToString()}");
            Draw();
        }

        private void buttonSetTrain_Click(object sender, EventArgs e)
        {
            var form = new FormMonorailConfig();
            form.AddEvent(AddTrain);
            form.Show();
        }

        private void AddTrain(Vehicle Train)
        {
            if (Train != null && ListBoxStation.SelectedIndex > -1)
            {

                try
                {
                    if ((stationCollection[ListBoxStation.SelectedItem.ToString()]) + Train)
                    {
                        Draw();
                        logger.Info($"Добавлен поезд {Train}");
                    }
                    else
                    {
                        logger.Warn("Поезд не удалось добавить в депо");
                        MessageBox.Show("Поезд не удалось поставить");
                    }
                }
                catch (DepotOverflowException ex)
                {
                    logger.Warn("Произошло переполнение депо");
                    MessageBox.Show(ex.Message, "Переполнение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Машину не удалось поставить");
                    logger.Warn("Возникла неизвестная ошибка");
                    MessageBox.Show(ex.Message, "Неизвестная ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void saveToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    stationCollection.SaveData(saveFileDialog1.FileName);
                    MessageBox.Show("Сохранение успешно завершено", "Результат",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                    logger.Info("Сохранено в файл " + saveFileDialog1.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Неизвестная ошибка при сохранении",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                    logger.Warn("Возникла неизвестная ошибка при сохранении");
                }
            }
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    stationCollection.LoadData(openFileDialog1.FileName);
                    MessageBox.Show("Загрузка успешно завершена", "Результат", MessageBoxButtons.OK,
                   MessageBoxIcon.Information);
                    logger.Info("Загружено из файла " + openFileDialog1.FileName);
                    ReloadLevels();
                    Draw();
                }
                catch (DepotOccupiedPlaceException ex)
                {
                    MessageBox.Show(ex.Message, "Занятое место", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                    logger.Warn("Не удалось загрузить поезд в депо");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Неизвестная ошибка при загрузке",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                    logger.Warn("Возникла неизвестная ошибка при загрузке");
                }
            }
        }

        private void buttonSort_Click(object sender, EventArgs e)
        {
            if (ListBoxStation.SelectedIndex > -1)
            {
                stationCollection[ListBoxStation.SelectedItem.ToString()].Sort();
                Draw();
                logger.Info("Сортировка уровней");
            }
        }
    }
}
