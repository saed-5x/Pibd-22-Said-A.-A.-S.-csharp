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
            /// Массив объектов, которые храним
            /// </summary>
            private T[] Depot;
            /// <summary>
            /// Ширина окна отрисовки
            /// </summary>
            private int PictureWidth { get; set; }
            /// <summary>
            /// Высота окна отрисовки
            /// </summary>
            private int PictureHeight { get; set; }
            /// <summary>
            /// Размер парковочного места (ширина)
            /// </summary>
            private const int DepotWidth = 669;
            /// <summary>
            /// Размер парковочного места (высота)
            /// </summary>
            private const int DepotHeight = 100;

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="picWidth">Рамзер парковки - ширина</param>
        /// <param name="picHeight">Рамзер парковки - высота</param>
            public TrainStation(int sizes, int picWidth, int picHeight)
            {

                    int width = picWidth/ DepotWidth;
                    int height = picHeight / DepotHeight;
                    Depot = new T[width * height];
                    PictureWidth = picWidth;
                    PictureHeight = picHeight;
                    for (int i = 0; i < Depot.Length; i++)
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
            int size = trainStation.PictureHeight / DepotHeight;

            for (int i = 0; i <= trainStation.Depot.Length; i++)
            {
                if (trainStation.Depot[i] == null)
                {
                  
                    train.SetPosition((i / size) * DepotWidth + 400, (i % size) * DepotHeight + 15, trainStation.PictureWidth, trainStation.PictureHeight);
                    trainStation.Depot[i] = train;
                    return true;
                }
            }
            return false;

        }

        public static T operator -(TrainStation<T> trainStation, int index)
        {
                if (index < 0 || index > trainStation.Depot.Length)
                {
                    return null;
                }

                 
      
            T train = trainStation.Depot[index];
            train.SetPosition(400, 10, trainStation.PictureWidth, trainStation.PictureHeight);
            trainStation.Depot[index] = null;
            
            
            
            return train;                     
        }

        
            private bool CheckFreeDepot(int index)
            {
                return Depot[index] == null;
            }

            public void Draw(Graphics g)
            {
                DrawMarking(g);
                for (int i = 0; i < Depot.Length; i++)
                {
                    if (!CheckFreeDepot(i))
                    {
                        Depot[i].DrawMonorail(g);
                    }
                }
            }


            private void DrawMarking(Graphics g)
            {
                Pen pen = new Pen(Color.Black, 3);
                g.DrawRectangle(pen, 0, 0, (Depot.Length / 5) * DepotWidth, 600);
                for (int i = 0; i < Depot.Length / 5; i++)
                {
                    for (int j = 0; j <= 10; ++j)
                    {
                        g.DrawLine(pen, i * DepotWidth, j * DepotHeight,i * DepotWidth + 670, j * DepotHeight);
                    }
                    g.DrawLine(pen, i * DepotWidth, 0, i * DepotWidth, 1000);
                }
            }
        }

 }

