using System;

namespace Buildings
{
    public class Building
    {
        private static int _lastId;

        internal Building()
        {
            Id = ++_lastId;
        }

        #region Properties

        /// <summary>
        /// Получение Id здания.
        /// </summary>
        /// <returns></returns>
        public int Id { get; }

        /// <summary>
        /// Получение высоты.
        /// </summary>
        /// <returns></returns>
        public float Height { get; internal set; }

        /// <summary>
        /// Получение количества этажей.
        /// </summary>
        /// <returns></returns>
        public int Floors { get; internal set; }

        /// <summary>
        /// Получение количества квартир.
        /// </summary>
        /// <returns></returns>
        public int Flats { get; internal set; }

        /// <summary>
        /// Получение количества подъездов.
        /// </summary>
        /// <returns></returns>
        public int Entrances { get; internal set; }

        #endregion

        #region Internal methods

        /// <summary>
        /// Установка высоты.
        /// </summary>
        /// <param name="height">Высота</param>
        internal void SetHeight(float height)
        {
            if (height <= 0) throw new ArgumentOutOfRangeException(nameof(height), "Высота должна быть больше нуля");
            Height = height;
        }

        /// <summary>
        /// Установка этажей.
        /// </summary>
        /// <param name="levels"></param>
        internal void SetFloors(int levels)
        {
            if (levels <= 0) throw new ArgumentOutOfRangeException(nameof(levels), "Количество этажей должно быть больше нуля");
            Floors = levels;
        }

        /// <summary>
        /// Установка количества квартир.
        /// </summary>
        /// <param name="flats"></param>
        internal void SetFlats(int flats)
        {
            if (flats <= 0) throw new ArgumentOutOfRangeException(nameof(flats), "Количество квартир должно быть больше нуля");

            Flats = flats;
        }

        /// <summary>
        /// Установка подъездов.
        /// </summary>
        /// <param name="entrances"></param>
        internal void SetEntrances(int entrances)
        {
            if (entrances <= 0) throw new ArgumentOutOfRangeException(nameof(entrances), "Количество подъездов должно быть больше нуля");

            Entrances = entrances;
        }

        /// <summary>
        /// Получение высоты этажа.
        /// </summary>
        /// <returns></returns>
        internal float GetFloorHeight()
        {
            return Height / Floors;
        }

        /// <summary>
        /// Получение квартир в подъезде.
        /// </summary>
        /// <returns></returns>
        internal int GetFlatsInEntrance()
        {
            return Flats / Entrances;
        }

        /// <summary>
        /// Получение квартир на этаже.
        /// </summary>
        /// <returns></returns>
        internal int GetFlatsOnFloor()
        {
            return GetFlatsInEntrance() / Floors;
        }

        #endregion

        public override string ToString()
        {
            return $"Id: {Id}\n" +
                   $"Высота: {Height}\n" +
                   $"Этажность: {Floors}\n" +
                   $"Высота этажа: {GetFloorHeight():F2}\n" +
                   $"Кол-во квартир: {Flats}\n" +
                   $"Кол-во подъездов: {Entrances}\n" +
                   $"Кол-во квартир в подъезде: {GetFlatsInEntrance()}\n" +
                   $"Кол-во квартир на этаже: {GetFlatsOnFloor()}\n";
        }
    }
}
