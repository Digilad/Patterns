using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Patterns.Behavioural
{
    /// <summary>
    /// Iterator
    /// Итератор
    /// https://proglib.io/p/behavioral-patterns/
    /// </summary>

    public class Iterator
    {
        public void Using()
        {
            var stationList = new StationList();
            stationList.AddStation(new RadioStation(89));
            stationList.AddStation(new RadioStation(101));
            stationList.AddStation(new RadioStation(102));
            stationList.AddStation(new RadioStation(103.2f));
            foreach(var station in stationList)
            {
                Console.WriteLine($"{station.GetFrequency()}");
            }
            Console.WriteLine("");
            stationList.RemoteStation(new RadioStation(89));
            foreach (var station in stationList)
            {
                Console.WriteLine($"{station.GetFrequency()}");
            }
        }
    }

    public class StationList : IEnumerable<RadioStation>
    {
        List<RadioStation> stations;
        int counter;

        public StationList()
        {
            stations = new List<RadioStation>();
        }

        public void AddStation(RadioStation station)
        {
            stations.Add(station);
        }

        public void RemoteStation(RadioStation station)
        {
            RadioStation rs = stations.Where(x => x.GetFrequency() == station.GetFrequency()).FirstOrDefault();
            stations.Remove(rs);
        }

        public int Count()
        {
            return stations.Count;
        }

        public RadioStation Current()
        {
            return stations[counter];
        }

        public int Key()
        {
            return counter;
        }

        public void Next()
        {
            counter++;
        }

        public void Rewind()
        {
            counter = 0;
        }

        public bool Valid()
        {
            return stations[counter] != null;
        }

        public IEnumerator<RadioStation> GetEnumerator()
        {
            return stations.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    public class RadioStation
    {
        float frequency;

        public RadioStation(float frequency)
        {
            this.frequency = frequency;
        }

        public float GetFrequency()
        {
            return frequency;
        }
    }
}
