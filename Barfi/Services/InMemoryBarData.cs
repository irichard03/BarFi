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
                    location = new Dictionary<double,double>()
                    {
                        { 40.7287,-73.9897 }
                    }

                },
                new Bar
                {
                    ID = 2,
                    name = "The Esquire Tavern",
                    WIFI = true,
                    starRating = 2,
                    location = new Dictionary<double,double>()
                    {
                        { 29.4247,-98.4918 }
                    }

                },
                new Bar
                {
                    ID = 3,
                    name = "Jake's Sports Bar",
                    WIFI = false,
                    starRating = 0,
                    location = new Dictionary<double,double>()
                    {
                        { 29.7346,-95.4769 }
                    }

                },

            };
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