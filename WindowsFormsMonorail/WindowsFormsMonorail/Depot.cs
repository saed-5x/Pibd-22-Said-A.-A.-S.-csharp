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
        private readonly int DepotWidth = 669;
        private readonly int DepotHeight = 100;

        public Depot( int picWidth, int picHeight)
        {
                int width = picWidth/ DepotWidth;
                int height = picHeight / DepotHeight;
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
                Places[i].SetPosition(5 + i / 10 * DepotWidth + 400, i % 10* DepotHeight + 10, PictureWidth, PictureHeight);
                Places[i].DrawMonorail(g);
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

