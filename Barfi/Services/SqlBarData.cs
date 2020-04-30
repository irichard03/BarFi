using Barfi.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Barfi.Services
{
    public class SqlBarData : IBarData
    {
        private readonly BarfiDbContext db;

        public SqlBarData(BarfiDbContext db)
        {
            this.db = db;
        }
        public void Add(Bar bar)
        {
            db.Bars.Add(bar);
            db.SaveChanges();
        }

        public Bar Get(int id)
        {
            return db.Bars.FirstOrDefault(b => b.ID == id);
        }

        public IEnumerable<Bar> getAll()
        {
            return db.Bars.OrderBy(b => b.name);
        }

        public void Update(Bar bar)
        {
            var entry = db.Entry(bar);
            entry.State = EntityState.Modified;
            db.SaveChanges();
        }
    }
}