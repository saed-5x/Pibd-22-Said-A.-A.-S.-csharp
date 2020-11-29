using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1
{
    /// <summary>
    /// Параметризованный класс для хранения набора объектов от интерфейса ITransport
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class TrainStation<T> where T : class, ITransport
    {
            /// <summary>
            /// Список объектов, которые храним
            /// </summary>
            private readonly List<T> Depot;
            /// <summary>
            /// Максимальное количество мест на парковке
            /// </summary>
            private readonly int MaxCount;
            /// <summary>
            /// Ширина окна отрисовки
            /// </summary>
            private readonly int PictureWidth;
            /// <summary>
            /// Высота окна отрисовки
            /// </summary>
            private readonly int PictureHeight;
            /// <summary>
            /// Размер парковочного места (ширина)
            /// </summary>
            private readonly int DepotWidth = 669;
            /// <summary>
            /// Размер парковочного места (высота)
            /// </summary>
            private readonly int DepotHeight = 100;
            /// <summary>
            /// Конструктор
            /// </summary>
            /// <param name="picWidth">Рамзер парковки - ширина</param>
            /// <param name="picHeight">Рамзер парковки - высота</param>
            public TrainStation( int picWidth, int picHeight)
            {

                    int width = picWidth/ DepotWidth;
                    int height = picHeight / DepotHeight;

                     MaxCount = width * height;
                    PictureWidth = picWidth;
                    PictureHeight = picHeight;
                    Depot = new List<T>();
                    for (int i = 0; i < Depot.Count; i++)
                    {
                        Depot[i] = null;
                    }
            }
            /// <summary>
            /// Перегрузка оператора сложения
            /// Логика действия: на парковку добавляется автомобиль
            /// </summary>
            /// <param name="trainStation">Парковка</param>
            /// <param name="train">Добавляемый автомобиль</param>
            /// <returns></returns>
     

        public static bool operator +(TrainStation<T> trainStation, T train)
        {
            if (trainStation.Depot.Count >= trainStation.MaxCount)
            {
                return false;
            }
            trainStation.Depot.Add(train);
            return true;

        }

        public static T operator -(TrainStation<T> trainStation, int index)
        {
            if (index < -1 || index > trainStation.Depot.Count)
            {
                return null;
            }
            T train = trainStation.Depot[index];
            trainStation.Depot.RemoveAt(index);


            return train;                     
        }

        
            private bool CheckFreeDepot(int index)
            {
                return Depot[index] == null;
            }

            public void Draw(Graphics g)
            {
                DrawMarking(g);
                for (int i = 0; i < Depot.Count; i++)
                {
                    if (!CheckFreeDepot(i))
                    {
                    Depot[i].SetPosition(5 + i / 10 * DepotWidth + 400, i % 10* DepotHeight + 10, PictureWidth, PictureHeight);
                    Depot[i].DrawMonorail(g);
                    }
                }
            }


            private void DrawMarking(Graphics g)
            {
                Pen pen = new Pen(Color.Black, 3);
                for (int i = 0; i < PictureWidth / DepotWidth+1; i++)
                {
                    for (int j = 0; j < PictureHeight / DepotHeight + 1; ++j)
                    {

                        g.DrawLine(pen, i * DepotWidth, j * DepotHeight, i * DepotWidth + DepotWidth+50 , j * DepotHeight);
                    }
                    g.DrawLine(pen, i * DepotWidth, 0, i * DepotWidth, (PictureHeight / DepotHeight) * DepotHeight);
                }
            }
    }

 }

