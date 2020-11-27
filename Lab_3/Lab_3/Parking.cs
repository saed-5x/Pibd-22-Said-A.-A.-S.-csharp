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
    public class Parking<T> where T : class, ITransport
    {
            /// <summary>
            /// Массив объектов, которые храним
            /// </summary>
            private T[] _places;
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
            private const int _placeSizeWidth = 669;
            /// <summary>
            /// Размер парковочного места (высота)
            /// </summary>
            private const int _placeSizeHeight = 100;

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="picWidth">Рамзер парковки - ширина</param>
        /// <param name="picHeight">Рамзер парковки - высота</param>
            public Parking(int sizes, int picWidth, int picHeight)
            {

                    int width = picWidth/ _placeSizeWidth;
                    int height = picHeight / _placeSizeHeight;
                    _places = new T[width * height];
                    PictureWidth = picWidth;
                    PictureHeight = picHeight;
                    for (int i = 0; i < _places.Length; i++)
                    {
                        _places[i] = null;
                    }
            }
            /// <summary>
            /// Перегрузка оператора сложения
            /// Логика действия: на парковку добавляется автомобиль
            /// </summary>
            /// <param name="p">Парковка</param>
            /// <param name="car">Добавляемый автомобиль</param>
            /// <returns></returns>
     

        public static bool operator +(Parking<T> p, T car)
        {
            int size = p.PictureHeight / _placeSizeHeight;

            for (int i = 0; i <= p._places.Length; i++)
            {
                if (p._places[i] == null)
                {
                  
                    car.SetPosition((i / size) * _placeSizeWidth + 400, (i % size) * _placeSizeHeight + 15, p.PictureWidth, p.PictureHeight);
                    p._places[i] = car;
                    return true;
                }
            }
            return false;

        }

        public static T operator -(Parking<T> p, int index)
            {
                if (index < 0 || index > p._places.Length)
                {
                    return null;
                }

                 
      
                    T car = p._places[index];
            car.SetPosition(400, 10, p.PictureWidth, p.PictureHeight);
            p._places[index] = null;
                    return car;
                
               
        }


            private bool CheckFreePlace(int index)
            {
                return _places[index] == null;
            }

            public void Draw(Graphics g)
            {
                DrawMarking(g);
                for (int i = 0; i < _places.Length; i++)
                {
                    if (!CheckFreePlace(i))
                    {//если место не пустое
                        _places[i].DrawMonorail(g);
                    }
                }
            }


            private void DrawMarking(Graphics g)
            {
                Pen pen = new Pen(Color.Black, 3);
                g.DrawRectangle(pen, 0, 0, (_places.Length / 5) * _placeSizeWidth, 600);
                for (int i = 0; i < _places.Length / 5; i++)
                {
                    for (int j = 0; j <= 10; ++j)
                    {
                        g.DrawLine(pen, i * _placeSizeWidth, j * _placeSizeHeight,i * _placeSizeWidth + 670, j * _placeSizeHeight);
                    }
                    g.DrawLine(pen, i * _placeSizeWidth, 0, i * _placeSizeWidth, 1000);
                }
            }
        }

 }

