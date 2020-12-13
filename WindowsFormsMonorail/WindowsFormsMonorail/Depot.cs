using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1
{
    public class Depot<T> where T : class, ITransport
    {
        private T[] Places;
        private int PictureWidth { get; set; }
        private int PictureHeight { get; set; }
        private const int PlacetWidth = 669;
        private const int PlaceHeight = 100;

        public Depot(int sizes, int picWidth, int picHeight)
        {
                int width = picWidth/ PlacetWidth;
                int height = picHeight / PlaceHeight;
            Places = new T[width * height];
                PictureWidth = picWidth;
                PictureHeight = picHeight;
                for (int i = 0; i < Places.Length; i++)
                {
                Places[i] = null;
                }
        }
        public static bool operator +(Depot<T> trainStation, T train)
        {
            int size = trainStation.PictureHeight / PlaceHeight;
            for (int i = 0; i <= trainStation.Places.Length; i++)
            {
                if (trainStation.Places[i] == null)
                {
                    train.SetPosition((i / size) * PlacetWidth + 400, (i % size) * PlaceHeight + 15, trainStation.PictureWidth, trainStation.PictureHeight);
                    trainStation.Places[i] = train;
                    return true;
                }
            }
            return false;
        }
        public static T operator -(Depot<T> trainStation, int index)
        {
                if (index < 0 || index > trainStation.Places.Length)
                {
                    return null;
                }

            T train = trainStation.Places[index];
            train.SetPosition(400, 10, trainStation.PictureWidth, trainStation.PictureHeight);
            trainStation.Places[index] = null;
            return train;                     
        }
        private bool CheckFreeDepot(int index)
        {
            return Places[index] == null;
        }
        public void Draw(Graphics g)
        {
            DrawMarking(g);
            for (int i = 0; i < Places.Length; i++)
            {
                if (!CheckFreeDepot(i))
                {
                    Places[i].DrawMonorail(g);
                }
            }
        }
        private void DrawMarking(Graphics g)
        {
            Pen pen = new Pen(Color.Black, 3);
            g.DrawRectangle(pen, 0, 0, (Places.Length / 5) * PlacetWidth, 600);
            for (int i = 0; i < Places.Length / 5; i++)
            {
                for (int j = 0; j <= 10; ++j)
                {
                    g.DrawLine(pen, i * PlacetWidth, j * PlaceHeight,i * PlacetWidth + 670, j * PlaceHeight);
                }
                g.DrawLine(pen, i * PlacetWidth, 0, i * PlacetWidth, 1000);
            }
        }
    }
 }

