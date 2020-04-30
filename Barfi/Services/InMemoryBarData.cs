using Barfi.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Barfi.Services
{
    public class InMemoryBarData : IBarData
    {
        List<Bar> bars;
        

        public InMemoryBarData()
        {
            bars = new List<Bar>()
            {
                new Bar
                {
                    ID = 1,
                    name = "McSorley's",
                    WIFI = true,
                    starRating = 5,
                    latitude = 40.7287,
                    longitude = -73.9897
                },
                new Bar
                {
                    ID = 2,
                    name = "The Esquire Tavern",
                    WIFI = true,
                    starRating = 2,
                    latitude = 29.4247,
                    longitude = -98.4918
                },
                new Bar
                {
                    ID = 3,
                    name = "Jake's Sports Bar",
                    WIFI = false,
                    starRating = 0,
                    latitude = 29.7346,
                    longitude = -95.4769
                },

            };
        }

        public Bar Get(int id)
        {
            return bars.FirstOrDefault(b =>b.ID == id);
        }

        public void Add(Bar bar)
        {
            bars.Add(bar);
            bar.ID = bars.Max(b => b.ID) + 1;  //hack to increment ID
        }

        public void Update(Bar bar)
        {
            var oldRecord = Get(bar.ID);
            if(oldRecord != null)
            {
                oldRecord.name = bar.name;
                oldRecord.WIFI = bar.WIFI;
                oldRecord.starRating = bar.starRating;
                oldRecord.latitude = bar.latitude;
                oldRecord.longitude = bar.longitude;
            }
        }

        public IEnumerable<Bar> getAll()
        {
            return bars.OrderBy(b => b.ID);
        }

        public IEnumerable<Bar> getBarsWithWIFI()
        {
            return bars.Where(b => b.WIFI == true);
        }

    }
}