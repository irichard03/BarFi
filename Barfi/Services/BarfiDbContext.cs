using Barfi.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Barfi.Services
{
    public class BarfiDbContext : DbContext
    {
        public DbSet<Bar> Bars { get; set; }
    }
}