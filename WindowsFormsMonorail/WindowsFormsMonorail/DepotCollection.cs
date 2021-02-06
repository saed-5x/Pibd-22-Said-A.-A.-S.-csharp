using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsMonorail;

namespace lab_1
{
    class DepotCollection
    {
        readonly Dictionary<string, Depot<Vehicle>> StationStages;
        public List<string> Keys => StationStages.Keys.ToList();
        private readonly int PictureWidth;
        private readonly int PictureHeight;
        private readonly char separator = ':';

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

        public bool SaveData(string filename)
        {
            if (File.Exists(filename))
            {
                File.Delete(filename);
            }

            using (StreamWriter sw = new StreamWriter(filename, false))
            {
                sw.WriteLine($"StationCollection", sw);
                foreach (var level in StationStages)
                {
                    sw.WriteLine($"Station{separator}{level.Key}", sw);

                    ITransport train;

                   for (int i = 0; (train = level.Value.GetNext(i)) != null; i++)
                    {
                        if (train != null)
                        {
                            if (train.GetType().Name == "Locomotive")
                            {
                                sw.Write($"Locomotive{separator}", sw);
                            }
                            if (train.GetType().Name == "Monorail")
                            {
                                sw.Write($"Monorail{separator}", sw);
                            }
                            sw.Write(train + sw.NewLine, sw);
                        }
                    }
                }
            }
            return true;
        }

        public bool LoadData(string filename)
        {
            if (!File.Exists(filename))
            {
                return false;
            }

            using (StreamReader sr = new StreamReader(filename))
            {
                string line;
                if ((line = sr.ReadLine()) != null)
                {
                    if (line.Contains("StationCollection"))
                    {
                        StationStages.Clear();
                    }
                    else
                    {
                        return false;
                    }

                    Vehicle train = null;

                    string key = string.Empty;

                    while ((line = sr.ReadLine()) != null)
                    {
                        if (line.Contains("Station"))
                        {
                            key = line.Split(separator)[1];
                            StationStages.Add(key, new Depot<Vehicle>(PictureWidth, PictureHeight));
                            continue;
                        }
                        if (string.IsNullOrEmpty(line))
                        {
                            continue;
                        }
                        if (line.Split(separator)[0] == "Locomotive")
                        {
                            train = new Locomotive(line.Split(separator)[1]);
                        }
                        else if (line.Split(separator)[0] == "Monorail")
                        {
                           train = new Monorail(line.Split(separator)[1]);
                        }

                        var result = StationStages[key] + train;
                        if (!result)
                        {
                            return false;
                        }
                    }
                }
                return true;
            }
        }
    }
}

