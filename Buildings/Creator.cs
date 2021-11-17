using System.Collections.Generic;
using System.Linq;

namespace Buildings
{
    public class Creator
    {
        private const int DefaultFloors = 1;
        private const int DefaultFlatsPerFloor = 3;
        private const int DefaultEntrances = 1;
        private const float DefaultFloorHeight = 3.0f;

        private static readonly HashSet<Building> Buildings = new();

        private Creator()
        {}
        
        /// <summary>
        /// Создание здания
        /// </summary>
        /// <param name="height">Высота</param>
        /// <param name="floors">Кол-во этажей</param>
        /// <param name="flats">Кол-во квартир</param>
        /// <param name="entrances">Кол-во подъездов</param>
        /// <returns></returns>
        public static Building CreateBuilding(float height, int floors, int flats, int entrances)
        {
            var building = new Building();
            building.SetHeight(height);
            building.SetFloors(floors);
            building.SetFlats(flats);
            building.SetEntrances(entrances);
            Buildings.Add(building);

            return building;
        }

        /// <summary>
        /// Создание здания
        /// </summary>
        /// <param name="height">Высота</param>
        /// <returns></returns>
        public static Building CreateBuilding(float height)
        {
            return CreateBuilding(height, DefaultFloors, DefaultFlatsPerFloor, DefaultEntrances);
        }

        public static Building CreateBuilding(int flats)
        {
            var height = DefaultFloorHeight * flats / DefaultFlatsPerFloor;
            return CreateBuilding(height, DefaultFloors, DefaultFlatsPerFloor, DefaultEntrances);
        }

        /// <summary>
        /// Получение списка созданных зданий.
        /// </summary>
        /// <returns></returns>
        public static List<Building> GetBuildingsList()
        {
            return Buildings.ToList();
        }

        /// <summary>
        /// Удаление здания по Id.
        /// </summary>
        /// <param name="id"></param>
        public static void RemoveBuildingById(int id)
        {
            Buildings.RemoveWhere(x => x.Id == id);
        }
    }
}
