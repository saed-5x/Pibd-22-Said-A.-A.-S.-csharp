using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsMonorail;

namespace lab_1
{
    class TrainComparer : IComparer<Vehicle>
    {
        public int Compare(Vehicle x, Vehicle y)
        {
            if (x is Monorail && y is Locomotive)
            {
                return -1;

            }
            if (x is Locomotive && y is Monorail)
            {
                return 1;

            }
            if (x is Monorail && y is Monorail)
            {
                return ComparerMonorail((Monorail)x, (Monorail)y);
            }
            if (x is Locomotive && y is Locomotive)
            {
                return ComparerTrain((Locomotive)x, (Locomotive)y);
            }

            return 0;
        }

        private int ComparerTrain(Locomotive x, Locomotive y)
        {
            if (x.MaxSpeed != y.MaxSpeed)
            {
                return x.MaxSpeed.CompareTo(y.MaxSpeed);
            }
            if (x.Weight != y.Weight)
            {
                return x.Weight.CompareTo(y.Weight);
            }
            if (x.BodyColor != y.BodyColor)
            {
                return x.BodyColor.Name.CompareTo(y.BodyColor.Name);
            }
            return 0;
        }

        private int ComparerMonorail(Monorail x, Monorail y)
        {
            var res = ComparerTrain(x, y);
            if (res != 0)
            {
                return res;
            }
            if (x.BodyColor != y.BodyColor)
            {
                return x.BodyColor.Name.CompareTo(y.BodyColor.Name);
            }
            if (x.Doors != y.Doors)
            {
                return x.Doors.CompareTo(y.Doors);
            }
            if (x.Window != y.Window)
            {
                return x.Window.CompareTo(y.Window);
            }
            if (x.SideStrip != y.SideStrip)
            {
                return x.SideStrip.Name.CompareTo(y.SideStrip.Name);
            }
            return 0;
        }
    }
}
