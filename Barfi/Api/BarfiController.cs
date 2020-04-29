using Barfi.Models;
using Barfi.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Barfi.Api
{
    public class BarfiController : ApiController
    {

        private readonly IBarData db;
        public BarfiController(IBarData db)
        {
            this.db = db;
        }

        //Get
        public IEnumerable<Bar> Get()
        {
            var model = db.getAll();
            return model;
        }
    }
}
