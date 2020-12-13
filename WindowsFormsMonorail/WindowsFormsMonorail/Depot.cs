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
        private readonly List<T> Places;
        private readonly int MaxCount;
        private readonly int PictureWidth;
        private readonly int PictureHeight;
        private readonly int PlaceWidth = 669;
        private readonly int PlaceHeight = 100;

        public Depot( int picWidth, int picHeight)
        {
            int width = picWidth/ PlaceWidth;
            int height = picHeight / PlaceHeight;

            MaxCount = width * height;
            PictureWidth = picWidth;
            PictureHeight = picHeight;
            Places = new List<T>();
            for (int i = 0; i < Places.Count; i++)
            {
                Places[i] = null;
            }
        }

        public static bool operator +(Depot<T> trainStation, T train)
        {
            if (trainStation.Places.Count >= trainStation.MaxCount)
            {
                return false;
            }
            trainStation.Places.Add(train);
            return true;

        }

        public static T operator -(Depot<T> trainStation, int index)
        {
            if (index < -1 || index > trainStation.Places.Count)
            {
                return null;
            }
            T train = trainStation.Places[index];
            trainStation.Places.RemoveAt(index);


            return train;                     
        }

        private bool CheckFreeDepot(int index)
        {
            return Places[index] == null;
        }

        public void Draw(Graphics g)
        {
            DrawMarking(g);
            for (int i = 0; i < Places.Count; i++)
            {
                if (!CheckFreeDepot(i))
                {
                Places[i].SetPosition(5 + i / 10 * PlaceWidth + 400, i % 10* PlaceHeight + 10, PictureWidth, PictureHeight);
                Places[i].DrawMonorail(g);
                }
            }
        }

        private void DrawMarking(Graphics g)
        {
            Pen pen = new Pen(Color.Black, 3);
            for (int i = 0; i < PictureWidth / PlaceWidth+1; i++)
            {
                for (int j = 0; j < PictureHeight / PlaceHeight + 1; ++j)
                {
                    g.DrawLine(pen, i * PlaceWidth, j * PlaceHeight, i * PlaceWidth + PlaceWidth+50 , j * PlaceHeight);
                }
                g.DrawLine(pen, i * PlaceWidth, 0, i * PlaceWidth, (PictureHeight / PlaceHeight) * PlaceHeight);
            }
        }
    }
 }

