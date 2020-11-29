using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1
{
    class StationCollection
    {
        /// <summary>
        /// Словарь (хранилище) с парковками
        /// </summary>
        readonly Dictionary<string, TrainStation<Vehicle>> StationStages;
        /// <summary>
        /// Возвращение списка названий праковок
        /// </summary>
        public List<string> Keys => StationStages.Keys.ToList();
        /// <summary>
        /// Ширина окна отрисовки
        /// </summary>
        private readonly int PictureWidth;
        /// <summary>
        /// Высота окна отрисовки
        /// </summary>
        private readonly int PictureHeight;
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="pictureWidth"></param>
        /// <param name="pictureHeight"></param>
        public StationCollection(int pictureWidth, int pictureHeight)
        {
            StationStages = new Dictionary<string, TrainStation<Vehicle>>();
            this.PictureWidth = pictureWidth;
            this.PictureHeight = pictureHeight;
        }

        /// <summary>
        /// Добавление парковки
        /// </summary>
        /// <param name="name">Название парковки</param>
        public void AddParking(string name)
        {
            if (StationStages.ContainsKey(name))
            {
                return;
            }

            StationStages.Add(name, new TrainStation<Vehicle>(PictureWidth, PictureHeight));
        }
        /// <summary>
        /// Удаление парковки
        /// </summary>
        /// <param name="name">Название парковки</param>
        public void DelParking(string name)
        {
            if (StationStages.ContainsKey(name))
            {
                StationStages.Remove(name);
            }
        }
        /// <summary>
        /// Доступ к парковке
        /// </summary>
        /// <param name="ind"></param>
        /// <returns></returns>
        public TrainStation<Vehicle> this[string ind]
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
