using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Barfi.Models
{
    public class Bar
    {
        public int ID { get; set; }
        [Required, Display(Name = "Name"), MaxLength(255)]
        public string name { get; set; }
        [Required]
        public bool WIFI { get; set; }
        [Required, Range(1,5)]
        public int starRating { get; set; }
        [Required, Range(-180,180)]
        public double latitude { get; set; }
        [Required, Range(-180,180), ]
        public double longitude { get; set; }
        


    }
}