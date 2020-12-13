using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1
{
    class DepotCollection
    {
        readonly Dictionary<string, Depot<Vehicle>> StationStages;
        public List<string> Keys => StationStages.Keys.ToList();

        private readonly int PictureWidth;
        private readonly int PictureHeight;

        public DepotCollection(int pictureWidth, int pictureHeight)
        {
            StationStages = new Dictionary<string, Depot<Vehicle>>();
            this.PictureWidth = pictureWidth;
            this.PictureHeight = pictureHeight;
        }

        public void AddParking(string name)
        {
            if (StationStages.ContainsKey(name))
            {
                return;
            }

            StationStages.Add(name, new Depot<Vehicle>(PictureWidth, PictureHeight));
        }

        public void DelParking(string name)
        {
            if (StationStages.ContainsKey(name))
            {
                StationStages.Remove(name);
            }
        }
 
        public Depot<Vehicle> this[string ind]
        {
            get
            {
                if (StationStages.ContainsKey(ind))
                {
                    return StationStages[ind];
                }
                return null;
            }
        }
    }
}
