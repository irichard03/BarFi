using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Barfi.Models
{
    public class Bar
    {
        public int ID { get; set; }
        public string name { get; set; }
        public bool WIFI { get; set; }

        public int starRating { get; set; }
        public Dictionary<double, double> location { get; set; }

    }
}