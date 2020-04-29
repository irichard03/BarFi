using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Barfi.Models
{
    public class GreetingViewModel
    {
        public IEnumerable<Bar> Bars { get; set; }
        public string Message { get; set; }

    }
}