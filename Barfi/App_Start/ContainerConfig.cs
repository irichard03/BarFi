using Autofac;
using Autofac.Integration.Mvc;
using Autofac.Integration.WebApi;
using Barfi.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace Barfi
{
    public class ContainerConfig
    {
        //Autofac Registers container on Application Start
        //by instantiating a new conainer object
        //runs registercontroller method to scan he MVC application assembly
        //routes replacing the registered type with the interface type.
        //If I need to change data set I only have to change the registered type.
        internal static void RegisterContainer(HttpConfiguration httpConfiguration)
        {
            var builder = new ContainerBuilder();
            builder.RegisterControllers(typeof(MvcApplication).Assembly);
            builder.RegisterApiControllers(typeof(MvcApplication).Assembly);
            builder.RegisterType<SqlBarData>()
                   .As<IBarData>()
                   .InstancePerRequest();
            builder.RegisterType<BarfiDbContext>().InstancePerRequest();

            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
            httpConfiguration.DependencyResolver = new AutofacWebApiDependencyResolver(container);
        }
    }
}